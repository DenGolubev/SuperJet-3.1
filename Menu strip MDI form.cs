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

            ToolStripDropDownButton order = new ToolStripDropDownButton("Наряды");
            ToolStripMenuItem accept_order = new ToolStripMenuItem("Принять наряды");
            ToolStripMenuItem return_order = new ToolStripMenuItem("Вернуть наряды");
            ToolStripMenuItem search_order = new ToolStripMenuItem("Найти наряды");
            order.DropDownItems.Add(accept_order);
            order.DropDownItems.Add(return_order);
            order.DropDownItems.Add(search_order);
            accept_order.Click += Accept_order_Click;
            return_order.Click += Return_order_Click;
            search_order.Click += Search_order_Click;

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
            this.Items.Add(order);
            this.Items.Add(stuff);
            this.Items.Add(report);


            frm.Controls.Add(this);
            frm.FormClosing += Frm_FormClosing;
        }

        
        // Формы работы с нарядами
        private void Accept_order_Click(object sender, EventArgs e)
        {
            Form Form_accept_order = new Class_Form_accepting_orders();
            Form_accept_order.Show();
        }

        private void Return_order_Click(object sender, EventArgs e)
        {
            Form Form_return_orders = new Class_Form_return_orders();
            Form_return_orders.Show();
        }

        private void Search_order_Click(object sender, EventArgs e)
        {
            Form Form_search_orders = new Class_Form_search_orders();
            Form_search_orders.Show();
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
