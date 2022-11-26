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
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.authorizationPanel = new System.Windows.Forms.Panel();
            this.authorizationPanel.SuspendLayout();
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
            // 
            // enterButton
            // 
            this.enterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.enterButton.Font = new System.Drawing.Font("Arial", 17.25F);
            this.enterButton.Location = new System.Drawing.Point(170, 333);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(136, 41);
            this.enterButton.TabIndex = 7;
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
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Arial", 16.25F);
            this.loginTextBox.Location = new System.Drawing.Point(66, 159);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(349, 32);
            this.loginTextBox.TabIndex = 1;
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
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 454);
            this.Controls.Add(this.authorizationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.authorizationPanel.ResumeLayout(false);
            this.authorizationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label admissionCampaignLabel;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Panel authorizationPanel;
    }
}

