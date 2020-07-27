using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SuperJet_3._1.Graphic
{
    class Line
    {
        public void new_line(Form frm, Color color, int myPen_Width, int x1, int y1, int x2, int y2)
        {
            Graphics g;
            g = frm.CreateGraphics();
            Pen myPen  = new Pen(color);
            myPen.Width = myPen_Width;
            g.DrawLine(myPen, x1, y1, x2, y2);

        }
    }
}
