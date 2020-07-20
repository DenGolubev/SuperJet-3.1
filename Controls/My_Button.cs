using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperJet_3._1
{
    class My_Button: Button
    {
        public My_Button(Class_New_Form frm, string text, int x, int y, int h, int w)
        {
            this.Text = text;
            this.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.Location = new Point(x,y);
            this.Size = new Size(h, w);
            frm.Controls.Add(this);
        }

    }
}
