using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuperJet_3._1
{
    class My_label: Label
    {
        public My_label(Form frm, string text, Single f, Color clor_font, int x, int y)
        {
            this.Text = text;
            this.AutoSize = true;
            this.Font = new Font("Arial", f, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = clor_font;
            this.Location = new Point(x, y);
            frm.Controls.Add(this);
        }
    }
}
