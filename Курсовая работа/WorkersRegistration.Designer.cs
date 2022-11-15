namespace Курсовая_работа
{
    partial class WorkersRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkersRegistration));
            this.admRadioButton = new System.Windows.Forms.RadioButton();
            this.workerRadioButton = new System.Windows.Forms.RadioButton();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.registrationButton = new System.Windows.Forms.Button();
            this.loginPassLabel = new System.Windows.Forms.Label();
            this.registrationPassTextBox = new System.Windows.Forms.TextBox();
            this.loginPassTextBox = new System.Windows.Forms.TextBox();
            this.registrationPassLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // admRadioButton
            // 
            this.admRadioButton.AutoSize = true;
            this.admRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.admRadioButton.Location = new System.Drawing.Point(79, 306);
            this.admRadioButton.Name = "admRadioButton";
            this.admRadioButton.Size = new System.Drawing.Size(172, 28);
            this.admRadioButton.TabIndex = 14;
            this.admRadioButton.Text = "Администратор";
            this.admRadioButton.UseVisualStyleBackColor = true;
            // 
            // workerRadioButton
            // 
            this.workerRadioButton.AutoSize = true;
            this.workerRadioButton.Checked = true;
            this.workerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.workerRadioButton.Location = new System.Drawing.Point(79, 282);
            this.workerRadioButton.Name = "workerRadioButton";
            this.workerRadioButton.Size = new System.Drawing.Size(113, 28);
            this.workerRadioButton.TabIndex = 13;
            this.workerRadioButton.TabStop = true;
            this.workerRadioButton.Text = "Работник";
            this.workerRadioButton.UseVisualStyleBackColor = true;
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationLabel.Location = new System.Drawing.Point(62, 22);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(381, 84);
            this.registrationLabel.TabIndex = 7;
            this.registrationLabel.Text = "Регистрация сотрудника\r\nприемной комиссии";
            this.registrationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.registrationLabel.Click += new System.EventHandler(this.registrationLabel_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.registrationButton.Font = new System.Drawing.Font("Arial", 15.25F);
            this.registrationButton.Location = new System.Drawing.Point(153, 350);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(212, 41);
            this.registrationButton.TabIndex = 15;
            this.registrationButton.Text = "Зарегистрировать";
            this.registrationButton.UseVisualStyleBackColor = true;
            // 
            // loginPassLabel
            // 
            this.loginPassLabel.AutoSize = true;
            this.loginPassLabel.Font = new System.Drawing.Font("Arial", 16.25F);
            this.loginPassLabel.Location = new System.Drawing.Point(74, 130);
            this.loginPassLabel.Name = "loginPassLabel";
            this.loginPassLabel.Size = new System.Drawing.Size(70, 25);
            this.loginPassLabel.TabIndex = 9;
            this.loginPassLabel.Text = "Логин";
            // 
            // registrationPassTextBox
            // 
            this.registrationPassTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.registrationPassTextBox.Location = new System.Drawing.Point(79, 238);
            this.registrationPassTextBox.Name = "registrationPassTextBox";
            this.registrationPassTextBox.PasswordChar = '*';
            this.registrationPassTextBox.Size = new System.Drawing.Size(349, 29);
            this.registrationPassTextBox.TabIndex = 12;
            // 
            // loginPassTextBox
            // 
            this.loginPassTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.loginPassTextBox.Location = new System.Drawing.Point(79, 158);
            this.loginPassTextBox.Name = "loginPassTextBox";
            this.loginPassTextBox.Size = new System.Drawing.Size(349, 29);
            this.loginPassTextBox.TabIndex = 11;
            // 
            // registrationPassLabel
            // 
            this.registrationPassLabel.AutoSize = true;
            this.registrationPassLabel.Font = new System.Drawing.Font("Arial", 16.25F);
            this.registrationPassLabel.Location = new System.Drawing.Point(74, 210);
            this.registrationPassLabel.Name = "registrationPassLabel";
            this.registrationPassLabel.Size = new System.Drawing.Size(90, 25);
            this.registrationPassLabel.TabIndex = 10;
            this.registrationPassLabel.Text = "Пароль";
            // 
            // WorkersRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 429);
            this.Controls.Add(this.admRadioButton);
            this.Controls.Add(this.workerRadioButton);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.loginPassLabel);
            this.Controls.Add(this.registrationPassLabel);
            this.Controls.Add(this.registrationPassTextBox);
            this.Controls.Add(this.loginPassTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(509, 468);
            this.MinimumSize = new System.Drawing.Size(509, 468);
            this.Name = "WorkersRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация работника";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton admRadioButton;
        private System.Windows.Forms.RadioButton workerRadioButton;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Label loginPassLabel;
        private System.Windows.Forms.TextBox registrationPassTextBox;
        private System.Windows.Forms.TextBox loginPassTextBox;
        private System.Windows.Forms.Label registrationPassLabel;
    }
}