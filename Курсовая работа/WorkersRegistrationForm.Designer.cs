namespace Курсовая_работа
{
    partial class WorkersRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkersRegistrationForm));
            this.admRadioButton = new System.Windows.Forms.RadioButton();
            this.workerRadioButton = new System.Windows.Forms.RadioButton();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.registrationButton = new System.Windows.Forms.Button();
            this.loginPassLabel = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.registrationPassLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfBurthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // admRadioButton
            // 
            this.admRadioButton.AutoSize = true;
            this.admRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.admRadioButton.Location = new System.Drawing.Point(69, 451);
            this.admRadioButton.Name = "admRadioButton";
            this.admRadioButton.Size = new System.Drawing.Size(172, 28);
            this.admRadioButton.TabIndex = 24;
            this.admRadioButton.Text = "Администратор";
            this.admRadioButton.UseVisualStyleBackColor = true;
            // 
            // workerRadioButton
            // 
            this.workerRadioButton.AutoSize = true;
            this.workerRadioButton.Checked = true;
            this.workerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.workerRadioButton.Location = new System.Drawing.Point(69, 427);
            this.workerRadioButton.Name = "workerRadioButton";
            this.workerRadioButton.Size = new System.Drawing.Size(113, 28);
            this.workerRadioButton.TabIndex = 23;
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
            // 
            // registrationButton
            // 
            this.registrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.registrationButton.Font = new System.Drawing.Font("Arial", 15.25F);
            this.registrationButton.Location = new System.Drawing.Point(141, 499);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(212, 41);
            this.registrationButton.TabIndex = 26;
            this.registrationButton.Text = "Зарегистрировать";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // loginPassLabel
            // 
            this.loginPassLabel.AutoSize = true;
            this.loginPassLabel.Font = new System.Drawing.Font("Arial", 15.25F);
            this.loginPassLabel.Location = new System.Drawing.Point(64, 304);
            this.loginPassLabel.Name = "loginPassLabel";
            this.loginPassLabel.Size = new System.Drawing.Size(66, 24);
            this.loginPassLabel.TabIndex = 9;
            this.loginPassLabel.Text = "Логин";
            // 
            // passTextBox
            // 
            this.passTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.passTextBox.Location = new System.Drawing.Point(69, 392);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(349, 29);
            this.passTextBox.TabIndex = 22;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.loginTextBox.Location = new System.Drawing.Point(69, 332);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(349, 29);
            this.loginTextBox.TabIndex = 21;
            // 
            // registrationPassLabel
            // 
            this.registrationPassLabel.AutoSize = true;
            this.registrationPassLabel.Font = new System.Drawing.Font("Arial", 15.25F);
            this.registrationPassLabel.Location = new System.Drawing.Point(64, 364);
            this.registrationPassLabel.Name = "registrationPassLabel";
            this.registrationPassLabel.Size = new System.Drawing.Size(81, 24);
            this.registrationPassLabel.TabIndex = 10;
            this.registrationPassLabel.Text = "Пароль";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 15.25F);
            this.nameLabel.Location = new System.Drawing.Point(64, 185);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 24);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "Имя";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Arial", 15.25F);
            this.surnameLabel.Location = new System.Drawing.Point(64, 125);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(95, 24);
            this.surnameLabel.TabIndex = 17;
            this.surnameLabel.Text = "Фамилия";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.surnameTextBox.Location = new System.Drawing.Point(69, 153);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(349, 29);
            this.surnameTextBox.TabIndex = 18;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.nameTextBox.Location = new System.Drawing.Point(69, 213);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(349, 29);
            this.nameTextBox.TabIndex = 19;
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Font = new System.Drawing.Font("Arial", 15.25F);
            this.middleNameLabel.Location = new System.Drawing.Point(64, 244);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(103, 24);
            this.middleNameLabel.TabIndex = 20;
            this.middleNameLabel.Text = "Отчество";
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.middleNameTextBox.Location = new System.Drawing.Point(69, 272);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(349, 29);
            this.middleNameTextBox.TabIndex = 20;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(278, 455);
            this.dateTimePicker.MinDate = new System.DateTime(1899, 11, 29, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(130, 29);
            this.dateTimePicker.TabIndex = 25;
            this.dateTimePicker.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // dateOfBurthLabel
            // 
            this.dateOfBurthLabel.AutoSize = true;
            this.dateOfBurthLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.dateOfBurthLabel.Location = new System.Drawing.Point(274, 430);
            this.dateOfBurthLabel.Name = "dateOfBurthLabel";
            this.dateOfBurthLabel.Size = new System.Drawing.Size(144, 22);
            this.dateOfBurthLabel.TabIndex = 23;
            this.dateOfBurthLabel.Text = "Дата рождения";
            // 
            // WorkersRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 558);
            this.Controls.Add(this.dateOfBurthLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.admRadioButton);
            this.Controls.Add(this.workerRadioButton);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.loginPassLabel);
            this.Controls.Add(this.registrationPassLabel);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.loginTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(509, 597);
            this.MinimumSize = new System.Drawing.Size(509, 468);
            this.Name = "WorkersRegistrationForm";
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
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label registrationPassLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label dateOfBurthLabel;
    }
}