using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperJet_3._1
{
    class menu_strip: MenuStrip
    {
        public menu_strip(Class_New_Form frm)
        {
            ToolStripDropDownButton file = new ToolStripDropDownButton("File");
            ToolStripMenuItem fileopen = new ToolStripMenuItem("File Open");
            fileopen.Click += Fileopen_Click;
            this.Items.Add(file);
            file.DropDownItems.Add(fileopen);
            frm.Controls.Add(this);
        }

        private void Fileopen_Click(object sender, EventArgs e)
        {
           new  Open_File_Dialog();
        }
    }
}
