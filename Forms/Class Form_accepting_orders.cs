using System.Drawing;
using System.Windows.Forms;
using System;


namespace SuperJet_3._1
{
    class Class_Form_accepting_orders: Class_BaseForm
    {
        Label label; 
        DateTime dt = new DateTime();
        public Class_Form_accepting_orders()
        {
            this.Name = "Accept_order";
            this.Text = "Форма принятия нарядов";
            this.WindowState = FormWindowState.Normal;
            this.Size = new System.Drawing.Size(800, 600);
            dt = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            new My_label(this, "Форма приема нарядов", 30F, Color.Black, 150, 30);
            label = new My_label(this, Convert.ToString(dt), 30F, Color.Black, 150, 100);
            
        }
    }
}
