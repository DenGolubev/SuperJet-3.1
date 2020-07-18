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
            ToolStripDropDownButton stuff = new ToolStripDropDownButton("Сотрудники");
            ToolStripMenuItem stuff_in = new ToolStripMenuItem("Принять сотрудника");
            stuff.DropDownItems.Add(stuff_in);
            stuff_in.Click += Stuff_in_Click;

            ToolStripDropDownButton file = new ToolStripDropDownButton("Файл");
            ToolStripMenuItem fileopen = new ToolStripMenuItem("Открыть файл");
            fileopen.Click += Fileopen_Click;
            file.DropDownItems.Add(fileopen);

            this.Items.Add(file);
            this.Items.Add(stuff);
            

            frm.Controls.Add(this);
        }

        private void Stuff_in_Click(object sender, EventArgs e)
        {
            Class_New_Form frm =  new Class_New_Form("Stuff", "Принять сотрудника", 600, 800);
            new My_Button(frm, "Принять", 650, 480, 100, 50);
            new My_label(frm, "Фамилия", 20, 20);
            new My_label(frm, "Имя", 20, 50);
            new My_label(frm, "Отчество", 20, 80);
            new My_textbox(frm, 120, 20);
            new My_textbox(frm, 120, 50);
            new My_textbox(frm, 120, 80);
        }

        private void Fileopen_Click(object sender, EventArgs e)
        {
           new  Open_File_Dialog();
        }
    }
}
