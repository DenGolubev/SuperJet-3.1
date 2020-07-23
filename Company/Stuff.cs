using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperJet_3._1.Company
{

    public class Stuff: Company
    {
        public static int Stuff_count = 0;
        public string Stuff_Area_name { get; set; }
        public string Stuff_f_name { get; set; }
        public string Stuff_m_name { get; set; }
        public string Stuff_l_name { get; set; }
        public int Staff_tab_name { get; set; }
        

        public void Display()
        {
            Stuff_count++;
            MessageBox.Show(Stuff_l_name + " " + Stuff_f_name + " " + Stuff_m_name);
        }
        
    }
}
