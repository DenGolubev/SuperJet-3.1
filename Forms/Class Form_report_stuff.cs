using SuperJet_3._1.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJet_3._1
{
    class Class_Form_report_stuff: Class_Form_report_svod
    {
        public Class_Form_report_stuff()
        {
            this.Name = "Report_stuff";  
            this.Text = "Отчет по сотруднику"; // + Combobox.value
            this.Size = new System.Drawing.Size(800, 600);
            
        }
    }
}
