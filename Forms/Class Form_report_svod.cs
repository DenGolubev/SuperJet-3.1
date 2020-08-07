using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuperJet_3._1
{
    class Class_Form_report_svod: Class_BaseForm
    {
        Label label0, label1, label2, label3, label4, label5, label6, label7, label8;
        TextBox textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8;
        
        public Class_Form_report_svod()
        {
            this.Name = "Report_svod";
            this.Text = "Сводный отчет по площадке";
            this.WindowState = FormWindowState.Normal;
            this.Size = new System.Drawing.Size(800, 600);
            
            
            creat_controls();
         }

        public void creat_controls()
        {
            label0 = new My_label(this, "Сводный отчет по площадке", 20, Color.Black, 170, 30);
            label1 = new My_label(this, "Конвертация интернет", 20, Color.Black, 10, 100);
            label2 = new My_label(this, "Конвертация ТВ", 20, Color.Black, 10, 150);
            label3 = new My_label(this, "Выполнение плана продаж", 20, Color.Black, 10, 200);
            label4 = new My_label(this, "Подключение 48 часов", 20, Color.Black, 10, 250);
            label5 = new My_label(this, "Ремонт 24 часа", 20, Color.Black, 10, 300);
            label6 = new My_label(this, "Аварийность ПОН", 20, Color.Black, 10, 350);
            label7 = new My_label(this, "Повторные выезды на ремонт", 20, Color.Black, 10, 400);
            label8 = new My_label(this, "Разовые услуги", 20, Color.Black, 10, 450);

            textBox1 = new My_textbox(this, true, 20, 500, 100, 100);
            textBox2 = new My_textbox(this, true, 20, 500, 150, 100);
            textBox3 = new My_textbox(this, true, 20, 500, 200, 100);
            textBox4 = new My_textbox(this, true, 20, 500, 250, 100);
            textBox5 = new My_textbox(this, true, 20, 500, 300, 100);
            textBox6 = new My_textbox(this, true, 20, 500, 350, 100);
            textBox7 = new My_textbox(this, true, 20, 500, 400, 100);
            textBox8 = new My_textbox(this, true, 20, 500, 450, 100);

            Button button1 = new My_Button(this, "С\nФ\nО\nР\nМ\nИ\nР\nО\nВ\nА\nТ\nЬ", 16, 650, 100, 100, 390);
            button1.BackColor = Color.LightGreen;
            button1.Click += Btn_Click;
        }

       
        private void Btn_Click(object sender, EventArgs e)
        {

            MessageBox.Show(textBox1.Text +" "+ textBox2.Text +""+ textBox3.Text + " " + textBox4.Text + " " + textBox5.Text);
            
        }

    }
}
