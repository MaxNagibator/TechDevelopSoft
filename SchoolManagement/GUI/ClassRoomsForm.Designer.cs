﻿namespace SchoolManagement.GUI
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
            this.uiAddButton = new System.Windows.Forms.Button();
            this.uiMainDataGridView = new System.Windows.Forms.DataGridView();
            this.uiDeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uiMainDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uiAddButton
            // 
            this.uiAddButton.Location = new System.Drawing.Point(12, 12);
            this.uiAddButton.Name = "uiAddButton";
            this.uiAddButton.Size = new System.Drawing.Size(75, 23);
            this.uiAddButton.TabIndex = 0;
            this.uiAddButton.Text = "Добавить";
            this.uiAddButton.UseVisualStyleBackColor = true;
            this.uiAddButton.Click += new System.EventHandler(this.uiAddButton_Click);
            // 
            // uiMainDataGridView
            // 
            this.uiMainDataGridView.AllowUserToAddRows = false;
            this.uiMainDataGridView.AllowUserToDeleteRows = false;
            this.uiMainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiMainDataGridView.Location = new System.Drawing.Point(12, 41);
            this.uiMainDataGridView.MultiSelect = false;
            this.uiMainDataGridView.Name = "uiMainDataGridView";
            this.uiMainDataGridView.ReadOnly = true;
            this.uiMainDataGridView.RowHeadersVisible = false;
            this.uiMainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiMainDataGridView.Size = new System.Drawing.Size(626, 209);
            this.uiMainDataGridView.TabIndex = 1;
            // 
            // uiDeleteButton
            // 
            this.uiDeleteButton.Location = new System.Drawing.Point(93, 12);
            this.uiDeleteButton.Name = "uiDeleteButton";
            this.uiDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.uiDeleteButton.TabIndex = 3;
            this.uiDeleteButton.Text = "Удалить";
            this.uiDeleteButton.UseVisualStyleBackColor = true;
            this.uiDeleteButton.Click += new System.EventHandler(this.uiDeleteButton_Click);
            // 
            // ClassRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 262);
            this.Controls.Add(this.uiDeleteButton);
            this.Controls.Add(this.uiMainDataGridView);
            this.Controls.Add(this.uiAddButton);
            this.Name = "ClassRoomsForm";
            this.Text = "Кабинетики";
            ((System.ComponentModel.ISupportInitialize)(this.uiMainDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiAddButton;
        private System.Windows.Forms.DataGridView uiMainDataGridView;
        private System.Windows.Forms.Button uiDeleteButton;
    }
}