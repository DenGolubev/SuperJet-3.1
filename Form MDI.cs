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
    public partial class Form_MDI : Form
    {
        public Form_MDI()
        {
            InitializeComponent();
            new menu_strip(this);
        }
    }
}
