namespace Курсовая_работа
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.dataLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.netiPictureBox = new System.Windows.Forms.PictureBox();
            this.aboutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.netiPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // aboutPanel
            // 
            this.aboutPanel.Controls.Add(this.dataLabel);
            this.aboutPanel.Controls.Add(this.titleLabel);
            this.aboutPanel.Controls.Add(this.infoLabel);
            this.aboutPanel.Controls.Add(this.netiPictureBox);
            this.aboutPanel.Location = new System.Drawing.Point(12, 12);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Size = new System.Drawing.Size(416, 376);
            this.aboutPanel.TabIndex = 0;
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataLabel.Location = new System.Drawing.Point(158, 333);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(117, 38);
            this.dataLabel.TabIndex = 3;
            this.dataLabel.Text = "Новосибирск\r\n2022";
            this.dataLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(55, 99);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(309, 38);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Курсовая работа\r\nпо дисциплине \"Программирование\"";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Arial", 12.25F);
            this.infoLabel.Location = new System.Drawing.Point(212, 154);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(201, 171);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "Выполнил:\r\nСтудент 2 курса\r\nГруппы АВТ-113\r\nСагайдак А.Е.\r\n\r\nПроверил:\r\nСтарший п" +
    "реподаватель\r\nКафедры АСУ\r\nПопов Е.А.";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.infoLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // netiPictureBox
            // 
            this.netiPictureBox.Image = global::Курсовая_работа.Properties.Resources.logo1;
            this.netiPictureBox.InitialImage = null;
            this.netiPictureBox.Location = new System.Drawing.Point(3, 3);
            this.netiPictureBox.Name = "netiPictureBox";
            this.netiPictureBox.Size = new System.Drawing.Size(413, 79);
            this.netiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.netiPictureBox.TabIndex = 0;
            this.netiPictureBox.TabStop = false;
            this.netiPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 390);
            this.Controls.Add(this.aboutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.TopMost = true;
            this.aboutPanel.ResumeLayout(false);
            this.aboutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.netiPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel aboutPanel;
        private System.Windows.Forms.PictureBox netiPictureBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}