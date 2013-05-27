namespace SchoolManagement.GUI
{
    partial class TeacherAddForm
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
            this.uiBirthDayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uiBirthDayLabel = new System.Windows.Forms.Label();
            this.uiCommintButton = new System.Windows.Forms.Button();
            this.uiStartWorkDateLabel = new System.Windows.Forms.Label();
            this.uiStartWorkDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // uiNameTextBox
            // 
            this.uiNameTextBox.Location = new System.Drawing.Point(52, 6);
            this.uiNameTextBox.Name = "uiNameTextBox";
            this.uiNameTextBox.Size = new System.Drawing.Size(220, 20);
            this.uiNameTextBox.TabIndex = 0;
            // 
            // uiNameLabel
            // 
            this.uiNameLabel.AutoSize = true;
            this.uiNameLabel.Location = new System.Drawing.Point(12, 9);
            this.uiNameLabel.Name = "uiNameLabel";
            this.uiNameLabel.Size = new System.Drawing.Size(34, 13);
            this.uiNameLabel.TabIndex = 3;
            this.uiNameLabel.Text = "ФИО";
            // 
            // uiBirthDayDateTimePicker
            // 
            this.uiBirthDayDateTimePicker.Location = new System.Drawing.Point(127, 32);
            this.uiBirthDayDateTimePicker.Name = "uiBirthDayDateTimePicker";
            this.uiBirthDayDateTimePicker.Size = new System.Drawing.Size(145, 20);
            this.uiBirthDayDateTimePicker.TabIndex = 5;
            // 
            // uiBirthDayLabel
            // 
            this.uiBirthDayLabel.AutoSize = true;
            this.uiBirthDayLabel.Location = new System.Drawing.Point(12, 35);
            this.uiBirthDayLabel.Name = "uiBirthDayLabel";
            this.uiBirthDayLabel.Size = new System.Drawing.Size(86, 13);
            this.uiBirthDayLabel.TabIndex = 6;
            this.uiBirthDayLabel.Text = "Дата рождения";
            // 
            // uiCommintButton
            // 
            this.uiCommintButton.Location = new System.Drawing.Point(12, 77);
            this.uiCommintButton.Name = "uiCommintButton";
            this.uiCommintButton.Size = new System.Drawing.Size(87, 23);
            this.uiCommintButton.TabIndex = 8;
            this.uiCommintButton.Text = "OK";
            this.uiCommintButton.UseVisualStyleBackColor = true;
            this.uiCommintButton.Click += new System.EventHandler(this.uiCommintButton_Click);
            // 
            // uiStartWorkDateLabel
            // 
            this.uiStartWorkDateLabel.AutoSize = true;
            this.uiStartWorkDateLabel.Location = new System.Drawing.Point(12, 61);
            this.uiStartWorkDateLabel.Name = "uiStartWorkDateLabel";
            this.uiStartWorkDateLabel.Size = new System.Drawing.Size(86, 13);
            this.uiStartWorkDateLabel.TabIndex = 10;
            this.uiStartWorkDateLabel.Text = "Дата рождения";
            // 
            // uiStartWorkDateDateTimePicker
            // 
            this.uiStartWorkDateDateTimePicker.Location = new System.Drawing.Point(127, 58);
            this.uiStartWorkDateDateTimePicker.Name = "uiStartWorkDateDateTimePicker";
            this.uiStartWorkDateDateTimePicker.Size = new System.Drawing.Size(145, 20);
            this.uiStartWorkDateDateTimePicker.TabIndex = 9;
            // 
            // TeacherAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.uiStartWorkDateLabel);
            this.Controls.Add(this.uiStartWorkDateDateTimePicker);
            this.Controls.Add(this.uiCommintButton);
            this.Controls.Add(this.uiBirthDayLabel);
            this.Controls.Add(this.uiBirthDayDateTimePicker);
            this.Controls.Add(this.uiNameLabel);
            this.Controls.Add(this.uiNameTextBox);
            this.Name = "TeacherAddForm";
            this.Text = "добавление ученика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiNameTextBox;
        private System.Windows.Forms.Label uiNameLabel;
        private System.Windows.Forms.DateTimePicker uiBirthDayDateTimePicker;
        private System.Windows.Forms.Label uiBirthDayLabel;
        private System.Windows.Forms.Button uiCommintButton;
        private System.Windows.Forms.Label uiStartWorkDateLabel;
        private System.Windows.Forms.DateTimePicker uiStartWorkDateDateTimePicker;

    }
}