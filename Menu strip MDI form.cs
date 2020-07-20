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
            Class_New_Form frm = new Class_New_Form("Stuff_out", "Уволить сотрудника", 300, 530, Form_MDI.ActiveForm);
            Button btn = new My_Button(frm, "Уволить", 400, 200, 100, 50);
            //new My_Button(frm, "Уволить", 400, 200, 100, 50);
            new My_label(frm, "Фамилия", 20, 20);
            new My_label(frm, "Имя", 20, 60);
            new My_label(frm, "Отчество", 20, 100);
            new My_label(frm, "Табельный номер", 20, 140);
            new My_textbox(frm, 250, 20, 250);
            new My_textbox(frm, 250, 60, 250);
            new My_textbox(frm, 250, 100, 250);
            new My_textbox(frm, 250, 140, 250);
            btn.Click += Btn_Click1;
        }

        private void Btn_Click1(object sender, EventArgs e)
        {
            MessageBox.Show("Сотрудник уволен");
        }

        private void Stuff_in_Click(object sender, EventArgs e)
        {

            Class_New_Form frm =  new Class_New_Form("Stuff_in", "Принять сотрудника", 300, 530, Form_MDI.ActiveForm);
            Button btn = new My_Button(frm, "Принять", 400, 200, 100, 50);
            //new My_Button(frm, "Принять", 400, 200, 100, 50);
            new My_label(frm, "Фамилия", 20, 20);
            new My_label(frm, "Имя", 20, 60);
            new My_label(frm, "Отчество", 20, 100);
            new My_label(frm, "Табельный номер", 20, 140);
            new My_textbox(frm, 250, 20, 250);
            new My_textbox(frm, 250, 60, 250);
            new My_textbox(frm, 250, 100, 250);
            new My_textbox(frm, 250, 140, 250);
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сотрудник принят на работу");
        }

        private void Fileopen_Click(object sender, EventArgs e)
        {
           new  Open_File_Dialog();
        }
    }
}
