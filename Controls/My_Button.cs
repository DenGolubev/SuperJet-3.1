using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuperJet_3._1
{
    class My_Button: Button
    {
        public My_Button(Form frm, string text, Single F, int x, int y, int h, int w)
        {
            this.Text = text;
            this.Font = new Font("Arial", F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.Location = new Point(x,y);
            this.Size = new Size(h, w);
            frm.Controls.Add(this);
        }

    }
}
