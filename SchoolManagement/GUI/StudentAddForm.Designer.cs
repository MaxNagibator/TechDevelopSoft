namespace SchoolManagement
{
    partial class StudentAddForm
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
            this.uiCommentTextBox = new System.Windows.Forms.TextBox();
            this.uiGroupTextBox = new System.Windows.Forms.TextBox();
            this.uiNameLabel = new System.Windows.Forms.Label();
            this.uiCommentLabel = new System.Windows.Forms.Label();
            this.uiBirthDayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uiBirthDayLabel = new System.Windows.Forms.Label();
            this.uiGroupLabel = new System.Windows.Forms.Label();
            this.uiCommintButton = new System.Windows.Forms.Button();
            this.uiSelectGroupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiNameTextBox
            // 
            this.uiNameTextBox.Location = new System.Drawing.Point(52, 6);
            this.uiNameTextBox.Name = "uiNameTextBox";
            this.uiNameTextBox.Size = new System.Drawing.Size(220, 20);
            this.uiNameTextBox.TabIndex = 0;
            // 
            // uiCommentTextBox
            // 
            this.uiCommentTextBox.Location = new System.Drawing.Point(95, 84);
            this.uiCommentTextBox.Name = "uiCommentTextBox";
            this.uiCommentTextBox.Size = new System.Drawing.Size(177, 20);
            this.uiCommentTextBox.TabIndex = 1;
            // 
            // uiGroupTextBox
            // 
            this.uiGroupTextBox.Location = new System.Drawing.Point(67, 58);
            this.uiGroupTextBox.Name = "uiGroupTextBox";
            this.uiGroupTextBox.Size = new System.Drawing.Size(130, 20);
            this.uiGroupTextBox.TabIndex = 2;
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
            // uiCommentLabel
            // 
            this.uiCommentLabel.AutoSize = true;
            this.uiCommentLabel.Location = new System.Drawing.Point(12, 87);
            this.uiCommentLabel.Name = "uiCommentLabel";
            this.uiCommentLabel.Size = new System.Drawing.Size(77, 13);
            this.uiCommentLabel.TabIndex = 4;
            this.uiCommentLabel.Text = "Комментарий";
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
            // uiGroupLabel
            // 
            this.uiGroupLabel.AutoSize = true;
            this.uiGroupLabel.Location = new System.Drawing.Point(10, 61);
            this.uiGroupLabel.Name = "uiGroupLabel";
            this.uiGroupLabel.Size = new System.Drawing.Size(42, 13);
            this.uiGroupLabel.TabIndex = 7;
            this.uiGroupLabel.Text = "Группа";
            // 
            // uiCommintButton
            // 
            this.uiCommintButton.Location = new System.Drawing.Point(12, 110);
            this.uiCommintButton.Name = "uiCommintButton";
            this.uiCommintButton.Size = new System.Drawing.Size(87, 23);
            this.uiCommintButton.TabIndex = 8;
            this.uiCommintButton.Text = "OK";
            this.uiCommintButton.UseVisualStyleBackColor = true;
            this.uiCommintButton.Click += new System.EventHandler(this.uiCommintButton_Click);
            // 
            // uiSelectGroupButton
            // 
            this.uiSelectGroupButton.Location = new System.Drawing.Point(203, 56);
            this.uiSelectGroupButton.Name = "uiSelectGroupButton";
            this.uiSelectGroupButton.Size = new System.Drawing.Size(69, 23);
            this.uiSelectGroupButton.TabIndex = 9;
            this.uiSelectGroupButton.Text = "выбор";
            this.uiSelectGroupButton.UseVisualStyleBackColor = true;
            this.uiSelectGroupButton.Click += new System.EventHandler(this.uiSelectGroupButton_Click);
            // 
            // StudentAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.uiSelectGroupButton);
            this.Controls.Add(this.uiCommintButton);
            this.Controls.Add(this.uiGroupLabel);
            this.Controls.Add(this.uiBirthDayLabel);
            this.Controls.Add(this.uiBirthDayDateTimePicker);
            this.Controls.Add(this.uiCommentLabel);
            this.Controls.Add(this.uiNameLabel);
            this.Controls.Add(this.uiGroupTextBox);
            this.Controls.Add(this.uiCommentTextBox);
            this.Controls.Add(this.uiNameTextBox);
            this.Name = "StudentAddForm";
            this.Text = "добавление ученика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiNameTextBox;
        private System.Windows.Forms.TextBox uiCommentTextBox;
        private System.Windows.Forms.TextBox uiGroupTextBox;
        private System.Windows.Forms.Label uiNameLabel;
        private System.Windows.Forms.Label uiCommentLabel;
        private System.Windows.Forms.DateTimePicker uiBirthDayDateTimePicker;
        private System.Windows.Forms.Label uiBirthDayLabel;
        private System.Windows.Forms.Label uiGroupLabel;
        private System.Windows.Forms.Button uiCommintButton;
        private System.Windows.Forms.Button uiSelectGroupButton;

    }
}