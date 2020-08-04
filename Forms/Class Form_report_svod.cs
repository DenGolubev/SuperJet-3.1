using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperJet_3._1.Controls;

namespace SuperJet_3._1
{
    class Class_Form_report_svod: Class_BaseForm
    {
        TextBox[] textBoxes_array = new TextBox[5];
        Label[] labels_array = new Label[5];
        public Class_Form_report_svod()
        {
            this.Name = "Report_svod";
            this.Text = "Сводный отчет по площадке";
            this.WindowState = FormWindowState.Normal;
            this.Size = new System.Drawing.Size(800, 600);
            
            Button btn = new My_Button(this, "Сформировать", 580, 470, 180, 70);
            this.Load += Class_Form_report_svod_Load;
            btn.Click += Btn_Click;
            
        }

        private void Class_Form_report_svod_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < textBoxes_array.Length; i++)
            {
                string a = "Привет";
                textBoxes_array[i] = new My_textboxArray(this, 20, textBoxes_array.Length, 300, 10, 0, 50, 300);
                MessageBox.Show( Convert.ToString( textBoxes_array[i].Name));
            }

            for (int i = 0; i < labels_array.Length; i++)
            {
                labels_array[i] = new My_labelArray(this, 20, labels_array.Length, 10, 10, 0, 50, 300);
                //textBoxes[i].Text = "Новый текстбокс";
            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {

            
            
        }
    }
}
