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

        private void addNew_Click(object sender, EventArgs e)
        {
            ComboBox cb = new ComboBox();
            Controls.Add(cb);
            cb.Width = giftCombo.Width;
            cb.Top = addNew.Top + 25;
            cb.Left = giftCombo.Left;
            NumericUpDown nu = new NumericUpDown();
            Controls.Add(nu);
            nu.Width = quantityUpDown.Width;
            nu.Top = addNew.Top + 25;
            nu.Left = quantityUpDown.Left;
            addNew.Top = addNew.Top + 25;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.Register(
                    senderPhoneTxt.Text,
                    senderEmailTxt.Text);
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
