namespace Курсовая_работа
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.сеансToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завершитьСеансToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьАбитуриентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бакалавриатспециалитетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокАбитуриентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сеансToolStripMenuItem,
            this.списокАбитуриентовToolStripMenuItem,
            this.добавитьАбитуриентаToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1177, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // сеансToolStripMenuItem
            // 
            this.сеансToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.завершитьСеансToolStripMenuItem});
            this.сеансToolStripMenuItem.Name = "сеансToolStripMenuItem";
            this.сеансToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.сеансToolStripMenuItem.Text = "Сеанс";
            // 
            // завершитьСеансToolStripMenuItem
            // 
            this.завершитьСеансToolStripMenuItem.Name = "завершитьСеансToolStripMenuItem";
            this.завершитьСеансToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.завершитьСеансToolStripMenuItem.Text = "Выйти из программы";
            this.завершитьСеансToolStripMenuItem.Click += new System.EventHandler(this.завершитьСеансToolStripMenuItem_Click);
            // 
            // добавитьАбитуриентаToolStripMenuItem
            // 
            this.добавитьАбитуриентаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.бакалавриатспециалитетToolStripMenuItem});
            this.добавитьАбитуриентаToolStripMenuItem.Name = "добавитьАбитуриентаToolStripMenuItem";
            this.добавитьАбитуриентаToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.добавитьАбитуриентаToolStripMenuItem.Text = "Добавить абитуриента";
            // 
            // бакалавриатспециалитетToolStripMenuItem
            // 
            this.бакалавриатспециалитетToolStripMenuItem.Name = "бакалавриатспециалитетToolStripMenuItem";
            this.бакалавриатспециалитетToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.бакалавриатспециалитетToolStripMenuItem.Text = "Бакалавриат/специалитет";
            this.бакалавриатспециалитетToolStripMenuItem.Click += new System.EventHandler(this.бакалавриатспециалитетToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // списокАбитуриентовToolStripMenuItem
            // 
            this.списокАбитуриентовToolStripMenuItem.Name = "списокАбитуриентовToolStripMenuItem";
            this.списокАбитуриентовToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.списокАбитуриентовToolStripMenuItem.Text = "Список абитуриентов";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 588);
            this.panel1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 627);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приемная кампания";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem сеансToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завершитьСеансToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьАбитуриентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бакалавриатспециалитетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокАбитуриентовToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}