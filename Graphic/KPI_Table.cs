using System.Drawing;
using System.Windows.Forms;

namespace SuperJet_3._1.Graphic
{
    class KPI_Table
    {
        
        public void creat_KPI_table(Form frm)
        {
            
            // Горизонтальные линии
            new My_line(frm, Color.Black, 3, 250, 150, 666, 150);
            new My_line(frm, Color.Black, 3, 10, 125, 770, 125);
            new My_line(frm, Color.Black, 3, 10, 175, 770, 175);
            new My_line(frm, Color.Black, 3, 10, 225, 770, 225);
            new My_line(frm, Color.Black, 3, 10, 275, 770, 275);
            new My_line(frm, Color.Black, 3, 10, 325, 770, 325);
            new My_line(frm, Color.Black, 3, 10, 375, 770, 375);
            new My_line(frm, Color.Black, 3, 10, 425, 770, 425);

            // Вертикальные линии
            new My_line(frm, Color.Black, 3, 10, 125, 10, 425);
            new My_line(frm, Color.Black, 3, 770, 125, 770, 425);
            new My_line(frm, Color.Black, 3, 200, 125, 200, 425);
            new My_line(frm, Color.Black, 3, 250, 125, 250, 425);
            new My_line(frm, Color.Black, 3, 354, 150, 354, 425);
            new My_line(frm, Color.Black, 3, 458, 150, 458, 425);
            new My_line(frm, Color.Black, 3, 562, 150, 562, 425);
            new My_line(frm, Color.Black, 3, 666, 125, 666, 425);

            //// Надписи вертикальные "Показатель"
            //new My_label(frm, "Показатель", 20F, Color.Blue, 20, 135);
            //new My_label(frm, "ТТ 24 часа", 14F, Color.Black, 45, 190);
            //new My_label(frm, "Повторные ТТ", 14F, Color.Black, 30, 240);
            //new My_label(frm, "План продаж", 14F, Color.Black, 35, 290);
            //new My_label(frm, "Конвертация\n   интернет ", 13F, Color.Black, 35, 330);
            //new My_label(frm, "Конвертация ТВ", 14F, Color.Black, 23, 390);

            //// Надписи горизонтальные
            //new My_label(frm, "Вес", 14F, Color.Blue, 203, 140);
            //new My_label(frm, "Значения", 12F, Color.Blue, 400, 129);
            //new My_label(frm, "База", 12F, Color.Blue, 276, 154);
            //new My_label(frm, "Норма", 12F, Color.Blue, 375, 154);
            //new My_label(frm, "Цель", 12F, Color.Blue, 484, 154);
            //new My_label(frm, "Факт", 12F, Color.Blue, 590, 154);
            //new My_label(frm, "Индекс\n    KPI", 14F, Color.Blue, 681, 128);

            //// Надписи вертикальные "Вес"
            //new My_label(frm, "30%", 12F, Color.Green, 204, 190); // ТТ 24 часа
            //new My_label(frm, "6%", 12F, Color.Green, 207, 240); // Повторные ТТ
            //new My_label(frm, "30%", 12F, Color.Green, 204, 290); // План продаж
            //new My_label(frm, "12%", 12F, Color.Green, 204, 340); //Конвертация интернет
            //new My_label(frm, "12%", 12F, Color.Green, 204, 390); //Конвертация ТВ

            //// Надписи вертикальные "База"
            //new My_label(frm, "0%", 20F, Color.Green, 278, 186); // ТТ 24 часа
            //new My_label(frm, "0%", 20F, Color.Green, 278, 236); // Повторные ТТ
            //new My_label(frm, "8 шт", 20F, Color.Green, 267, 286); // План продаж
            //new My_label(frm, "100%", 20F, Color.Green, 263, 336); //Конвертация интернет
            //new My_label(frm, "100%", 20F, Color.Green, 263, 386); //Конвертация ТВ

            //// Надписи вертикальные "Норма"
            //new My_label(frm, "80%", 20F, Color.Green, 378, 186); // ТТ 24 часа
            //new My_label(frm, "10%", 20F, Color.Green, 378, 236); // Повторные ТТ
            //new My_label(frm, "6 шт", 20F, Color.Green, 370, 286); // План продаж
            //new My_label(frm, "80%", 20F, Color.Green, 378, 336); //Конвертация интернет
            //new My_label(frm, "80%", 20F, Color.Green, 378, 386); //Конвертация ТВ

            //// Надписи вертикальные "Цель"
            //new My_label(frm, "86%", 20F, Color.Green, 478, 186); // ТТ 24 часа
            //new My_label(frm, "7%", 20F, Color.Green, 485, 236); // Повторные ТТ
            //new My_label(frm, "8 шт", 20F, Color.Green, 470, 286); // План продаж
            //new My_label(frm, "90%", 20F, Color.Green, 478, 336); //Конвертация интернет
            //new My_label(frm, "90%", 20F, Color.Green, 478, 386); //Конвертация ТВ

            //// TextBox "Факт" фактическое значение
            //My_textbox t_box1 = new My_textbox(frm, false, 588, 184, 50);  // ТТ 24 часа
            //My_textbox t_box2 = new My_textbox(frm, false, 588, 234, 50); // Повторные ТТ
            //My_textbox t_box3 = new My_textbox(frm, false, 588, 284, 50); // План продаж
            //My_textbox t_box4 = new My_textbox(frm, false, 588, 334, 50); //Конвертация интернет
            //My_textbox t_box5 = new My_textbox(frm, false, 588, 384, 50); //Конвертация ТВ

            //// TextBox "Индекс KPI" 
            //My_textbox t_box6 = new My_textbox(frm, false, 690, 184, 50);  // ТТ 24 часа
            //My_textbox t_box7 = new My_textbox(frm, false, 690, 234, 50); // Повторные ТТ
            //My_textbox t_box8 = new My_textbox(frm, false, 690, 284, 50); // План продаж
            //My_textbox t_box9 = new My_textbox(frm, false, 690, 334, 50); //Конвертация интернет
            //My_textbox t_box10 = new My_textbox(frm, false, 690, 384, 50); //Конвертация ТВ




        }
    }
}
