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
            cb.Width = comboBox1.Width;
            cb.Top = addNew.Top + 25;
            cb.Left = comboBox1.Left;
            NumericUpDown nu = new NumericUpDown();
            Controls.Add(nu);
            nu.Width = numericUpDown1.Width;
            nu.Top = addNew.Top + 25;
            nu.Left = numericUpDown1.Left;
            addNew.Top = addNew.Top + 25;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successful");
        }


        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
