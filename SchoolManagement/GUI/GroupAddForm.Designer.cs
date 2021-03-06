﻿namespace SchoolManagement.GUI
{
    partial class GroupAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupAddForm));
            this.uiNameTextBox = new System.Windows.Forms.TextBox();
            this.uiCommentTextBox = new System.Windows.Forms.TextBox();
            this.uiNameLabel = new System.Windows.Forms.Label();
            this.uiCommentLabel = new System.Windows.Forms.Label();
            this.uiCommitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiNameTextBox
            // 
            this.uiNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiNameTextBox.Location = new System.Drawing.Point(95, 6);
            this.uiNameTextBox.Name = "uiNameTextBox";
            this.uiNameTextBox.Size = new System.Drawing.Size(177, 20);
            this.uiNameTextBox.TabIndex = 0;
            this.uiNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uiTextBoxs_KeyDown);
            // 
            // uiCommentTextBox
            // 
            this.uiCommentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiCommentTextBox.Location = new System.Drawing.Point(95, 32);
            this.uiCommentTextBox.Name = "uiCommentTextBox";
            this.uiCommentTextBox.Size = new System.Drawing.Size(177, 20);
            this.uiCommentTextBox.TabIndex = 1;
            this.uiCommentTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uiTextBoxs_KeyDown);
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
            // uiCommentLabel
            // 
            this.uiCommentLabel.AutoSize = true;
            this.uiCommentLabel.Location = new System.Drawing.Point(9, 35);
            this.uiCommentLabel.Name = "uiCommentLabel";
            this.uiCommentLabel.Size = new System.Drawing.Size(77, 13);
            this.uiCommentLabel.TabIndex = 4;
            this.uiCommentLabel.Text = "Комментарий";
            // 
            // uiCommitButton
            // 
            this.uiCommitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiCommitButton.Location = new System.Drawing.Point(12, 58);
            this.uiCommitButton.Name = "uiCommitButton";
            this.uiCommitButton.Size = new System.Drawing.Size(260, 23);
            this.uiCommitButton.TabIndex = 9;
            this.uiCommitButton.Text = "Добавить";
            this.uiCommitButton.UseVisualStyleBackColor = true;
            this.uiCommitButton.Click += new System.EventHandler(this.uiCommitButton_Click);
            // 
            // GroupAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 87);
            this.Controls.Add(this.uiCommitButton);
            this.Controls.Add(this.uiCommentLabel);
            this.Controls.Add(this.uiNameLabel);
            this.Controls.Add(this.uiCommentTextBox);
            this.Controls.Add(this.uiNameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(99999, 125);
            this.MinimumSize = new System.Drawing.Size(300, 125);
            this.Name = "GroupAddForm";
            this.Text = "Добавление класса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiNameTextBox;
        private System.Windows.Forms.TextBox uiCommentTextBox;
        private System.Windows.Forms.Label uiNameLabel;
        private System.Windows.Forms.Label uiCommentLabel;
        private System.Windows.Forms.Button uiCommitButton;

    }
}