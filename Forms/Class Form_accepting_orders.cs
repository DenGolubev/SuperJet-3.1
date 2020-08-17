using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SuperJet_3._1.Graphic;

/*
 * Форма принятия нарядов.
 * На форме вводятся только цифры, необходима проверка на ввод и кооличество
 * Наряды принимаются двумя способами
 * 1. По штрих коду при помощи сканера
 * 2. ручной ввод уникального номера и табельного номера сотрудника
 * по умолчанию на форме одно поле табельный номер сотрудника
 * В случае если в имени ресурса ВФМ указано два сотрудника - должно активироваться второе поле Табельный номер сотрутдника
 * Проверка ввода необходимых полей:
 * 1. Уникальный номер наряда - УНН - 20 цифр. Необходима проверка в существующем реестре на дубликат(Ранее уже принятый наряд)
 * 2. Табельные номера сотрудников выполнявших данный наряд - 6 цифр
 * 3. Сверка табельных номеров в названии и в поле на форме 
 * Все сходится - происходит запись в БД нажатием на кнопку button1 = "Принять наряды"
 * Вторая часть формы
 * Нв второй части расположны:
 * 1. Кнопка передать курьеру - при нажатии на кнопку статус нарядов в БД меняется на "Сдано" и формируется реестр в формате pdf.
 * 2. Кнопка возврат - переход на форму "Возврат нарядов"
 * 3. Сводная информация о нарядах - колличества меняются в зависимости от изминений в БД
 * 
 */

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
        private Button button2;
        private Button button3;
        private Timer timer;

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
            textBox1 = new My_textbox(this, true, 18F, 450, 100, 300);
            textBox1.KeyPress += TextBox1_KeyPress;
            //Timer timer1 = new My_timer();
            

            //Уникальный номер наряда label2 + textBox2
            label2 = new My_label(this, "Табельный номер сотрутдника", 20F, Color.Black, 10, 150);
            textBox2 = new My_textbox(this, true, 18F, 450, 150, 300);
            textBox2.KeyPress += TextBox2_KeyPress;

            //Уникальный номер наряда label3 + textBox3
            label3 = new My_label(this, "Табельный номер сотрутдника", 20F, Color.Black, 10, 200);
            textBox3 = new My_textbox(this, true, 18F, 450, 200, 300);
            textBox3.KeyPress += TextBox3_KeyPress;

            // Кнопка приема нарядов
            button1 = new My_Button(this, "Принять наряды", 12, 10, 250, 740, 40);
            button1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            button1.BackColor = Color.LightGreen;
            button1.Click += Button1_Click;

            
            //--------------------------------------------------------------------------------------

            // Кнопка передать курьеру
            button2 = new My_Button(this, "Передать курьеру", 12, 10, 330, 200, 80);
            button2.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            button2.BackColor = Color.Yellow;

            // Кнопка возврат
            button3 = new My_Button(this, "Возврат", 12, 10, 430, 200, 80);
            button3.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            button3.BackColor = Color.Coral;

            //Всего нарядов к сдаче label4 + textBox4
            label4 = new My_label(this, "Сдано нарядов", 20, Color.Black, 310, 330);
            textBox4 = new My_textbox(this, false, 20, 650, 330, 100);
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.TextAlign = HorizontalAlignment.Center;
                        

            //Принято нарядов label5 + textBox5
            label5 = new My_label(this, "Принято нарядов", 20, Color.Black, 310, 380);
            textBox5 = new My_textbox(this, false, 20, 650, 380, 100);
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.TextAlign = HorizontalAlignment.Center;

            //Передано нарядов курьеру label6 + textBox6
            label6 = new My_label(this, "Передано курьеру", 20, Color.Black, 310, 430);
            textBox6 = new My_textbox(this, false, 20, 650, 430, 100);
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.TextAlign = HorizontalAlignment.Center;

            //Возвращено нарядов label7 + textBox7
            label7 = new My_label(this, "Возвращено нарядов", 20, Color.Black, 310, 480);
            textBox7 = new My_textbox(this, false, 20, 650, 480, 100);
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.TextAlign = HorizontalAlignment.Center;
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer = new Timer();
            if (textBox1.Text == "" || textBox1.TextLength < 20)
            {
                textBox1.BackColor = Color.Red;
                textBox1.Focus();
            }
            else if (textBox2.Text == "" || textBox2.TextLength < 6)
            {
                textBox2.BackColor = Color.Red;
                textBox2.Focus();
            }
            else
            {
               new read_write_txt(textBox1.Text, textBox2.Text);
            }
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            timer.Dispose();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar <= 47 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= 47 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= 47 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
        }

        private void Class_Form_accepting_orders_Paint(object sender, PaintEventArgs e)
        {
            // Разделяющая линия
            new My_line(this, Color.Black, 4, 60, 310, 700, 310);
        }
    }
}
