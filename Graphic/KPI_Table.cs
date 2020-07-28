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

            // Надписи вертикальные
            new My_label(frm, "Показатель", 20F, Color.Blue, 20, 135);
            new My_label(frm, "ТТ 24 часа", 14F, Color.Black, 45, 190);
            new My_label(frm, "Повторные ТТ", 14F, Color.Black, 30, 240);
            new My_label(frm, "План продаж", 14F, Color.Black, 35, 290);
            new My_label(frm, "Конвертация\n   интернет ", 13F, Color.Black, 35, 330);
            new My_label(frm, "Конвертация ТВ", 14F, Color.Black, 15, 390);

            // Надписи горизонтальные
            new My_label(frm, "Вес", 14F, Color.Blue, 203, 140);
            new My_label(frm, "Значения", 12F, Color.Blue, 400, 129);
            new My_label(frm, "База", 12F, Color.Blue, 276, 154);
            new My_label(frm, "Норма", 12F, Color.Blue, 375, 154);
            new My_label(frm, "Цель", 12F, Color.Blue, 484, 154);
            new My_label(frm, "Факт", 12F, Color.Blue, 590, 154);
            new My_label(frm, "Индекс\n    KPI", 14F, Color.Blue, 681, 128);

        }
    }
}
