using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperJet_3._1
{
    class Class_MDI_Form: Form
    {
        public Class_MDI_Form()
        {
            this.Name = "Main Menu Form";
            this.Text = "Основная форма SuperJet";
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.Show();
        }
    }
}
