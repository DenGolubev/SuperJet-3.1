using System.Windows.Forms;
using System.Drawing;

namespace SuperJet_3._1
{
    class Class_Form_Stuff_in: Class_BaseForm
    {
        private TextBox textbox1;
        private TextBox textbox2;
        private TextBox textbox3;
        private TextBox textbox4;
        private Label label0;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;

        public Class_Form_Stuff_in()
        {
            //Свойства формы
            this.Name = "Form Staff in";
            this.Text = "Форма принятия сотрудников";
            this.Size = new Size(530, 400);
            this.BackColor = Color.RoyalBlue;

            //Оглавление формы
            label0 = new My_label(this, "Принять сотрудника", 20F, Color.Black, 120, 20);
            label0.ForeColor = Color.LightSkyBlue;

            //Фамилия label1 + textbox1
            label1 = new My_label(this, "Фамилия", 16F, Color.Black, 20, 120);
            label1.ForeColor = Color.LightSkyBlue;
            textbox1 = new My_textbox(this, true, 250, 120, 250);
            textbox1.BackColor = Color.LightSkyBlue;

            //Имя label2 + textbox2
            label2 = new My_label(this, "Имя", 16F, Color.Black, 20, 160);
            label2.ForeColor = Color.LightSkyBlue;
            textbox2 = new My_textbox(this, true, 250, 160, 250);
            textbox2.BackColor = Color.LightSkyBlue;

            //Отчество label3 + textbox3
            label3 = new My_label(this, "Отчество", 16F, Color.Black, 20, 200);
            label3.ForeColor = Color.LightSkyBlue;
            textbox3 = new My_textbox(this, true, 250, 200, 250);
            textbox3.BackColor = Color.LightSkyBlue;

            //Табельный номер
            label4 = new My_label(this, "Табельный номер", 16F, Color.Black, 20, 240);
            label4.ForeColor = Color.LightSkyBlue;
            textbox4 = new My_textbox(this, true, 250, 240, 250);
            textbox4.BackColor = Color.LightSkyBlue;

            //Кнопка Принять
            button1 = new My_Button(this, "Принять", 400, 300, 100, 50);
            button1.BackColor = Color.LightSkyBlue;
         
        }
    }
}

