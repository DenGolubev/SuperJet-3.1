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
            ToolStripDropDownButton file = new ToolStripDropDownButton("Файл");
            ToolStripMenuItem fileopen = new ToolStripMenuItem("Открыть файл");
            fileopen.Click += Fileopen_Click;
            file.DropDownItems.Add(fileopen);

            ToolStripDropDownButton stuff = new ToolStripDropDownButton("Сотрудники");
            ToolStripMenuItem stuff_in = new ToolStripMenuItem("Принять сотрудника");
            ToolStripMenuItem stuff_out = new ToolStripMenuItem("Уволить сотрудника");
            stuff.DropDownItems.Add(stuff_in);
            stuff.DropDownItems.Add(stuff_out);
            stuff_in.Click += Stuff_in_Click;
            stuff_out.Click += Stuff_out_Click;

            ToolStripDropDownButton report = new ToolStripDropDownButton("Отчеты");
            ToolStripMenuItem report_svod = new ToolStripMenuItem("Сводный отчет по площадке");
            ToolStripMenuItem report_stuff = new ToolStripMenuItem("Сводный отчет по сотруднику");
            report.DropDownItems.Add(report_svod);
            report.DropDownItems.Add(report_stuff);
            report_svod.Click += Report_svod_Click;
            report_stuff.Click += Report_stuff_Click;

            this.Items.Add(file);
            this.Items.Add(stuff);
            this.Items.Add(report);


            frm.Controls.Add(this);
            frm.FormClosing += Frm_FormClosing;
        }

        // Удаление экземпляра меню при закрытии MDI формы
        private void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void Report_stuff_Click(object sender, EventArgs e)
        {
            Form Form_report_stuff = new Class_Form_report_stuff();
            Form_report_stuff.Show();
        }

        private void Report_svod_Click(object sender, EventArgs e)
        {
            Form Form_report_svod = new Class_Form_report_svod();
            Form_report_svod.Show();
        }

        private void Stuff_out_Click(object sender, EventArgs e)
        {
            Form Stuff_out = new Class_Form_Stuff_out();
            Stuff_out.Show();
        }

        
        private void Stuff_in_Click(object sender, EventArgs e)
        {
            Form Stuff_in = new Class_Form_Stuff_in();
            Stuff_in.Show();
            
        }

        
        private void Fileopen_Click(object sender, EventArgs e)
        {
           new  Open_File_Dialog();
        }
    }
}
