namespace SchoolManagement.GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.uiMainToolStrip = new System.Windows.Forms.ToolStrip();
            this.uiClassRoomToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.uiGroupToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.uiEducationalDisciplineToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.uiTeacherToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.uiClassTimeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.uiClassTimeTableToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.uiMainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiMainToolStrip
            // 
            this.uiMainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.uiMainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiClassRoomToolStripButton,
            this.uiGroupToolStripButton,
            this.uiEducationalDisciplineToolStripButton,
            this.uiTeacherToolStripButton,
            this.uiClassTimeToolStripButton,
            this.uiClassTimeTableToolStripButton});
            this.uiMainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.uiMainToolStrip.Name = "uiMainToolStrip";
            this.uiMainToolStrip.Size = new System.Drawing.Size(422, 71);
            this.uiMainToolStrip.TabIndex = 0;
            this.uiMainToolStrip.Text = "Менюшка";
            // 
            // uiClassRoomToolStripButton
            // 
            this.uiClassRoomToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiClassRoomToolStripButton.Image = global::SchoolManagement.Properties.Resources.Home;
            this.uiClassRoomToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uiClassRoomToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiClassRoomToolStripButton.Name = "uiClassRoomToolStripButton";
            this.uiClassRoomToolStripButton.Size = new System.Drawing.Size(68, 68);
            this.uiClassRoomToolStripButton.Text = "кабинеты";
            this.uiClassRoomToolStripButton.ToolTipText = "кабинеты";
            this.uiClassRoomToolStripButton.Click += new System.EventHandler(this.uiClassRoomToolStripButton_Click);
            // 
            // uiGroupToolStripButton
            // 
            this.uiGroupToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiGroupToolStripButton.Image = global::SchoolManagement.Properties.Resources.Users_Group;
            this.uiGroupToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uiGroupToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiGroupToolStripButton.Name = "uiGroupToolStripButton";
            this.uiGroupToolStripButton.Size = new System.Drawing.Size(68, 68);
            this.uiGroupToolStripButton.Text = "группы";
            this.uiGroupToolStripButton.Click += new System.EventHandler(this.uiGroupToolStripButton_Click);
            // 
            // uiEducationalDisciplineToolStripButton
            // 
            this.uiEducationalDisciplineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiEducationalDisciplineToolStripButton.Image = global::SchoolManagement.Properties.Resources.Contact;
            this.uiEducationalDisciplineToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uiEducationalDisciplineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiEducationalDisciplineToolStripButton.Name = "uiEducationalDisciplineToolStripButton";
            this.uiEducationalDisciplineToolStripButton.Size = new System.Drawing.Size(68, 68);
            this.uiEducationalDisciplineToolStripButton.Text = "предметы";
            this.uiEducationalDisciplineToolStripButton.ToolTipText = "предметы";
            this.uiEducationalDisciplineToolStripButton.Click += new System.EventHandler(this.uiEducationalDisciplineToolStripButton_Click);
            // 
            // uiTeacherToolStripButton
            // 
            this.uiTeacherToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiTeacherToolStripButton.Image = global::SchoolManagement.Properties.Resources.Digg;
            this.uiTeacherToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uiTeacherToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiTeacherToolStripButton.Name = "uiTeacherToolStripButton";
            this.uiTeacherToolStripButton.Size = new System.Drawing.Size(68, 68);
            this.uiTeacherToolStripButton.Text = "учителя";
            this.uiTeacherToolStripButton.Click += new System.EventHandler(this.uTeacherToolStripButton_Click);
            // 
            // uiClassTimeToolStripButton
            // 
            this.uiClassTimeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiClassTimeToolStripButton.Image = global::SchoolManagement.Properties.Resources.Tag;
            this.uiClassTimeToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uiClassTimeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiClassTimeToolStripButton.Name = "uiClassTimeToolStripButton";
            this.uiClassTimeToolStripButton.Size = new System.Drawing.Size(68, 68);
            this.uiClassTimeToolStripButton.Text = "Время уроков";
            this.uiClassTimeToolStripButton.Click += new System.EventHandler(this.uiClassTimeToolStripButton_Click);
            // 
            // uiClassTimeTableToolStripButton
            // 
            this.uiClassTimeTableToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiClassTimeTableToolStripButton.Image = global::SchoolManagement.Properties.Resources.Calender;
            this.uiClassTimeTableToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uiClassTimeTableToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiClassTimeTableToolStripButton.Name = "uiClassTimeTableToolStripButton";
            this.uiClassTimeTableToolStripButton.Size = new System.Drawing.Size(68, 68);
            this.uiClassTimeTableToolStripButton.Text = "Расписание уроков";
            this.uiClassTimeTableToolStripButton.Click += new System.EventHandler(this.uiClassTimeTableToolStripButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 76);
            this.Controls.Add(this.uiMainToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Tag = "606217";
            this.Text = "Расписание";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.uiMainToolStrip.ResumeLayout(false);
            this.uiMainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip uiMainToolStrip;
        private System.Windows.Forms.ToolStripButton uiClassRoomToolStripButton;
        private System.Windows.Forms.ToolStripButton uiTeacherToolStripButton;
        private System.Windows.Forms.ToolStripButton uiGroupToolStripButton;
        private System.Windows.Forms.ToolStripButton uiEducationalDisciplineToolStripButton;
        private System.Windows.Forms.ToolStripButton uiClassTimeToolStripButton;
        private System.Windows.Forms.ToolStripButton uiClassTimeTableToolStripButton;


    }
}

