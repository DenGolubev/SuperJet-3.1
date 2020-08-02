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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void принятьСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stuff_in stuff = new Stuff_in();
            stuff.Show();
        }
    }
}
