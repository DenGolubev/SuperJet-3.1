﻿using System;
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
            try
            {
                Class_main_MDI_form.Form_MDI.Show();
                new menu_strip(Class_main_MDI_form.Form_MDI);
                
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
