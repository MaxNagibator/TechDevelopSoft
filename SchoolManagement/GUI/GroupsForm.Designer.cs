namespace SchoolManagement
{
    partial class GroupsForm
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
            this.uiAddGroupButton = new System.Windows.Forms.Button();
            this.uiGroupsDataGridView = new System.Windows.Forms.DataGridView();
            this.uiSelectGroupButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uiAddGroupButton
            // 
            this.uiAddGroupButton.Location = new System.Drawing.Point(12, 12);
            this.uiAddGroupButton.Name = "uiAddGroupButton";
            this.uiAddGroupButton.Size = new System.Drawing.Size(87, 23);
            this.uiAddGroupButton.TabIndex = 0;
            this.uiAddGroupButton.Text = "Добавить";
            this.uiAddGroupButton.UseVisualStyleBackColor = true;
            this.uiAddGroupButton.Click += new System.EventHandler(this.uiAddStudentButton_Click);
            // 
            // uiGroupsDataGridView
            // 
            this.uiGroupsDataGridView.AllowUserToAddRows = false;
            this.uiGroupsDataGridView.AllowUserToDeleteRows = false;
            this.uiGroupsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiGroupsDataGridView.Location = new System.Drawing.Point(12, 41);
            this.uiGroupsDataGridView.MultiSelect = false;
            this.uiGroupsDataGridView.Name = "uiGroupsDataGridView";
            this.uiGroupsDataGridView.ReadOnly = true;
            this.uiGroupsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiGroupsDataGridView.Size = new System.Drawing.Size(626, 209);
            this.uiGroupsDataGridView.TabIndex = 1;
            this.uiGroupsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiGroupsDataGridView_CellDoubleClick);
            // 
            // uiSelectGroupButton
            // 
            this.uiSelectGroupButton.Location = new System.Drawing.Point(105, 12);
            this.uiSelectGroupButton.Name = "uiSelectGroupButton";
            this.uiSelectGroupButton.Size = new System.Drawing.Size(111, 23);
            this.uiSelectGroupButton.TabIndex = 2;
            this.uiSelectGroupButton.Text = "Выбрать";
            this.uiSelectGroupButton.UseVisualStyleBackColor = true;
            this.uiSelectGroupButton.Click += new System.EventHandler(this.uiSelectGroupButton_Click);
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 262);
            this.Controls.Add(this.uiSelectGroupButton);
            this.Controls.Add(this.uiGroupsDataGridView);
            this.Controls.Add(this.uiAddGroupButton);
            this.Name = "GroupsForm";
            this.Text = "GroupsForm";
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiAddGroupButton;
        private System.Windows.Forms.DataGridView uiGroupsDataGridView;
        private System.Windows.Forms.Button uiSelectGroupButton;
    }
}