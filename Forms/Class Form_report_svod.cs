using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperJet_3._1.Controls;

namespace SuperJet_3._1
{
    class Class_Form_report_svod: Form
    {
        public Class_Form_report_svod()
        {
            this.Name = "Report_svod";
            this.Text = "Сводный отчет по площадке"; // + Combobox.value
            this.WindowState = FormWindowState.Normal;
            this.Size = new System.Drawing.Size(800, 600);
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            Button btn = new My_Button(this, "Сформировать", 580, 470, 180, 70);
            ComboBox cb_box = new My_Combobox(this, 200, 50, 300, 50);
            new My_label(this, "Сотрудник", 20, 50);
            btn.Click += Btn_Click;

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
