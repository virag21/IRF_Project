using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace IRF_project_GXMRLU.Entities
{
    public class Tree:Label
    {
        

        public Tree()
        {
            AutoSize = false;
            Width = 60;
            Height = 60;
            Paint += Ball_Paint;
            Top = 10;
            Left = 100;
        }

        private void Ball_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        
        protected void DrawImage(Graphics g)
        {
            Point[] pnt = new Point[3];
            pnt[0].X = 30;
            pnt[0].Y = 0;

            pnt[1].X = 60 ;
            pnt[1].Y = 20;

            pnt[2].X = 0;
            pnt[2].Y = 20;

            Point[] pnt2 = new Point[3];
            pnt2[0].X = 30;
            pnt2[0].Y = 15;

            pnt2[1].X = 60;
            pnt2[1].Y = 35;

            pnt2[2].X = 0;
            pnt2[2].Y = 35;

            Point[] pnt3 = new Point[3];
            pnt3[0].X = 30;
            pnt3[0].Y = 30;

            pnt3[1].X = 60;
            pnt3[1].Y = 50;

            pnt3[2].X = 0;
            pnt3[2].Y = 50;

            g.FillPolygon(new SolidBrush(Color.Green), pnt);
            g.FillPolygon(new SolidBrush(Color.Green), pnt2);
            g.FillPolygon(new SolidBrush(Color.Green), pnt3);
            g.FillRectangle(new SolidBrush(Color.Brown), 22,50,15,5);

        }

    }
}
