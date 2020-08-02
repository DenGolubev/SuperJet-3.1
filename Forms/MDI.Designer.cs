namespace SuperJet_3._1.Forms
{
    partial class MDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нарядыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.принятьСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уволитьСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.принятьНарядыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.возвратНарядовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьTaskListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.нарядыToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1319, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьTaskListToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.принятьСотрудникаToolStripMenuItem,
            this.уволитьСотрудникаToolStripMenuItem});
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // нарядыToolStripMenuItem
            // 
            this.нарядыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.принятьНарядыToolStripMenuItem,
            this.возвратНарядовToolStripMenuItem});
            this.нарядыToolStripMenuItem.Name = "нарядыToolStripMenuItem";
            this.нарядыToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.нарядыToolStripMenuItem.Text = "Наряды";
            // 
            // принятьСотрудникаToolStripMenuItem
            // 
            this.принятьСотрудникаToolStripMenuItem.Name = "принятьСотрудникаToolStripMenuItem";
            this.принятьСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.принятьСотрудникаToolStripMenuItem.Text = "Принять сотрудника";
            this.принятьСотрудникаToolStripMenuItem.Click += new System.EventHandler(this.принятьСотрудникаToolStripMenuItem_Click);
            // 
            // уволитьСотрудникаToolStripMenuItem
            // 
            this.уволитьСотрудникаToolStripMenuItem.Name = "уволитьСотрудникаToolStripMenuItem";
            this.уволитьСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.уволитьСотрудникаToolStripMenuItem.Text = "Уволить сотрудника";
            // 
            // принятьНарядыToolStripMenuItem
            // 
            this.принятьНарядыToolStripMenuItem.Name = "принятьНарядыToolStripMenuItem";
            this.принятьНарядыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.принятьНарядыToolStripMenuItem.Text = "Принять наряды";
            // 
            // возвратНарядовToolStripMenuItem
            // 
            this.возвратНарядовToolStripMenuItem.Name = "возвратНарядовToolStripMenuItem";
            this.возвратНарядовToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.возвратНарядовToolStripMenuItem.Text = "Возврат нарядов";
            // 
            // загрузитьTaskListToolStripMenuItem
            // 
            this.загрузитьTaskListToolStripMenuItem.Name = "загрузитьTaskListToolStripMenuItem";
            this.загрузитьTaskListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьTaskListToolStripMenuItem.Text = "Загрузить TaskList";
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 594);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.Text = "MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьTaskListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem принятьСотрудникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уволитьСотрудникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нарядыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem принятьНарядыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem возвратНарядовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
    }
}