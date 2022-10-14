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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сеансToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завершитьСеансToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьАбитуриентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бакалавриатспециалитетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сеансToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.добавитьАбитуриентаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1177, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.завершитьСеансToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.завершитьСеансToolStripMenuItem.Text = "Выход";
            this.завершитьСеансToolStripMenuItem.Click += new System.EventHandler(this.завершитьСеансToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 627);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приемная кампания";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сеансToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завершитьСеансToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьАбитуриентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бакалавриатспециалитетToolStripMenuItem;
    }
}