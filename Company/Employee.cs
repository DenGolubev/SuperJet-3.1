using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperJet_3._1.Company
{
    public class Employee
    {
        
        
       string[] stuff = new string[30];
       public Employee(string a, string b, string c)
        {
            int i = 0;
            stuff[i] = a + " " + b + " " + c;
            i++;
        }

        public void Show_Stuff()
        {
            foreach(string a in stuff)
            {
                MessageBox.Show(a);
            }
            
        }
        
    }
    
}
