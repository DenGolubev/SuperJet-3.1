using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperJet_3._1
{
    class Class_BaseForm: Form
    {
        public Class_BaseForm()
        {
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
