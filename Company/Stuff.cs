using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SuperJet_3._1.Company
{

    public class Stuff
    {
        public string Stuff_f_name { get; set; }
        public string Stuff_m_name { get; set; }
        public string Stuff_l_name { get; set; }
        public int Staff_tab_name { get; set; }


        public void Display(string familia, string imya, string otchestvo, int namber)
        {
            Stuff_l_name = familia;
            Stuff_f_name = imya;
            Stuff_m_name = otchestvo;
            Staff_tab_name = namber;

            Stuf_in = Stuff_l_name +" "+ Stuff_f_name + " " + Stuff_m_name + " " + Convert.ToString(Staff_tab_name);
            MessageBox.Show(Stuf_in);
        }
        
    }
}
