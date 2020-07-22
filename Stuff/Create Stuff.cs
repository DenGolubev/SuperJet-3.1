using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperJet_3._1.Stuff
{
    public class creat_Stuff: Stuffs
    {
        public static int count = 0;
        public static string new_creat_Stuff = null;


        public creat_Stuff(string familia, string imya, string otchestvo, int namber)
        {
                if (string.IsNullOrEmpty(familia))
                {
                    throw new ArgumentNullException(nameof(familia));
                }
                if (string.IsNullOrEmpty(imya))
                {
                    throw new ArgumentNullException(nameof(imya));
                }
                if (string.IsNullOrEmpty(otchestvo))
                {
                    throw new ArgumentNullException(nameof(otchestvo));
                }
                if (string.IsNullOrEmpty(Convert.ToString(namber)))
                {
                    throw new ArgumentNullException(nameof(namber));
                }

            l_name = familia;
            f_name = imya;
            m_name = otchestvo;
            tab_n = namber;
            count++;

           
            MessageBox.Show("Сотрудник" + " " + l_name + " " + f_name + " " + m_name + " " + "принят на работу");
                        
        }
        public override string ToString()
        {
            new_creat_Stuff = base.ToString();
            return new_creat_Stuff;
        }


    }
}
