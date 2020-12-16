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
    public partial class Main : UserControl
    {
        public Main()
        {
            InitializeComponent();
        }

        private void sendGifts_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            SendGiftsUserControl sg = new SendGiftsUserControl();
            Controls.Add(sg);

        }

        private void uploadData_Click_1(object sender, EventArgs e)
        {
            Controls.Clear();
            UploadDataUserControl up = new UploadDataUserControl();
            Controls.Add(up);
        }

        private void sendLetterBtn_Click_1(object sender, EventArgs e)
        {
            Controls.Clear();
            CardCreatorUC cc = new CardCreatorUC();
            Controls.Add(cc);
        }
    }
}
