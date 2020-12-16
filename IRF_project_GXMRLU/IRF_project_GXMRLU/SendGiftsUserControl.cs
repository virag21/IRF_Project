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
        public SendGiftsUserControl()
        {
            InitializeComponent();
        }

        private void addNew_Click(object sender, EventArgs e)
        {
            ComboBox cb = new ComboBox();
            Controls.Add(cb);
            cb.Width = giftTxt.Width;
            cb.Top = addNew.Top + 25;
            cb.Left = giftTxt.Left;
            NumericUpDown nu = new NumericUpDown();
            Controls.Add(nu);
            nu.Width = quantityUpDown.Width;
            nu.Top = addNew.Top + 25;
            nu.Left = quantityUpDown.Left;
            addNew.Top = addNew.Top + 25;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successful");
            Order o = new Order();
            o.Sender = senderTxt.Text;
            o.SenderEmail = senderEmailTxt.Text;
            o.SenderPhone = senderPhoneTxt.Text;
            o.Name = nameTxt.Text;
            o.Address = addressTxt.Text;
            o.Gift = giftTxt.Text;
            o.Quantity = (int)quantityUpDown.Value;


        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Main m = new Main();
            Controls.Add(m);
        }
    }

}
