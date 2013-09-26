namespace SchoolManagement.GUI
{
    partial class LoginForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.uiLoginTextBox = new System.Windows.Forms.TextBox();
            this.uiLoginLabel = new System.Windows.Forms.Label();
            this.uiPasswordLabel = new System.Windows.Forms.Label();
            this.uiPasswordTextBox = new System.Windows.Forms.TextBox();
            this.uiLoginButton = new System.Windows.Forms.Button();
            this.uiOnlyReadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiLoginTextBox
            // 
            this.uiLoginTextBox.Location = new System.Drawing.Point(61, 12);
            this.uiLoginTextBox.Name = "uiLoginTextBox";
            this.uiLoginTextBox.Size = new System.Drawing.Size(122, 20);
            this.uiLoginTextBox.TabIndex = 0;
            // 
            // uiLoginLabel
            // 
            this.uiLoginLabel.AutoSize = true;
            this.uiLoginLabel.Location = new System.Drawing.Point(12, 15);
            this.uiLoginLabel.Name = "uiLoginLabel";
            this.uiLoginLabel.Size = new System.Drawing.Size(36, 13);
            this.uiLoginLabel.TabIndex = 1;
            this.uiLoginLabel.Text = "логин";
            // 
            // uiPasswordLabel
            // 
            this.uiPasswordLabel.AutoSize = true;
            this.uiPasswordLabel.Location = new System.Drawing.Point(12, 41);
            this.uiPasswordLabel.Name = "uiPasswordLabel";
            this.uiPasswordLabel.Size = new System.Drawing.Size(43, 13);
            this.uiPasswordLabel.TabIndex = 2;
            this.uiPasswordLabel.Text = "пароль";
            // 
            // uiPasswordTextBox
            // 
            this.uiPasswordTextBox.Location = new System.Drawing.Point(61, 38);
            this.uiPasswordTextBox.Name = "uiPasswordTextBox";
            this.uiPasswordTextBox.PasswordChar = '*';
            this.uiPasswordTextBox.Size = new System.Drawing.Size(121, 20);
            this.uiPasswordTextBox.TabIndex = 3;
            this.uiPasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uiPasswordTextBox_KeyDown);
            // 
            // uiLoginButton
            // 
            this.uiLoginButton.Location = new System.Drawing.Point(12, 64);
            this.uiLoginButton.Name = "uiLoginButton";
            this.uiLoginButton.Size = new System.Drawing.Size(36, 23);
            this.uiLoginButton.TabIndex = 4;
            this.uiLoginButton.Text = "ок";
            this.uiLoginButton.UseVisualStyleBackColor = true;
            this.uiLoginButton.Click += new System.EventHandler(this.uiLoginButton_Click);
            // 
            // uiOnlyReadButton
            // 
            this.uiOnlyReadButton.Location = new System.Drawing.Point(61, 64);
            this.uiOnlyReadButton.Name = "uiOnlyReadButton";
            this.uiOnlyReadButton.Size = new System.Drawing.Size(121, 23);
            this.uiOnlyReadButton.TabIndex = 5;
            this.uiOnlyReadButton.Text = "режим просмотра";
            this.uiOnlyReadButton.UseVisualStyleBackColor = true;
            this.uiOnlyReadButton.Click += new System.EventHandler(this.uiOnlyReadButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 96);
            this.Controls.Add(this.uiOnlyReadButton);
            this.Controls.Add(this.uiLoginButton);
            this.Controls.Add(this.uiPasswordTextBox);
            this.Controls.Add(this.uiPasswordLabel);
            this.Controls.Add(this.uiLoginLabel);
            this.Controls.Add(this.uiLoginTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(210, 130);
            this.MinimumSize = new System.Drawing.Size(210, 130);
            this.Name = "LoginForm";
            this.Tag = "606217";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiLoginTextBox;
        private System.Windows.Forms.Label uiLoginLabel;
        private System.Windows.Forms.Label uiPasswordLabel;
        private System.Windows.Forms.TextBox uiPasswordTextBox;
        private System.Windows.Forms.Button uiLoginButton;
        private System.Windows.Forms.Button uiOnlyReadButton;



    }
}

