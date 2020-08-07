﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuperJet_3._1
{
    class My_label: Label
    {
        public My_label(Form frm, string text, Single f, Color clor_font, int x, int y)
        {
            this.Text = text;
            this.AutoSize = true;
            this.Font = new Font("Arial", f, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = clor_font;
            this.Location = new Point(x, y);
            frm.Controls.Add(this);
        }

    }

    class My_labelArray : Label
    {
        private Label[] labels;

        public My_labelArray(Form frm, float F, int count_textbox, int x, int y, int x_step, int y_step, int w)
        {
            int count = count_textbox;
            labels = new Label[count];
            for (int i = 0; i < count; i++)
            {
                labels[i] = new Label();
                x = x + x_step;
                y = y + y_step;
                labels[i].Text = "label_" + i.ToString();
                labels[i].Location = new Point(x, y);
                labels[i].Width = w;
                labels[i].AutoSize = true;
                labels[i].Font = new Font("Arial", F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                frm.Controls.Add(labels[i]);

            }

        }
    }
}