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
            this.делаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бакалавриатспециалитетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.магистратураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аспирантураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сеансToolStripMenuItem,
            this.делаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1179, 24);
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
            this.завершитьСеансToolStripMenuItem.Text = "Завершить сеанс";
            this.завершитьСеансToolStripMenuItem.Click += new System.EventHandler(this.завершитьСеансToolStripMenuItem_Click);
            // 
            // делаToolStripMenuItem
            // 
            this.делаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.бакалавриатспециалитетToolStripMenuItem,
            this.магистратураToolStripMenuItem,
            this.аспирантураToolStripMenuItem});
            this.делаToolStripMenuItem.Name = "делаToolStripMenuItem";
            this.делаToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.делаToolStripMenuItem.Text = "Добавить студента";
            // 
            // бакалавриатспециалитетToolStripMenuItem
            // 
            this.бакалавриатспециалитетToolStripMenuItem.Name = "бакалавриатспециалитетToolStripMenuItem";
            this.бакалавриатспециалитетToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.бакалавриатспециалитетToolStripMenuItem.Text = "Бакалавриат/специалитет";
            // 
            // магистратураToolStripMenuItem
            // 
            this.магистратураToolStripMenuItem.Name = "магистратураToolStripMenuItem";
            this.магистратураToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.магистратураToolStripMenuItem.Text = "Магистратура";
            // 
            // аспирантураToolStripMenuItem
            // 
            this.аспирантураToolStripMenuItem.Name = "аспирантураToolStripMenuItem";
            this.аспирантураToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.аспирантураToolStripMenuItem.Text = "Аспирантура";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 630);
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
        private System.Windows.Forms.ToolStripMenuItem делаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бакалавриатспециалитетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem магистратураToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аспирантураToolStripMenuItem;
    }
}