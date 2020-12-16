using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_project_GXMRLU.Entities
{
    public class GiftBox : Label
    {
        public GiftBox()
        {
            AutoSize = false;
            Width = 60;
            Height = 60;
            Paint += Box_Paint;
            Top = 10;
            Left = 160;
        }

        private void Box_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }


        protected void DrawImage(Graphics g)
        {
  
            g.FillRectangle(new SolidBrush(Color.Red), 0, 0, 60, 60);
            g.FillRectangle(new SolidBrush(Color.Green), 0, 25, 60, 10);
            g.FillRectangle(new SolidBrush(Color.Green), 25, 0, 10, 60);

        }

    }

}
