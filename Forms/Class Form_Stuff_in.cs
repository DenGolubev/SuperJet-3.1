using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SuperJet_3._1.Company;
using System.IO;

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
            new My_label(this, "Всего сотрудников", 20, 210);
            textbox1 = new My_textbox(this, 250, 20, 250);
            textbox2 = new My_textbox(this, 250, 60, 250);
            textbox3 = new My_textbox(this, 250, 100, 250);
            textbox4 = new My_textbox(this, 250, 140, 250);
            textbox5 = new My_textbox(this, 250, 210, 50);
            textbox5.Enabled = false;
            textbox5.Text = Convert.ToString(0);
            btn.Click += Btn_Click;
            this.Load += Class_Form_Stuff_in_Load;
            

        }

        private void Class_Form_Stuff_in_Load(object sender, EventArgs e)
        {
           
            // textbox5.Text = Convert.ToString(Stuff.Stuff_count);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Stuff sotrudnik = new Stuff();
                sotrudnik.Staff_tab_name = Convert.ToInt32(textbox4.Text);
                
                sotrudnik.Display(textbox1.Text, textbox2.Text, textbox3.Text, sotrudnik.Staff_tab_name);
              
            }
            catch(Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
                       
        }
    }
}

