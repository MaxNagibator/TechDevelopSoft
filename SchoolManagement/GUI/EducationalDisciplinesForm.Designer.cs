namespace SchoolManagement.GUI
{
    partial class EducationalDisciplinesForm
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
            this.uiAddTeacherButton = new System.Windows.Forms.Button();
            this.uiTeachersDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uiTeachersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uiAddTeacherButton
            // 
            this.uiAddTeacherButton.Location = new System.Drawing.Point(12, 12);
            this.uiAddTeacherButton.Name = "uiAddTeacherButton";
            this.uiAddTeacherButton.Size = new System.Drawing.Size(75, 23);
            this.uiAddTeacherButton.TabIndex = 0;
            this.uiAddTeacherButton.Text = "Добавить";
            this.uiAddTeacherButton.UseVisualStyleBackColor = true;
            this.uiAddTeacherButton.Click += new System.EventHandler(this.uiAddTeacherButton_Click);
            // 
            // uiTeachersDataGridView
            // 
            this.uiTeachersDataGridView.AllowUserToAddRows = false;
            this.uiTeachersDataGridView.AllowUserToDeleteRows = false;
            this.uiTeachersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiTeachersDataGridView.Location = new System.Drawing.Point(12, 41);
            this.uiTeachersDataGridView.Name = "uiTeachersDataGridView";
            this.uiTeachersDataGridView.ReadOnly = true;
            this.uiTeachersDataGridView.Size = new System.Drawing.Size(626, 209);
            this.uiTeachersDataGridView.TabIndex = 1;
            // 
            // TeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 262);
            this.Controls.Add(this.uiTeachersDataGridView);
            this.Controls.Add(this.uiAddTeacherButton);
            this.Name = "TeachersForm";
            this.Text = "Учителя";
            ((System.ComponentModel.ISupportInitialize)(this.uiTeachersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiAddTeacherButton;
        private System.Windows.Forms.DataGridView uiTeachersDataGridView;
    }
}