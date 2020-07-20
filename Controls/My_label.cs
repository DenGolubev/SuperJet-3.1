using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperJet_3._1
{
    class My_label: Label
    {
        public My_label(Form frm, string text, int x, int y)
        {
            this.Text = text;
            this.AutoSize = true;
            this.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.Location = new Point(x, y);
            frm.Controls.Add(this);
        }
    }
}
