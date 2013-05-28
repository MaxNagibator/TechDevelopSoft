namespace SchoolManagement.GUI
{
    partial class ClassTimeTableAddForm
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
            this.uiNameTextBox = new System.Windows.Forms.TextBox();
            this.uiNameLabel = new System.Windows.Forms.Label();
            this.uiCommitButton = new System.Windows.Forms.Button();
            this.uiStartTimeLabel = new System.Windows.Forms.Label();
            this.uiStartTimeTextBox = new System.Windows.Forms.TextBox();
            this.uiEndTimeLabel = new System.Windows.Forms.Label();
            this.uiEndTimeTextBox = new System.Windows.Forms.TextBox();
            this.uiNumberLabel = new System.Windows.Forms.Label();
            this.uiNumberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uiNameTextBox
            // 
            this.uiNameTextBox.Location = new System.Drawing.Point(95, 6);
            this.uiNameTextBox.Name = "uiNameTextBox";
            this.uiNameTextBox.Size = new System.Drawing.Size(177, 20);
            this.uiNameTextBox.TabIndex = 0;
            // 
            // uiNameLabel
            // 
            this.uiNameLabel.AutoSize = true;
            this.uiNameLabel.Location = new System.Drawing.Point(12, 9);
            this.uiNameLabel.Name = "uiNameLabel";
            this.uiNameLabel.Size = new System.Drawing.Size(57, 13);
            this.uiNameLabel.TabIndex = 3;
            this.uiNameLabel.Text = "Название";
            // 
            // uiCommitButton
            // 
            this.uiCommitButton.Location = new System.Drawing.Point(95, 110);
            this.uiCommitButton.Name = "uiCommitButton";
            this.uiCommitButton.Size = new System.Drawing.Size(87, 23);
            this.uiCommitButton.TabIndex = 8;
            this.uiCommitButton.Text = "OK";
            this.uiCommitButton.UseVisualStyleBackColor = true;
            this.uiCommitButton.Click += new System.EventHandler(this.uiCommintButton_Click);
            // 
            // uiStartTimeLabel
            // 
            this.uiStartTimeLabel.AutoSize = true;
            this.uiStartTimeLabel.Location = new System.Drawing.Point(12, 61);
            this.uiStartTimeLabel.Name = "uiStartTimeLabel";
            this.uiStartTimeLabel.Size = new System.Drawing.Size(78, 13);
            this.uiStartTimeLabel.TabIndex = 10;
            this.uiStartTimeLabel.Text = "Время начала";
            // 
            // uiStartTimeTextBox
            // 
            this.uiStartTimeTextBox.Location = new System.Drawing.Point(95, 58);
            this.uiStartTimeTextBox.Name = "uiStartTimeTextBox";
            this.uiStartTimeTextBox.Size = new System.Drawing.Size(177, 20);
            this.uiStartTimeTextBox.TabIndex = 9;
            // 
            // uiEndTimeLabel
            // 
            this.uiEndTimeLabel.AutoSize = true;
            this.uiEndTimeLabel.Location = new System.Drawing.Point(12, 87);
            this.uiEndTimeLabel.Name = "uiEndTimeLabel";
            this.uiEndTimeLabel.Size = new System.Drawing.Size(62, 13);
            this.uiEndTimeLabel.TabIndex = 12;
            this.uiEndTimeLabel.Text = "Окончание";
            // 
            // uiEndTimeTextBox
            // 
            this.uiEndTimeTextBox.Location = new System.Drawing.Point(95, 84);
            this.uiEndTimeTextBox.Name = "uiEndTimeTextBox";
            this.uiEndTimeTextBox.Size = new System.Drawing.Size(177, 20);
            this.uiEndTimeTextBox.TabIndex = 11;
            // 
            // uiNumberLabel
            // 
            this.uiNumberLabel.AutoSize = true;
            this.uiNumberLabel.Location = new System.Drawing.Point(12, 35);
            this.uiNumberLabel.Name = "uiNumberLabel";
            this.uiNumberLabel.Size = new System.Drawing.Size(41, 13);
            this.uiNumberLabel.TabIndex = 14;
            this.uiNumberLabel.Text = "Номер";
            // 
            // uiNumberTextBox
            // 
            this.uiNumberTextBox.Location = new System.Drawing.Point(95, 32);
            this.uiNumberTextBox.Name = "uiNumberTextBox";
            this.uiNumberTextBox.Size = new System.Drawing.Size(177, 20);
            this.uiNumberTextBox.TabIndex = 13;
            // 
            // ClassTimeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 140);
            this.Controls.Add(this.uiNumberLabel);
            this.Controls.Add(this.uiNumberTextBox);
            this.Controls.Add(this.uiEndTimeLabel);
            this.Controls.Add(this.uiEndTimeTextBox);
            this.Controls.Add(this.uiStartTimeLabel);
            this.Controls.Add(this.uiStartTimeTextBox);
            this.Controls.Add(this.uiCommitButton);
            this.Controls.Add(this.uiNameLabel);
            this.Controls.Add(this.uiNameTextBox);
            this.Name = "ClassTimeAddForm";
            this.Text = "добавление времени урока";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiNameTextBox;
        private System.Windows.Forms.Label uiNameLabel;
        private System.Windows.Forms.Button uiCommitButton;
        private System.Windows.Forms.Label uiStartTimeLabel;
        private System.Windows.Forms.TextBox uiStartTimeTextBox;
        private System.Windows.Forms.Label uiEndTimeLabel;
        private System.Windows.Forms.TextBox uiEndTimeTextBox;
        private System.Windows.Forms.Label uiNumberLabel;
        private System.Windows.Forms.TextBox uiNumberTextBox;

    }
}