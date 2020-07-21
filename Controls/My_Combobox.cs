using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SuperJet_3._1.Controls
{
    class My_Combobox: ComboBox
    {
        public My_Combobox(Form frm, int x, int y, int w, int h)
        {
            this.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.Size = new Size(w, h);
            this.Location = new Point(x, y);
            this.Items.AddRange(new object[] {"Item 1",
                        "Item 2",
                        "Item 3",
                        "Item 4",
                        "Item 5"});

            frm.Controls.Add(this);
        }
    }
}
