using SuperJet_3._1.Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperJet_3._1
{
    class Class_Form_Stuff_in: Class_BaseForm
    {
        TextBox textbox1;
        TextBox textbox2;
        TextBox textbox3;
        TextBox textbox4;
        TextBox textbox5;

        public Class_Form_Stuff_in()
        {
            this.Name = "Form Staff in";
            this.Text = "Form Staff in";
            this.Size = new System.Drawing.Size(530, 300);
            Button btn = new My_Button(this, "Принять", 400, 200, 100, 50);
            new My_label(this, "Фамилия", 20, 20);
            new My_label(this, "Имя", 20, 60);
            new My_label(this, "Отчество", 20, 100);
            new My_label(this, "Табельный номер", 20, 140);
            new My_label(this, "Всего сотрудников", 20, 200);
            textbox1 = new My_textbox(this, 250, 20, 250);
            textbox2 = new My_textbox(this, 250, 60, 250);
            textbox3 = new My_textbox(this, 250, 100, 250);
            textbox4 = new My_textbox(this, 250, 140, 250);
            textbox5 = new My_textbox(this, 250, 200, 50);
            textbox5.Enabled = false;
            btn.Click += Btn_Click;
            
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            try
            {
                object my_stuff = new creat_Stuff(textbox1.Text, textbox2.Text, textbox3.Text, Convert.ToInt32(textbox4.Text));
                textbox5.Text = Convert.ToString(creat_Stuff.count);
            }
            catch
            {
                MessageBox.Show("Не верный формат данных");
            }
                                             
        }
    }
}
