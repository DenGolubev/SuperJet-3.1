using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperJet_3._1
{
    class My_textbox: TextBox
    {
        public My_textbox(Form frm, bool status_textbox, int x, int y, int w)
        {
            this.Enabled = status_textbox;
            this.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.Width = w;
            this.Location = new Point(x, y);
            frm.Controls.Add(this);
        }
    }
}
