using System.Windows.Forms;
using System.Drawing;

namespace SuperJet_3._1.Controls
{
    class My_listbox: ListBox
    {
       public My_listbox(Form frm, int x, int y, int w, int h)
        {
            this.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.Size = new Size(w, h);
            this.Location = new Point(x, y);
        }
    }
}
