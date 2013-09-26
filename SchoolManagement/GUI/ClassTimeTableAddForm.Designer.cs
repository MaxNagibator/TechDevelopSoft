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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassTimeTableAddForm));
            this.uiCommitButton = new System.Windows.Forms.Button();
            this.uiEducationalDisciplineLabel = new System.Windows.Forms.Label();
            this.uiDateLabel = new System.Windows.Forms.Label();
            this.uiClassTimeLabel = new System.Windows.Forms.Label();
            this.uiDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uiTeacherLabel = new System.Windows.Forms.Label();
            this.uiClassRoomLabel = new System.Windows.Forms.Label();
            this.uiGroupLabel = new System.Windows.Forms.Label();
            this.uiClassTimeСomboBox = new System.Windows.Forms.ComboBox();
            this.uiEducationalDisciplineСomboBox = new System.Windows.Forms.ComboBox();
            this.uiTeacherComboBox = new System.Windows.Forms.ComboBox();
            this.uiClassRoomComboBox = new System.Windows.Forms.ComboBox();
            this.uiGroupComboBox = new System.Windows.Forms.ComboBox();
            this.uiSelectGroupButton = new System.Windows.Forms.Button();
            this.uiSelectClassRoomButton = new System.Windows.Forms.Button();
            this.uiSelectTeacherButton = new System.Windows.Forms.Button();
            this.uiEducationalDisciplineButton = new System.Windows.Forms.Button();
            this.uiSelectClassTimeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiCommitButton
            // 
            this.uiCommitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiCommitButton.Location = new System.Drawing.Point(12, 235);
            this.uiCommitButton.Name = "uiCommitButton";
            this.uiCommitButton.Size = new System.Drawing.Size(315, 23);
            this.uiCommitButton.TabIndex = 12;
            this.uiCommitButton.Text = "подтвердить";
            this.uiCommitButton.UseVisualStyleBackColor = true;
            this.uiCommitButton.Click += new System.EventHandler(this.uiCommintButton_Click);
            // 
            // uiEducationalDisciplineLabel
            // 
            this.uiEducationalDisciplineLabel.AutoSize = true;
            this.uiEducationalDisciplineLabel.Location = new System.Drawing.Point(9, 71);
            this.uiEducationalDisciplineLabel.Name = "uiEducationalDisciplineLabel";
            this.uiEducationalDisciplineLabel.Size = new System.Drawing.Size(70, 13);
            this.uiEducationalDisciplineLabel.TabIndex = 10;
            this.uiEducationalDisciplineLabel.Text = "Дисциплина";
            // 
            // uiDateLabel
            // 
            this.uiDateLabel.AutoSize = true;
            this.uiDateLabel.Location = new System.Drawing.Point(22, 240);
            this.uiDateLabel.Name = "uiDateLabel";
            this.uiDateLabel.Size = new System.Drawing.Size(33, 13);
            this.uiDateLabel.TabIndex = 12;
            this.uiDateLabel.Text = "Дата";
            this.uiDateLabel.Visible = false;
            // 
            // uiClassTimeLabel
            // 
            this.uiClassTimeLabel.AutoSize = true;
            this.uiClassTimeLabel.Location = new System.Drawing.Point(9, 25);
            this.uiClassTimeLabel.Name = "uiClassTimeLabel";
            this.uiClassTimeLabel.Size = new System.Drawing.Size(72, 13);
            this.uiClassTimeLabel.TabIndex = 14;
            this.uiClassTimeLabel.Text = "Время урока";
            // 
            // uiDateDateTimePicker
            // 
            this.uiDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiDateDateTimePicker.Location = new System.Drawing.Point(86, 251);
            this.uiDateDateTimePicker.Name = "uiDateDateTimePicker";
            this.uiDateDateTimePicker.Size = new System.Drawing.Size(240, 20);
            this.uiDateDateTimePicker.TabIndex = 5;
            this.uiDateDateTimePicker.Visible = false;
            // 
            // uiTeacherLabel
            // 
            this.uiTeacherLabel.AutoSize = true;
            this.uiTeacherLabel.Location = new System.Drawing.Point(9, 117);
            this.uiTeacherLabel.Name = "uiTeacherLabel";
            this.uiTeacherLabel.Size = new System.Drawing.Size(49, 13);
            this.uiTeacherLabel.TabIndex = 10;
            this.uiTeacherLabel.Text = "Учитель";
            // 
            // uiClassRoomLabel
            // 
            this.uiClassRoomLabel.AutoSize = true;
            this.uiClassRoomLabel.Location = new System.Drawing.Point(9, 160);
            this.uiClassRoomLabel.Name = "uiClassRoomLabel";
            this.uiClassRoomLabel.Size = new System.Drawing.Size(49, 13);
            this.uiClassRoomLabel.TabIndex = 10;
            this.uiClassRoomLabel.Text = "Кабинет";
            // 
            // uiGroupLabel
            // 
            this.uiGroupLabel.AutoSize = true;
            this.uiGroupLabel.Location = new System.Drawing.Point(9, 206);
            this.uiGroupLabel.Name = "uiGroupLabel";
            this.uiGroupLabel.Size = new System.Drawing.Size(38, 13);
            this.uiGroupLabel.TabIndex = 10;
            this.uiGroupLabel.Text = "Класс";
            // 
            // uiClassTimeСomboBox
            // 
            this.uiClassTimeСomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiClassTimeСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiClassTimeСomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uiClassTimeСomboBox.FormattingEnabled = true;
            this.uiClassTimeСomboBox.Location = new System.Drawing.Point(87, 22);
            this.uiClassTimeСomboBox.Name = "uiClassTimeСomboBox";
            this.uiClassTimeСomboBox.Size = new System.Drawing.Size(194, 21);
            this.uiClassTimeСomboBox.TabIndex = 15;
            // 
            // uiEducationalDisciplineСomboBox
            // 
            this.uiEducationalDisciplineСomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiEducationalDisciplineСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiEducationalDisciplineСomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uiEducationalDisciplineСomboBox.FormattingEnabled = true;
            this.uiEducationalDisciplineСomboBox.ItemHeight = 13;
            this.uiEducationalDisciplineСomboBox.Location = new System.Drawing.Point(87, 68);
            this.uiEducationalDisciplineСomboBox.Name = "uiEducationalDisciplineСomboBox";
            this.uiEducationalDisciplineСomboBox.Size = new System.Drawing.Size(194, 21);
            this.uiEducationalDisciplineСomboBox.TabIndex = 16;
            // 
            // uiTeacherComboBox
            // 
            this.uiTeacherComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTeacherComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiTeacherComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uiTeacherComboBox.FormattingEnabled = true;
            this.uiTeacherComboBox.Location = new System.Drawing.Point(87, 114);
            this.uiTeacherComboBox.Name = "uiTeacherComboBox";
            this.uiTeacherComboBox.Size = new System.Drawing.Size(194, 21);
            this.uiTeacherComboBox.TabIndex = 17;
            // 
            // uiClassRoomComboBox
            // 
            this.uiClassRoomComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiClassRoomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiClassRoomComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uiClassRoomComboBox.FormattingEnabled = true;
            this.uiClassRoomComboBox.Location = new System.Drawing.Point(87, 157);
            this.uiClassRoomComboBox.Name = "uiClassRoomComboBox";
            this.uiClassRoomComboBox.Size = new System.Drawing.Size(194, 21);
            this.uiClassRoomComboBox.TabIndex = 18;
            // 
            // uiGroupComboBox
            // 
            this.uiGroupComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiGroupComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uiGroupComboBox.FormattingEnabled = true;
            this.uiGroupComboBox.Location = new System.Drawing.Point(87, 203);
            this.uiGroupComboBox.Name = "uiGroupComboBox";
            this.uiGroupComboBox.Size = new System.Drawing.Size(194, 21);
            this.uiGroupComboBox.TabIndex = 19;
            // 
            // uiSelectGroupButton
            // 
            this.uiSelectGroupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiSelectGroupButton.Image = global::SchoolManagement.Properties.Resources.Users_Group32;
            this.uiSelectGroupButton.Location = new System.Drawing.Point(287, 192);
            this.uiSelectGroupButton.Name = "uiSelectGroupButton";
            this.uiSelectGroupButton.Size = new System.Drawing.Size(40, 40);
            this.uiSelectGroupButton.TabIndex = 11;
            this.uiSelectGroupButton.UseVisualStyleBackColor = true;
            this.uiSelectGroupButton.Click += new System.EventHandler(this.uiSelectGroupButton_Click);
            // 
            // uiSelectClassRoomButton
            // 
            this.uiSelectClassRoomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiSelectClassRoomButton.Image = global::SchoolManagement.Properties.Resources.Home32;
            this.uiSelectClassRoomButton.Location = new System.Drawing.Point(287, 146);
            this.uiSelectClassRoomButton.Name = "uiSelectClassRoomButton";
            this.uiSelectClassRoomButton.Size = new System.Drawing.Size(40, 40);
            this.uiSelectClassRoomButton.TabIndex = 9;
            this.uiSelectClassRoomButton.UseVisualStyleBackColor = true;
            this.uiSelectClassRoomButton.Click += new System.EventHandler(this.uiSelectClassRoomButton_Click);
            // 
            // uiSelectTeacherButton
            // 
            this.uiSelectTeacherButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiSelectTeacherButton.Image = global::SchoolManagement.Properties.Resources.Digg32;
            this.uiSelectTeacherButton.Location = new System.Drawing.Point(287, 103);
            this.uiSelectTeacherButton.Name = "uiSelectTeacherButton";
            this.uiSelectTeacherButton.Size = new System.Drawing.Size(40, 40);
            this.uiSelectTeacherButton.TabIndex = 7;
            this.uiSelectTeacherButton.UseVisualStyleBackColor = true;
            this.uiSelectTeacherButton.Click += new System.EventHandler(this.uiSelectTeacherButton_Click);
            // 
            // uiEducationalDisciplineButton
            // 
            this.uiEducationalDisciplineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiEducationalDisciplineButton.Image = global::SchoolManagement.Properties.Resources.Contact32;
            this.uiEducationalDisciplineButton.Location = new System.Drawing.Point(287, 57);
            this.uiEducationalDisciplineButton.Name = "uiEducationalDisciplineButton";
            this.uiEducationalDisciplineButton.Size = new System.Drawing.Size(40, 40);
            this.uiEducationalDisciplineButton.TabIndex = 4;
            this.uiEducationalDisciplineButton.UseVisualStyleBackColor = true;
            this.uiEducationalDisciplineButton.Click += new System.EventHandler(this.uiSelectEducationalDisciplineButton_Click);
            // 
            // uiSelectClassTimeButton
            // 
            this.uiSelectClassTimeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiSelectClassTimeButton.Image = global::SchoolManagement.Properties.Resources.Tag32;
            this.uiSelectClassTimeButton.Location = new System.Drawing.Point(287, 11);
            this.uiSelectClassTimeButton.Name = "uiSelectClassTimeButton";
            this.uiSelectClassTimeButton.Size = new System.Drawing.Size(40, 40);
            this.uiSelectClassTimeButton.TabIndex = 2;
            this.uiSelectClassTimeButton.UseVisualStyleBackColor = true;
            this.uiSelectClassTimeButton.Click += new System.EventHandler(this.uiSelectClassTimeButton_Click);
            // 
            // ClassTimeTableAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 282);
            this.Controls.Add(this.uiGroupComboBox);
            this.Controls.Add(this.uiClassRoomComboBox);
            this.Controls.Add(this.uiTeacherComboBox);
            this.Controls.Add(this.uiEducationalDisciplineСomboBox);
            this.Controls.Add(this.uiClassTimeСomboBox);
            this.Controls.Add(this.uiDateDateTimePicker);
            this.Controls.Add(this.uiSelectGroupButton);
            this.Controls.Add(this.uiSelectClassRoomButton);
            this.Controls.Add(this.uiSelectTeacherButton);
            this.Controls.Add(this.uiEducationalDisciplineButton);
            this.Controls.Add(this.uiSelectClassTimeButton);
            this.Controls.Add(this.uiClassTimeLabel);
            this.Controls.Add(this.uiDateLabel);
            this.Controls.Add(this.uiGroupLabel);
            this.Controls.Add(this.uiClassRoomLabel);
            this.Controls.Add(this.uiTeacherLabel);
            this.Controls.Add(this.uiEducationalDisciplineLabel);
            this.Controls.Add(this.uiCommitButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(9999, 355);
            this.MinimumSize = new System.Drawing.Size(300, 320);
            this.Name = "ClassTimeTableAddForm";
            this.Text = "Добавление элемента расписания";
            this.Load += new System.EventHandler(this.ClassTimeTableAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiCommitButton;
        private System.Windows.Forms.Label uiEducationalDisciplineLabel;
        private System.Windows.Forms.Label uiDateLabel;
        private System.Windows.Forms.Label uiClassTimeLabel;
        private System.Windows.Forms.Button uiSelectClassTimeButton;
        private System.Windows.Forms.Button uiEducationalDisciplineButton;
        private System.Windows.Forms.DateTimePicker uiDateDateTimePicker;
        private System.Windows.Forms.Label uiTeacherLabel;
        private System.Windows.Forms.Button uiSelectTeacherButton;
        private System.Windows.Forms.Label uiClassRoomLabel;
        private System.Windows.Forms.Button uiSelectClassRoomButton;
        private System.Windows.Forms.Label uiGroupLabel;
        private System.Windows.Forms.Button uiSelectGroupButton;
        private System.Windows.Forms.ComboBox uiClassTimeСomboBox;
        private System.Windows.Forms.ComboBox uiEducationalDisciplineСomboBox;
        private System.Windows.Forms.ComboBox uiTeacherComboBox;
        private System.Windows.Forms.ComboBox uiClassRoomComboBox;
        private System.Windows.Forms.ComboBox uiGroupComboBox;

    }
}