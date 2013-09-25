namespace SchoolManagement
{
    partial class ClassRoomAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassRoomAddForm));
            this.uiNameTextBox = new System.Windows.Forms.TextBox();
            this.uiNumberTextBox = new System.Windows.Forms.TextBox();
            this.uiNameLabel = new System.Windows.Forms.Label();
            this.uiNumberLabel = new System.Windows.Forms.Label();
            this.uiCommitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiNameTextBox
            // 
            this.uiNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiNameTextBox.Location = new System.Drawing.Point(72, 6);
            this.uiNameTextBox.Name = "uiNameTextBox";
            this.uiNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.uiNameTextBox.TabIndex = 0;
            // 
            // uiNumberTextBox
            // 
            this.uiNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiNumberTextBox.Location = new System.Drawing.Point(72, 32);
            this.uiNumberTextBox.Name = "uiNumberTextBox";
            this.uiNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.uiNumberTextBox.TabIndex = 1;
            this.uiNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uiNumberTextBox_KeyDown);
            // 
            // uiNameLabel
            // 
            this.uiNameLabel.AutoSize = true;
            this.uiNameLabel.Location = new System.Drawing.Point(9, 9);
            this.uiNameLabel.Name = "uiNameLabel";
            this.uiNameLabel.Size = new System.Drawing.Size(57, 13);
            this.uiNameLabel.TabIndex = 3;
            this.uiNameLabel.Text = "Название";
            // 
            // uiNumberLabel
            // 
            this.uiNumberLabel.AutoSize = true;
            this.uiNumberLabel.Location = new System.Drawing.Point(9, 35);
            this.uiNumberLabel.Name = "uiNumberLabel";
            this.uiNumberLabel.Size = new System.Drawing.Size(41, 13);
            this.uiNumberLabel.TabIndex = 4;
            this.uiNumberLabel.Text = "Номер";
            // 
            // uiCommitButton
            // 
            this.uiCommitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiCommitButton.Location = new System.Drawing.Point(12, 58);
            this.uiCommitButton.Name = "uiCommitButton";
            this.uiCommitButton.Size = new System.Drawing.Size(260, 23);
            this.uiCommitButton.TabIndex = 8;
            this.uiCommitButton.Text = "Добавить";
            this.uiCommitButton.UseVisualStyleBackColor = true;
            this.uiCommitButton.Click += new System.EventHandler(this.uiCommintButton_Click);
            // 
            // ClassRoomAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 87);
            this.Controls.Add(this.uiCommitButton);
            this.Controls.Add(this.uiNumberLabel);
            this.Controls.Add(this.uiNameLabel);
            this.Controls.Add(this.uiNumberTextBox);
            this.Controls.Add(this.uiNameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1024, 125);
            this.MinimumSize = new System.Drawing.Size(300, 125);
            this.Name = "ClassRoomAddForm";
            this.Text = "Новый кабинет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiNameTextBox;
        private System.Windows.Forms.TextBox uiNumberTextBox;
        private System.Windows.Forms.Label uiNameLabel;
        private System.Windows.Forms.Label uiNumberLabel;
        private System.Windows.Forms.Button uiCommitButton;

    }
}