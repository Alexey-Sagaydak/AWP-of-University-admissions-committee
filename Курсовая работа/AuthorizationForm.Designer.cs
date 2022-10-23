namespace Курсовая_работа
{
    partial class AuthorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.admissionCampaignLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.registrationLinkLabel = new System.Windows.Forms.LinkLabel();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.authorizationPanel = new System.Windows.Forms.Panel();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.registrationButton = new System.Windows.Forms.Button();
            this.codeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.loginPassLabel = new System.Windows.Forms.Label();
            this.registrationPassTextBox = new System.Windows.Forms.TextBox();
            this.loginPassTextBox = new System.Windows.Forms.TextBox();
            this.registrationPassLabel = new System.Windows.Forms.Label();
            this.registrationPanel = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.authorizationPanel.SuspendLayout();
            this.registrationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // admissionCampaignLabel
            // 
            this.admissionCampaignLabel.AutoSize = true;
            this.admissionCampaignLabel.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.admissionCampaignLabel.Location = new System.Drawing.Point(90, 36);
            this.admissionCampaignLabel.Name = "admissionCampaignLabel";
            this.admissionCampaignLabel.Size = new System.Drawing.Size(325, 42);
            this.admissionCampaignLabel.TabIndex = 0;
            this.admissionCampaignLabel.Text = "Приемная кампания";
            this.admissionCampaignLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // enterButton
            // 
            this.enterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.enterButton.Font = new System.Drawing.Font("Arial", 17.25F);
            this.enterButton.Location = new System.Drawing.Point(174, 325);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(136, 41);
            this.enterButton.TabIndex = 1;
            this.enterButton.Text = "Войти";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Arial", 16.25F);
            this.loginLabel.Location = new System.Drawing.Point(61, 114);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(70, 25);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Логин";
            this.loginLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial", 16.25F);
            this.passwordLabel.Location = new System.Drawing.Point(61, 223);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(90, 25);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Пароль";
            // 
            // registrationLinkLabel
            // 
            this.registrationLinkLabel.AutoSize = true;
            this.registrationLinkLabel.Font = new System.Drawing.Font("Arial", 10.25F);
            this.registrationLinkLabel.Location = new System.Drawing.Point(386, 416);
            this.registrationLinkLabel.Name = "registrationLinkLabel";
            this.registrationLinkLabel.Size = new System.Drawing.Size(91, 16);
            this.registrationLinkLabel.TabIndex = 4;
            this.registrationLinkLabel.TabStop = true;
            this.registrationLinkLabel.Text = "Регистрация";
            this.registrationLinkLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.registrationLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Arial", 16.25F);
            this.loginTextBox.Location = new System.Drawing.Point(66, 159);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(349, 32);
            this.loginTextBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(66, 266);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(349, 34);
            this.passwordTextBox.TabIndex = 6;
            // 
            // authorizationPanel
            // 
            this.authorizationPanel.Controls.Add(this.admissionCampaignLabel);
            this.authorizationPanel.Controls.Add(this.registrationLinkLabel);
            this.authorizationPanel.Controls.Add(this.passwordTextBox);
            this.authorizationPanel.Controls.Add(this.enterButton);
            this.authorizationPanel.Controls.Add(this.loginLabel);
            this.authorizationPanel.Controls.Add(this.loginTextBox);
            this.authorizationPanel.Controls.Add(this.passwordLabel);
            this.authorizationPanel.Location = new System.Drawing.Point(12, 10);
            this.authorizationPanel.Name = "authorizationPanel";
            this.authorizationPanel.Size = new System.Drawing.Size(477, 432);
            this.authorizationPanel.TabIndex = 7;
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationLabel.Location = new System.Drawing.Point(60, 24);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(381, 84);
            this.registrationLabel.TabIndex = 7;
            this.registrationLabel.Text = "Регистрация сотрудника\r\nприемной комиссии";
            this.registrationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.registrationLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // registrationButton
            // 
            this.registrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.registrationButton.Font = new System.Drawing.Font("Arial", 15.25F);
            this.registrationButton.Location = new System.Drawing.Point(138, 362);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(212, 41);
            this.registrationButton.TabIndex = 8;
            this.registrationButton.Text = "Зарегистрироваться";
            this.registrationButton.UseVisualStyleBackColor = true;
            // 
            // codeMaskedTextBox
            // 
            this.codeMaskedTextBox.Font = new System.Drawing.Font("Arial", 16.25F);
            this.codeMaskedTextBox.Location = new System.Drawing.Point(67, 307);
            this.codeMaskedTextBox.Mask = "0000-0000-0000-0000-0000-0000";
            this.codeMaskedTextBox.Name = "codeMaskedTextBox";
            this.codeMaskedTextBox.Size = new System.Drawing.Size(349, 32);
            this.codeMaskedTextBox.TabIndex = 15;
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Font = new System.Drawing.Font("Arial", 16.25F);
            this.codeLabel.Location = new System.Drawing.Point(68, 276);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(139, 25);
            this.codeLabel.TabIndex = 14;
            this.codeLabel.Text = "Код доступа";
            // 
            // loginPassLabel
            // 
            this.loginPassLabel.AutoSize = true;
            this.loginPassLabel.Font = new System.Drawing.Font("Arial", 16.25F);
            this.loginPassLabel.Location = new System.Drawing.Point(62, 134);
            this.loginPassLabel.Name = "loginPassLabel";
            this.loginPassLabel.Size = new System.Drawing.Size(70, 25);
            this.loginPassLabel.TabIndex = 9;
            this.loginPassLabel.Text = "Логин";
            // 
            // registrationPassTextBox
            // 
            this.registrationPassTextBox.Font = new System.Drawing.Font("Arial", 16.25F);
            this.registrationPassTextBox.Location = new System.Drawing.Point(67, 233);
            this.registrationPassTextBox.Name = "registrationPassTextBox";
            this.registrationPassTextBox.PasswordChar = '*';
            this.registrationPassTextBox.Size = new System.Drawing.Size(349, 32);
            this.registrationPassTextBox.TabIndex = 12;
            this.registrationPassTextBox.TextChanged += new System.EventHandler(this.registrationPassTextBox_TextChanged);
            // 
            // loginPassTextBox
            // 
            this.loginPassTextBox.Font = new System.Drawing.Font("Arial", 16.25F);
            this.loginPassTextBox.Location = new System.Drawing.Point(67, 162);
            this.loginPassTextBox.Name = "loginPassTextBox";
            this.loginPassTextBox.Size = new System.Drawing.Size(349, 32);
            this.loginPassTextBox.TabIndex = 11;
            // 
            // registrationPassLabel
            // 
            this.registrationPassLabel.AutoSize = true;
            this.registrationPassLabel.Font = new System.Drawing.Font("Arial", 16.25F);
            this.registrationPassLabel.Location = new System.Drawing.Point(62, 205);
            this.registrationPassLabel.Name = "registrationPassLabel";
            this.registrationPassLabel.Size = new System.Drawing.Size(90, 25);
            this.registrationPassLabel.TabIndex = 10;
            this.registrationPassLabel.Text = "Пароль";
            // 
            // registrationPanel
            // 
            this.registrationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registrationPanel.Controls.Add(this.linkLabel1);
            this.registrationPanel.Controls.Add(this.registrationLabel);
            this.registrationPanel.Controls.Add(this.registrationButton);
            this.registrationPanel.Controls.Add(this.codeMaskedTextBox);
            this.registrationPanel.Controls.Add(this.codeLabel);
            this.registrationPanel.Controls.Add(this.loginPassLabel);
            this.registrationPanel.Controls.Add(this.registrationPassTextBox);
            this.registrationPanel.Controls.Add(this.loginPassTextBox);
            this.registrationPanel.Controls.Add(this.registrationPassLabel);
            this.registrationPanel.Location = new System.Drawing.Point(11, 7);
            this.registrationPanel.Name = "registrationPanel";
            this.registrationPanel.Size = new System.Drawing.Size(479, 435);
            this.registrationPanel.TabIndex = 16;
            this.registrationPanel.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 10.25F);
            this.linkLabel1.Location = new System.Drawing.Point(1, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(46, 16);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Назад";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 454);
            this.Controls.Add(this.authorizationPanel);
            this.Controls.Add(this.registrationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            this.authorizationPanel.ResumeLayout(false);
            this.authorizationPanel.PerformLayout();
            this.registrationPanel.ResumeLayout(false);
            this.registrationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label admissionCampaignLabel;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.LinkLabel registrationLinkLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Panel authorizationPanel;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.MaskedTextBox codeMaskedTextBox;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label loginPassLabel;
        private System.Windows.Forms.TextBox registrationPassTextBox;
        private System.Windows.Forms.TextBox loginPassTextBox;
        private System.Windows.Forms.Label registrationPassLabel;
        private System.Windows.Forms.Panel registrationPanel;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

