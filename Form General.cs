using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperJet_3._1
{
    public partial class Form_General: Form
    {
        public Form_General()
        {
           InitializeComponent();
           
        }
        // Cоздание формы main при нажатии на кнопку
        private void button1_Click(object sender, EventArgs e)
        {
         Class_New_Form Main_menu_form =  new Class_New_Form("Main Menu Form", "Main Menu Form", true, true);
         new menu_strip(Main_menu_form);
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    
}
