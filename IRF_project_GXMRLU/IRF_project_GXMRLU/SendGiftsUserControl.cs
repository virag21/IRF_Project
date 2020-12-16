using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_project_GXMRLU
{
    public partial class SendGiftsUserControl : UserControl
    {
        private OrderChecker _controller = new OrderChecker();
        public SendGiftsUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.Register(
                    senderTxt.Text,
                    senderPhoneTxt.Text,
                    senderEmailTxt.Text,
                    nameTxt.Text,
                    addressTxt.Text,
                    (string)giftCombo.SelectedItem,
                    (int)quantityUpDown.Value
                    );
                MessageBox.Show("Successful!");
                senderTxt.Text = "";
                senderPhoneTxt.Text = "";
                senderEmailTxt.Text = "";
                nameTxt.Text = "";
                addressTxt.Text = "";
                giftCombo.SelectedItem = default;
                quantityUpDown.Value = default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Main m = new Main();
            Controls.Add(m);
        }
    }

}
