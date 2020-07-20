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
        public menu_strip(Form frm)
        {
            ToolStripDropDownButton stuff = new ToolStripDropDownButton("Сотрудники");
            ToolStripMenuItem stuff_in = new ToolStripMenuItem("Принять сотрудника");
            ToolStripMenuItem stuff_out = new ToolStripMenuItem("Уволить сотрудника");
            stuff.DropDownItems.Add(stuff_in);
            stuff.DropDownItems.Add(stuff_out);
            stuff_in.Click += Stuff_in_Click;
            stuff_out.Click += Stuff_out_Click;

            ToolStripDropDownButton file = new ToolStripDropDownButton("Файл");
            ToolStripMenuItem fileopen = new ToolStripMenuItem("Открыть файл");
            fileopen.Click += Fileopen_Click;
            file.DropDownItems.Add(fileopen);

            this.Items.Add(file);
            this.Items.Add(stuff);
            

            frm.Controls.Add(this);
        }

        private void Stuff_out_Click(object sender, EventArgs e)
        {
            Form Stuff_out = new Class_Form_Stuff_out();
            Stuff_out.MdiParent = Class_main_MDI_form.Form_MDI;
            Stuff_out.Show();
        }

        
        private void Stuff_in_Click(object sender, EventArgs e)
        {
            Form Stuff_in = new Class_Form_Stuff_in();
            Stuff_in.MdiParent = Class_main_MDI_form.Form_MDI;
            Stuff_in.Show();
            
        }

        
        private void Fileopen_Click(object sender, EventArgs e)
        {
           new  Open_File_Dialog();
        }
    }
}
