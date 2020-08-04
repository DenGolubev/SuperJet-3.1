using System.Drawing;
using System.Windows.Forms;
using SuperJet_3._1.Graphic;

namespace SuperJet_3._1
{
    class Class_Form_accepting_orders: Class_BaseForm
    {
        private Label label0;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button1;



        public Class_Form_accepting_orders()
        {
            this.Name = "Accept_order";
            this.Text = "Форма принятия нарядов";
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(800, 600);
            this.Paint += Class_Form_accepting_orders_Paint;

            //Оглавление формы
            label0 = new My_label(this, "Форма приема нарядов", 30F, Color.Black, 150, 30);

            //Уникальный номер наряда label1 + textBox1
            label1 = new My_label(this, "Уникальный номер наряда", 20F, Color.Black, 10, 100);
            textBox1 = new My_textbox(this, true, 450, 100, 300);

            //Уникальный номер наряда label2 + textBox2
            label2 = new My_label(this, "Табельный номер сотрутдника", 20F, Color.Black, 10, 150);
            textBox2 = new My_textbox(this, true, 450, 150, 300);

            //Уникальный номер наряда label3 + textBox3
            label3 = new My_label(this, "Табельный номер сотрутдника", 20F, Color.Black, 10, 200);
            textBox3 = new My_textbox(this, true, 450, 200, 300);

            // Кнопка приема нарядов
            button1 = new My_Button(this, "Принять наряды", 10, 250, 740, 40);
            button1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            button1.BackColor = Color.LightGreen;

            //--------------------------------------------------------------------------------------

            // Кнопка передать курьеру
            button1 = new My_Button(this, "Передать курьеру", 10, 330, 200, 80);
            button1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            button1.BackColor = Color.Yellow;

            // Кнопка возврат
            button1 = new My_Button(this, "Возврат", 10, 430, 200, 80);
            button1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            button1.BackColor = Color.Red;

            //Всего нарядов к сдаче label4 + textBox4
            label4 = new My_label(this, "Всего нарядов к сдаче", 20F, Color.Black, 250, 330);
            textBox4 = new My_textbox(this, false, 650, 330, 100);
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.TextAlign = HorizontalAlignment.Center;
                        

            //Принято нарядов label5 + textBox5
            label5 = new My_label(this, "Принято нарядов", 20F, Color.Black, 250, 380);
            textBox5 = new My_textbox(this, false, 650, 380, 100);
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.TextAlign = HorizontalAlignment.Center;

            //Передано нарядов курьеру label6 + textBox6
            label6 = new My_label(this, "Передано нарядов курьеру", 20F, Color.Black, 250, 430);
            textBox6 = new My_textbox(this, false, 650, 430, 100);
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.TextAlign = HorizontalAlignment.Center;

            //Возвращено нарядов label7 + textBox7
            label7 = new My_label(this, "Возвращено нарядов", 20F, Color.Black, 250, 480);
            textBox7 = new My_textbox(this, false, 650, 480, 100);
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.TextAlign = HorizontalAlignment.Center;
            
        }

        private void Class_Form_accepting_orders_Paint(object sender, PaintEventArgs e)
        {
            // Разделяющая линия
            new My_line(this, Color.Black, 4, 60, 310, 700, 310);
        }
    }
}
