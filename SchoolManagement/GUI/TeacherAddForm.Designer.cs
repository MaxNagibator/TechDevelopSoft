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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherAddForm));
            this.uiNameTextBox = new System.Windows.Forms.TextBox();
            this.uiNameLabel = new System.Windows.Forms.Label();
            this.uiBirthDayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uiBirthDayLabel = new System.Windows.Forms.Label();
            this.uiStartWorkDateLabel = new System.Windows.Forms.Label();
            this.uiStartWorkDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uiCommitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiNameTextBox
            // 
            this.uiNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiNameTextBox.Location = new System.Drawing.Point(52, 6);
            this.uiNameTextBox.Name = "uiNameTextBox";
            this.uiNameTextBox.Size = new System.Drawing.Size(220, 20);
            this.uiNameTextBox.TabIndex = 0;
            this.uiNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uiNameTextBox_KeyDown);
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
            this.uiBirthDayDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiBirthDayDateTimePicker.Location = new System.Drawing.Point(127, 32);
            this.uiBirthDayDateTimePicker.Name = "uiBirthDayDateTimePicker";
            this.uiBirthDayDateTimePicker.Size = new System.Drawing.Size(145, 20);
            this.uiBirthDayDateTimePicker.TabIndex = 1;
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
            this.uiStartWorkDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiStartWorkDateDateTimePicker.Location = new System.Drawing.Point(127, 58);
            this.uiStartWorkDateDateTimePicker.Name = "uiStartWorkDateDateTimePicker";
            this.uiStartWorkDateDateTimePicker.Size = new System.Drawing.Size(145, 20);
            this.uiStartWorkDateDateTimePicker.TabIndex = 2;
            // 
            // uiCommitButton
            // 
            this.uiCommitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiCommitButton.Location = new System.Drawing.Point(12, 84);
            this.uiCommitButton.Name = "uiCommitButton";
            this.uiCommitButton.Size = new System.Drawing.Size(260, 23);
            this.uiCommitButton.TabIndex = 11;
            this.uiCommitButton.Text = "Добавить";
            this.uiCommitButton.UseVisualStyleBackColor = true;
            this.uiCommitButton.Click += new System.EventHandler(this.uiCommitButton_Click);
            // 
            // TeacherAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 112);
            this.Controls.Add(this.uiCommitButton);
            this.Controls.Add(this.uiStartWorkDateLabel);
            this.Controls.Add(this.uiStartWorkDateDateTimePicker);
            this.Controls.Add(this.uiBirthDayLabel);
            this.Controls.Add(this.uiBirthDayDateTimePicker);
            this.Controls.Add(this.uiNameLabel);
            this.Controls.Add(this.uiNameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1024, 150);
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "TeacherAddForm";
            this.Text = "добавление учителя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiNameTextBox;
        private System.Windows.Forms.Label uiNameLabel;
        private System.Windows.Forms.DateTimePicker uiBirthDayDateTimePicker;
        private System.Windows.Forms.Label uiBirthDayLabel;
        private System.Windows.Forms.Label uiStartWorkDateLabel;
        private System.Windows.Forms.DateTimePicker uiStartWorkDateDateTimePicker;
        private System.Windows.Forms.Button uiCommitButton;

    }
}