using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_project_GXMRLU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendGifts_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            SendGiftsUserControl sg = new SendGiftsUserControl();
            panel1.Controls.Add(sg);

        }

        private void uploadData_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UploadDataUserControl up = new UploadDataUserControl();
            panel1.Controls.Add(up);
        }

        private void sendLetterBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CardCreatorUC cc = new CardCreatorUC();
            panel1.Controls.Add(cc);
        }
    }
}
