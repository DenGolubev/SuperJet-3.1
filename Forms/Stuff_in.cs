using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperJet_3._1.Forms
{
    public partial class Stuff_in : Form
    {
        public Stuff_in()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Company.Employee stuff = new Company.Employee(textBox1.Text, textBox2.Text, textBox3.Text);
            stuff.Show_Stuff();
        }
    }
}
