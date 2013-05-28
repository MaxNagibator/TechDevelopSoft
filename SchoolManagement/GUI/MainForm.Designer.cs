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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.uiClassRoomToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.uiStudentsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.uiGroupToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.uiEducationalDisciplineToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.uiTeacherToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.uiClassTimeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.uiClassTimeTableToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiClassRoomToolStripButton,
            this.uiStudentsToolStripButton,
            this.uiGroupToolStripButton,
            this.uiEducationalDisciplineToolStripButton,
            this.uiTeacherToolStripButton,
            this.uiClassTimeToolStripButton,
            this.uiClassTimeTableToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(458, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // uiClassRoomToolStripButton
            // 
            this.uiClassRoomToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiClassRoomToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("uiClassRoomToolStripButton.Image")));
            this.uiClassRoomToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiClassRoomToolStripButton.Name = "uiClassRoomToolStripButton";
            this.uiClassRoomToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.uiClassRoomToolStripButton.Text = "кабинеты";
            this.uiClassRoomToolStripButton.ToolTipText = "кабинеты";
            this.uiClassRoomToolStripButton.Click += new System.EventHandler(this.uiClassRoomToolStripButton_Click);
            // 
            // uiStudentsToolStripButton
            // 
            this.uiStudentsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiStudentsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("uiStudentsToolStripButton.Image")));
            this.uiStudentsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiStudentsToolStripButton.Name = "uiStudentsToolStripButton";
            this.uiStudentsToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.uiStudentsToolStripButton.Text = "ученики";
            this.uiStudentsToolStripButton.ToolTipText = "ученики";
            this.uiStudentsToolStripButton.Click += new System.EventHandler(this.uiStudentsToolStripButton_Click);
            // 
            // uiGroupToolStripButton
            // 
            this.uiGroupToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiGroupToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("uiGroupToolStripButton.Image")));
            this.uiGroupToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiGroupToolStripButton.Name = "uiGroupToolStripButton";
            this.uiGroupToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.uiGroupToolStripButton.Text = "группы";
            this.uiGroupToolStripButton.Click += new System.EventHandler(this.uiGroupToolStripButton_Click);
            // 
            // uiEducationalDisciplineToolStripButton
            // 
            this.uiEducationalDisciplineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiEducationalDisciplineToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("uiEducationalDisciplineToolStripButton.Image")));
            this.uiEducationalDisciplineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiEducationalDisciplineToolStripButton.Name = "uiEducationalDisciplineToolStripButton";
            this.uiEducationalDisciplineToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.uiEducationalDisciplineToolStripButton.Text = "предметы";
            this.uiEducationalDisciplineToolStripButton.ToolTipText = "предметы";
            this.uiEducationalDisciplineToolStripButton.Click += new System.EventHandler(this.uiEducationalDisciplineToolStripButton_Click);
            // 
            // uiTeacherToolStripButton
            // 
            this.uiTeacherToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiTeacherToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("uiTeacherToolStripButton.Image")));
            this.uiTeacherToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiTeacherToolStripButton.Name = "uiTeacherToolStripButton";
            this.uiTeacherToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.uiTeacherToolStripButton.Text = "учителя";
            this.uiTeacherToolStripButton.Click += new System.EventHandler(this.uTeacherToolStripButton_Click);
            // 
            // uiClassTimeToolStripButton
            // 
            this.uiClassTimeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiClassTimeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("uiClassTimeToolStripButton.Image")));
            this.uiClassTimeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiClassTimeToolStripButton.Name = "uiClassTimeToolStripButton";
            this.uiClassTimeToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.uiClassTimeToolStripButton.Text = "Время уроков";
            this.uiClassTimeToolStripButton.Click += new System.EventHandler(this.uiClassTimeToolStripButton_Click);
            // 
            // uiClassTimeTableToolStripButton
            // 
            this.uiClassTimeTableToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiClassTimeTableToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("uiClassTimeTableToolStripButton.Image")));
            this.uiClassTimeTableToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiClassTimeTableToolStripButton.Name = "uiClassTimeTableToolStripButton";
            this.uiClassTimeTableToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.uiClassTimeTableToolStripButton.Text = "Расписание уроков";
            this.uiClassTimeTableToolStripButton.Click += new System.EventHandler(this.uiClassTimeTableToolStripButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 159);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Tag = "606217";
            this.Text = "Importer";
            this.Load += new System.EventHandler(this.UIQuestionnaireServerMainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton uiStudentsToolStripButton;
        private System.Windows.Forms.ToolStripButton uiClassRoomToolStripButton;
        private System.Windows.Forms.ToolStripButton uiTeacherToolStripButton;
        private System.Windows.Forms.ToolStripButton uiGroupToolStripButton;
        private System.Windows.Forms.ToolStripButton uiEducationalDisciplineToolStripButton;
        private System.Windows.Forms.ToolStripButton uiClassTimeToolStripButton;
        private System.Windows.Forms.ToolStripButton uiClassTimeTableToolStripButton;


    }
}

