using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperJet_3._1
{
    class Class_Form_Stuff_out: Class_BaseForm
    {
        public Class_Form_Stuff_out()
        {
            this.Name = "Form Staff out";
            this.Text = "Form Staff out";
            this.Size = new System.Drawing.Size(530, 300);
            Button btn = new My_Button(this, "Уволить", 400, 200, 100, 50);
            new My_label(this, "Фамилия", 20, 20);
            new My_label(this, "Имя", 20, 60);
            new My_label(this, "Отчество", 20, 100);
            new My_label(this, "Табельный номер", 20, 140);
            new My_textbox(this, 250, 20, 250);
            new My_textbox(this, 250, 60, 250);
            new My_textbox(this, 250, 100, 250);
            new My_textbox(this, 250, 140, 250);
            btn.Click += Btn_Click;
            

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сотрудник уволен");
        }
    }
}
