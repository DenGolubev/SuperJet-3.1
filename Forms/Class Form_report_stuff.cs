using SuperJet_3._1.Company;
using SuperJet_3._1.Controls;
using System.Windows.Forms;
using System.IO;
using SuperJet_3._1.Graphic;
using System.Drawing;
using SuperJet_3._1.Graphic;

namespace SuperJet_3._1
{
    class Class_Form_report_stuff: Class_Form_report_svod
    {
       

        public Class_Form_report_stuff()
        {
            this.Name = "Report_stuff";  
            this.Text = "Отчет по сотруднику"; // + Combobox.value
            this.Size = new System.Drawing.Size(800, 600);
            this.Paint += Class_Form_report_stuff_Paint;
            My_Combobox cb_box = new My_Combobox(this, 200, 50, 300, 50);
            new My_label(this, "Сотрудник", 20, 50);
            
        }

        private void Class_Form_report_stuff_Paint(object sender, PaintEventArgs e)
        {
            Line l = new Line();
            l.new_line(this, Color.Black,1,50,200,200,200);
            l.new_line(this, Color.Black, 1, 50, 250, 200, 250);
            l.new_line(this, Color.Black, 1, 50, 200, 50, 250);
            l.new_line(this, Color.Black, 1, 200, 200, 200, 250);
        }

        
    }
}
