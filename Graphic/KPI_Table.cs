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

        }
    }
}
