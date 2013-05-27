namespace SchoolManagement.GUI
{
    partial class ClassRoomsForm
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
            this.uiAddStudentButton = new System.Windows.Forms.Button();
            this.uiStudentsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uiStudentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uiAddStudentButton
            // 
            this.uiAddStudentButton.Location = new System.Drawing.Point(12, 12);
            this.uiAddStudentButton.Name = "uiAddStudentButton";
            this.uiAddStudentButton.Size = new System.Drawing.Size(75, 23);
            this.uiAddStudentButton.TabIndex = 0;
            this.uiAddStudentButton.Text = "Добавить";
            this.uiAddStudentButton.UseVisualStyleBackColor = true;
            this.uiAddStudentButton.Click += new System.EventHandler(this.uiAddStudentButton_Click);
            // 
            // uiStudentsDataGridView
            // 
            this.uiStudentsDataGridView.AllowUserToAddRows = false;
            this.uiStudentsDataGridView.AllowUserToDeleteRows = false;
            this.uiStudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiStudentsDataGridView.Location = new System.Drawing.Point(12, 41);
            this.uiStudentsDataGridView.Name = "uiStudentsDataGridView";
            this.uiStudentsDataGridView.ReadOnly = true;
            this.uiStudentsDataGridView.Size = new System.Drawing.Size(626, 209);
            this.uiStudentsDataGridView.TabIndex = 1;
            // 
            // ClassRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 262);
            this.Controls.Add(this.uiStudentsDataGridView);
            this.Controls.Add(this.uiAddStudentButton);
            this.Name = "ClassRoomsForm";
            this.Text = "Кабинетики";
            ((System.ComponentModel.ISupportInitialize)(this.uiStudentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiAddStudentButton;
        private System.Windows.Forms.DataGridView uiStudentsDataGridView;
    }
}