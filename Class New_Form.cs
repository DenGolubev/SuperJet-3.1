using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperJet_3._1
{
    class Class_New_Form: Form
    {
        public Class_New_Form(string name, string text, bool mdi, bool Window_State)
        {
            this.Name = name;
            this.Text = text;
            this.IsMdiContainer = mdi;
            if(Window_State == true)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (Window_State == false)
            {
                this.WindowState = FormWindowState.Normal;
            }
            this.Show();
        }

        public Class_New_Form(string name, string text, int h, int w, Class_New_Form frm)
        {
            this.Name = name;
            this.Text = text;
            this.Height = h;
            this.Width = w;
            this.MdiParent = frm;
            this.Show();
        }

    }
}
