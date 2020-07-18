using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperJet_3._1
{
    class Class_New_Form
    {
        
        public static void creat_form(string name, string text, bool mdi, bool Window_State)
        {
            Form frm = new Form();
            frm.Name = name;
            frm.Text = text;
            frm.IsMdiContainer = mdi;
            if(Window_State == true)
            {
                frm.WindowState = FormWindowState.Maximized;
            }
            else if (Window_State == false)
            {
                frm.WindowState = FormWindowState.Normal;
            }
            frm.Show();
        }

    }
}
