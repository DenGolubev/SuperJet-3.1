using SuperJet_3._1.Controls;
using System.Windows.Forms;
using SuperJet_3._1.Graphic;
using System.Drawing;

namespace SuperJet_3._1
{
    class Class_Form_report_stuff: Class_BaseForm
    {
        
        public Class_Form_report_stuff() //Карточка эффективности сотрудника
        {
            //KPI — это коэффициент, определяющий эффективность работы того или иного предприятия: насколько оно удачно функционирует, достигает ли поставленных целей.
            //Расшифровка этой аббревиатуры выглядит следующим образом — Key Performance Indicators, что на русский принято переводить как «ключевые показатели эффективности».

            this.Name = "Report_stuff";  
            this.Text = "Отчет по сотруднику"; // + Combobox.value
            this.Size = new Size(800, 600);
            this.Paint += Class_Form_report_stuff_Paint;
            this.Load += Class_Form_report_stuff_Load;
            



        }

        private void Class_Form_report_stuff_Load(object sender, System.EventArgs e)
        {

            My_Combobox cb_box = new My_Combobox(this, 300, 50, 300, 50);
            new My_label(this, "Сотрудник", 16F, Color.Black, 150, 50);
                       
            // Надписи вертикальные "Показатель"
            new My_label(this, "Показатель", 20F, Color.Blue, 20, 135);
            new My_label(this, "ТТ 24 часа", 14F, Color.Black, 45, 190);
            new My_label(this, "Повторные ТТ", 14F, Color.Black, 30, 240);
            new My_label(this, "План продаж", 14F, Color.Black, 35, 290);
            new My_label(this, "Конвертация\n   интернет ", 13F, Color.Black, 35, 330);
            new My_label(this, "Конвертация ТВ", 14F, Color.Black, 23, 390);

            // Надписи горизонтальные
            new My_label(this, "Вес", 14F, Color.Blue, 203, 140);
            new My_label(this, "Значения", 12F, Color.Blue, 400, 129);
            new My_label(this, "База", 12F, Color.Blue, 276, 154);
            new My_label(this, "Норма", 12F, Color.Blue, 375, 154);
            new My_label(this, "Цель", 12F, Color.Blue, 484, 154);
            new My_label(this, "Факт", 12F, Color.Blue, 590, 154);
            new My_label(this, "Индекс\n    KPI", 14F, Color.Blue, 681, 128);

            // Надписи вертикальные "Вес"
            new My_label(this, "30%", 12F, Color.Green, 204, 190); // ТТ 24 часа
            new My_label(this, "6%", 12F, Color.Green, 207, 240); // Повторные ТТ
            new My_label(this, "30%", 12F, Color.Green, 204, 290); // План продаж
            new My_label(this, "12%", 12F, Color.Green, 204, 340); //Конвертация интернет
            new My_label(this, "12%", 12F, Color.Green, 204, 390); //Конвертация ТВ

            // Надписи вертикальные "База"
            new My_label(this, "0%", 20F, Color.Green, 278, 186); // ТТ 24 часа
            new My_label(this, "0%", 20F, Color.Green, 278, 236); // Повторные ТТ
            new My_label(this, "8 шт", 20F, Color.Green, 267, 286); // План продаж
            new My_label(this, "100%", 20F, Color.Green, 263, 336); //Конвертация интернет
            new My_label(this, "100%", 20F, Color.Green, 263, 386); //Конвертация ТВ

            // Надписи вертикальные "Норма"
            new My_label(this, "80%", 20F, Color.Green, 378, 186); // ТТ 24 часа
            new My_label(this, "10%", 20F, Color.Green, 378, 236); // Повторные ТТ
            new My_label(this, "6 шт", 20F, Color.Green, 370, 286); // План продаж
            new My_label(this, "80%", 20F, Color.Green, 378, 336); //Конвертация интернет
            new My_label(this, "80%", 20F, Color.Green, 378, 386); //Конвертация ТВ

            // Надписи вертикальные "Цель"
            new My_label(this, "86%", 20F, Color.Green, 478, 186); // ТТ 24 часа
            new My_label(this, "7%", 20F, Color.Green, 485, 236); // Повторные ТТ
            new My_label(this, "8 шт", 20F, Color.Green, 470, 286); // План продаж
            new My_label(this, "90%", 20F, Color.Green, 478, 336); //Конвертация интернет
            new My_label(this, "90%", 20F, Color.Green, 478, 386); //Конвертация ТВ

            // TextBox "Факт" фактическое значение
            My_textbox t_box1 = new My_textbox(this, false, 20, 588, 184, 50);  // ТТ 24 часа
            My_textbox t_box2 = new My_textbox(this, false, 20, 588, 234, 50); // Повторные ТТ
            My_textbox t_box3 = new My_textbox(this, false, 20, 588, 284, 50); // План продаж
            My_textbox t_box4 = new My_textbox(this, false, 20, 588, 334, 50); //Конвертация интернет
            My_textbox t_box5 = new My_textbox(this, false, 20, 588, 384, 50); //Конвертация ТВ

            // TextBox "Индекс KPI" 
            My_textbox t_box6 = new My_textbox(this, false, 20, 690, 184, 50);  // ТТ 24 часа
            My_textbox t_box7 = new My_textbox(this, false, 20, 690, 234, 50); // Повторные ТТ
            My_textbox t_box8 = new My_textbox(this, false, 20, 690, 284, 50); // План продаж
            My_textbox t_box9 = new My_textbox(this, false, 20, 690, 334, 50); //Конвертация интернет
            My_textbox t_box10 = new My_textbox(this, false, 20, 690, 384, 50); //Конвертация ТВ




        }

        private void Class_Form_report_stuff_Paint(object sender, PaintEventArgs e)
        {
            KPI_Table KPI = new KPI_Table();
            KPI.creat_KPI_table(this);
        }

        
    }
}
