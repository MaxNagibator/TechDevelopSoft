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
            this.uiEducationalDisciplineLabel = new System.Windows.Forms.Label();
            this.uiEducationalDisciplineTextBox = new System.Windows.Forms.TextBox();
            this.uiDateLabel = new System.Windows.Forms.Label();
            this.uiClassTimeLabel = new System.Windows.Forms.Label();
            this.uiClassTimeTextBox = new System.Windows.Forms.TextBox();
            this.uiSelectClassTimeButton = new System.Windows.Forms.Button();
            this.uiEducationalDisciplineButton = new System.Windows.Forms.Button();
            this.uiDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uiTeacherTextBox = new System.Windows.Forms.TextBox();
            this.uiTeacherLabel = new System.Windows.Forms.Label();
            this.uiSelectTeacherButton = new System.Windows.Forms.Button();
            this.uiClassRoomTextBox = new System.Windows.Forms.TextBox();
            this.uiClassRoomLabel = new System.Windows.Forms.Label();
            this.uiSelectClassRoomButton = new System.Windows.Forms.Button();
            this.uiGroupTextBox = new System.Windows.Forms.TextBox();
            this.uiGroupLabel = new System.Windows.Forms.Label();
            this.uiSelectGroupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiNameTextBox
            // 
            this.uiNameTextBox.Location = new System.Drawing.Point(86, 6);
            this.uiNameTextBox.Name = "uiNameTextBox";
            this.uiNameTextBox.Size = new System.Drawing.Size(186, 20);
            this.uiNameTextBox.TabIndex = 0;
            this.uiNameTextBox.Text = "Обычный урок";
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
            this.uiCommitButton.Location = new System.Drawing.Point(86, 188);
            this.uiCommitButton.Name = "uiCommitButton";
            this.uiCommitButton.Size = new System.Drawing.Size(87, 23);
            this.uiCommitButton.TabIndex = 8;
            this.uiCommitButton.Text = "OK";
            this.uiCommitButton.UseVisualStyleBackColor = true;
            this.uiCommitButton.Click += new System.EventHandler(this.uiCommintButton_Click);
            // 
            // uiEducationalDisciplineLabel
            // 
            this.uiEducationalDisciplineLabel.AutoSize = true;
            this.uiEducationalDisciplineLabel.Location = new System.Drawing.Point(12, 61);
            this.uiEducationalDisciplineLabel.Name = "uiEducationalDisciplineLabel";
            this.uiEducationalDisciplineLabel.Size = new System.Drawing.Size(70, 13);
            this.uiEducationalDisciplineLabel.TabIndex = 10;
            this.uiEducationalDisciplineLabel.Text = "Дисциплина";
            // 
            // uiEducationalDisciplineTextBox
            // 
            this.uiEducationalDisciplineTextBox.Location = new System.Drawing.Point(86, 58);
            this.uiEducationalDisciplineTextBox.Name = "uiEducationalDisciplineTextBox";
            this.uiEducationalDisciplineTextBox.Size = new System.Drawing.Size(135, 20);
            this.uiEducationalDisciplineTextBox.TabIndex = 9;
            // 
            // uiDateLabel
            // 
            this.uiDateLabel.AutoSize = true;
            this.uiDateLabel.Location = new System.Drawing.Point(12, 87);
            this.uiDateLabel.Name = "uiDateLabel";
            this.uiDateLabel.Size = new System.Drawing.Size(33, 13);
            this.uiDateLabel.TabIndex = 12;
            this.uiDateLabel.Text = "Дата";
            // 
            // uiClassTimeLabel
            // 
            this.uiClassTimeLabel.AutoSize = true;
            this.uiClassTimeLabel.Location = new System.Drawing.Point(12, 35);
            this.uiClassTimeLabel.Name = "uiClassTimeLabel";
            this.uiClassTimeLabel.Size = new System.Drawing.Size(72, 13);
            this.uiClassTimeLabel.TabIndex = 14;
            this.uiClassTimeLabel.Text = "Время урока";
            // 
            // uiClassTimeTextBox
            // 
            this.uiClassTimeTextBox.Location = new System.Drawing.Point(86, 32);
            this.uiClassTimeTextBox.Name = "uiClassTimeTextBox";
            this.uiClassTimeTextBox.Size = new System.Drawing.Size(135, 20);
            this.uiClassTimeTextBox.TabIndex = 13;
            // 
            // uiSelectClassTimeButton
            // 
            this.uiSelectClassTimeButton.Location = new System.Drawing.Point(227, 30);
            this.uiSelectClassTimeButton.Name = "uiSelectClassTimeButton";
            this.uiSelectClassTimeButton.Size = new System.Drawing.Size(45, 23);
            this.uiSelectClassTimeButton.TabIndex = 15;
            this.uiSelectClassTimeButton.Text = "♥";
            this.uiSelectClassTimeButton.UseVisualStyleBackColor = true;
            this.uiSelectClassTimeButton.Click += new System.EventHandler(this.uiSelectClassTimeButton_Click);
            // 
            // uiEducationalDisciplineButton
            // 
            this.uiEducationalDisciplineButton.Location = new System.Drawing.Point(227, 56);
            this.uiEducationalDisciplineButton.Name = "uiEducationalDisciplineButton";
            this.uiEducationalDisciplineButton.Size = new System.Drawing.Size(45, 23);
            this.uiEducationalDisciplineButton.TabIndex = 16;
            this.uiEducationalDisciplineButton.Text = "♥";
            this.uiEducationalDisciplineButton.UseVisualStyleBackColor = true;
            this.uiEducationalDisciplineButton.Click += new System.EventHandler(this.uiSelectEducationalDisciplineButton_Click);
            // 
            // uiDateDateTimePicker
            // 
            this.uiDateDateTimePicker.Location = new System.Drawing.Point(86, 84);
            this.uiDateDateTimePicker.Name = "uiDateDateTimePicker";
            this.uiDateDateTimePicker.Size = new System.Drawing.Size(186, 20);
            this.uiDateDateTimePicker.TabIndex = 17;
            this.uiDateDateTimePicker.ValueChanged += new System.EventHandler(this.uiDateDateTimePicker_ValueChanged);
            // 
            // uiTeacherTextBox
            // 
            this.uiTeacherTextBox.Location = new System.Drawing.Point(86, 110);
            this.uiTeacherTextBox.Name = "uiTeacherTextBox";
            this.uiTeacherTextBox.Size = new System.Drawing.Size(135, 20);
            this.uiTeacherTextBox.TabIndex = 9;
            // 
            // uiTeacherLabel
            // 
            this.uiTeacherLabel.AutoSize = true;
            this.uiTeacherLabel.Location = new System.Drawing.Point(12, 113);
            this.uiTeacherLabel.Name = "uiTeacherLabel";
            this.uiTeacherLabel.Size = new System.Drawing.Size(45, 13);
            this.uiTeacherLabel.TabIndex = 10;
            this.uiTeacherLabel.Text = "Препод";
            // 
            // uiSelectTeacherButton
            // 
            this.uiSelectTeacherButton.Location = new System.Drawing.Point(227, 108);
            this.uiSelectTeacherButton.Name = "uiSelectTeacherButton";
            this.uiSelectTeacherButton.Size = new System.Drawing.Size(45, 23);
            this.uiSelectTeacherButton.TabIndex = 16;
            this.uiSelectTeacherButton.Text = "♥";
            this.uiSelectTeacherButton.UseVisualStyleBackColor = true;
            this.uiSelectTeacherButton.Click += new System.EventHandler(this.uiSelectTeacherButton_Click);
            // 
            // uiClassRoomTextBox
            // 
            this.uiClassRoomTextBox.Location = new System.Drawing.Point(86, 136);
            this.uiClassRoomTextBox.Name = "uiClassRoomTextBox";
            this.uiClassRoomTextBox.Size = new System.Drawing.Size(135, 20);
            this.uiClassRoomTextBox.TabIndex = 9;
            // 
            // uiClassRoomLabel
            // 
            this.uiClassRoomLabel.AutoSize = true;
            this.uiClassRoomLabel.Location = new System.Drawing.Point(12, 139);
            this.uiClassRoomLabel.Name = "uiClassRoomLabel";
            this.uiClassRoomLabel.Size = new System.Drawing.Size(49, 13);
            this.uiClassRoomLabel.TabIndex = 10;
            this.uiClassRoomLabel.Text = "Кабинет";
            // 
            // uiSelectClassRoomButton
            // 
            this.uiSelectClassRoomButton.Location = new System.Drawing.Point(227, 134);
            this.uiSelectClassRoomButton.Name = "uiSelectClassRoomButton";
            this.uiSelectClassRoomButton.Size = new System.Drawing.Size(45, 23);
            this.uiSelectClassRoomButton.TabIndex = 16;
            this.uiSelectClassRoomButton.Text = "♥";
            this.uiSelectClassRoomButton.UseVisualStyleBackColor = true;
            this.uiSelectClassRoomButton.Click += new System.EventHandler(this.uiSelectClassRoomButton_Click);
            // 
            // uiGroupTextBox
            // 
            this.uiGroupTextBox.Location = new System.Drawing.Point(86, 162);
            this.uiGroupTextBox.Name = "uiGroupTextBox";
            this.uiGroupTextBox.Size = new System.Drawing.Size(135, 20);
            this.uiGroupTextBox.TabIndex = 9;
            // 
            // uiGroupLabel
            // 
            this.uiGroupLabel.AutoSize = true;
            this.uiGroupLabel.Location = new System.Drawing.Point(12, 165);
            this.uiGroupLabel.Name = "uiGroupLabel";
            this.uiGroupLabel.Size = new System.Drawing.Size(42, 13);
            this.uiGroupLabel.TabIndex = 10;
            this.uiGroupLabel.Text = "Группа";
            // 
            // uiSelectGroupButton
            // 
            this.uiSelectGroupButton.Location = new System.Drawing.Point(227, 160);
            this.uiSelectGroupButton.Name = "uiSelectGroupButton";
            this.uiSelectGroupButton.Size = new System.Drawing.Size(45, 23);
            this.uiSelectGroupButton.TabIndex = 16;
            this.uiSelectGroupButton.Text = "♥";
            this.uiSelectGroupButton.UseVisualStyleBackColor = true;
            this.uiSelectGroupButton.Click += new System.EventHandler(this.uiSelectGroupButton_Click);
            // 
            // ClassTimeTableAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 217);
            this.Controls.Add(this.uiDateDateTimePicker);
            this.Controls.Add(this.uiSelectGroupButton);
            this.Controls.Add(this.uiSelectClassRoomButton);
            this.Controls.Add(this.uiSelectTeacherButton);
            this.Controls.Add(this.uiEducationalDisciplineButton);
            this.Controls.Add(this.uiSelectClassTimeButton);
            this.Controls.Add(this.uiClassTimeLabel);
            this.Controls.Add(this.uiClassTimeTextBox);
            this.Controls.Add(this.uiDateLabel);
            this.Controls.Add(this.uiGroupLabel);
            this.Controls.Add(this.uiClassRoomLabel);
            this.Controls.Add(this.uiTeacherLabel);
            this.Controls.Add(this.uiEducationalDisciplineLabel);
            this.Controls.Add(this.uiGroupTextBox);
            this.Controls.Add(this.uiClassRoomTextBox);
            this.Controls.Add(this.uiTeacherTextBox);
            this.Controls.Add(this.uiEducationalDisciplineTextBox);
            this.Controls.Add(this.uiCommitButton);
            this.Controls.Add(this.uiNameLabel);
            this.Controls.Add(this.uiNameTextBox);
            this.Name = "ClassTimeTableAddForm";
            this.Text = "добавление времени урока";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiNameTextBox;
        private System.Windows.Forms.Label uiNameLabel;
        private System.Windows.Forms.Button uiCommitButton;
        private System.Windows.Forms.Label uiEducationalDisciplineLabel;
        private System.Windows.Forms.TextBox uiEducationalDisciplineTextBox;
        private System.Windows.Forms.Label uiDateLabel;
        private System.Windows.Forms.Label uiClassTimeLabel;
        private System.Windows.Forms.TextBox uiClassTimeTextBox;
        private System.Windows.Forms.Button uiSelectClassTimeButton;
        private System.Windows.Forms.Button uiEducationalDisciplineButton;
        private System.Windows.Forms.DateTimePicker uiDateDateTimePicker;
        private System.Windows.Forms.TextBox uiTeacherTextBox;
        private System.Windows.Forms.Label uiTeacherLabel;
        private System.Windows.Forms.Button uiSelectTeacherButton;
        private System.Windows.Forms.TextBox uiClassRoomTextBox;
        private System.Windows.Forms.Label uiClassRoomLabel;
        private System.Windows.Forms.Button uiSelectClassRoomButton;
        private System.Windows.Forms.TextBox uiGroupTextBox;
        private System.Windows.Forms.Label uiGroupLabel;
        private System.Windows.Forms.Button uiSelectGroupButton;

    }
}