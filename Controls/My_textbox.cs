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
        public My_textbox(Form frm, bool status_textbox, float F, int x, int y, int w)
        {
            this.Enabled = status_textbox;
            this.Font = new Font("Arial", F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.Width = w;
            this.Location = new Point(x, y);
            frm.Controls.Add(this);
        }

    }

    class My_textboxArray : TextBox
    {
        private TextBox[] textBox;

        public My_textboxArray(Form frm, float F, int count_textbox, int x, int y, int x_step, int y_step, int w)
        {
            int count = count_textbox;
            textBox = new TextBox[count];
            for (int i = 0; i < count; i++)
            {
                textBox[i] = new TextBox();
                x = x+x_step;
                y = y+y_step;
                textBox[i].Name = "textBox" + i.ToString();
                textBox[i].Location = new Point(x, y);
                textBox[i].Width = w;
                textBox[i].Font = new Font("Arial", F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                frm.Controls.Add(textBox[i]);

            }

        }
    }
}
