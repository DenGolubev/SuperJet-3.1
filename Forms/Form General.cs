using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuperJet_3._1
{
    public partial class Form_General: Form
    {
        private MenuStrip menuStrip1;
        public Form_General()
        {
            
           InitializeComponent();
            
        }
       
        // Cоздание формы main при нажатии на кнопку
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Class_main_MDI_form.Form_MDI.Show();
                menuStrip1 = new menu_strip(Class_main_MDI_form.Form_MDI);
                menuStrip1.BackColor = Color.Bisque;
                menuStrip1.Height = 20;
                menuStrip1.Font = new Font("Arial", 18F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));

            }
            catch(ObjectDisposedException msg)
            {
                MessageBox.Show(msg.ObjectName);
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    
}
