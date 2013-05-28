namespace SchoolManagement.GUI
{
    partial class EducationalDisciplineAddForm
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
            this.uiCommintButton = new System.Windows.Forms.Button();
            this.uiDescriptionLabel = new System.Windows.Forms.Label();
            this.uiDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uiNameTextBox
            // 
            this.uiNameTextBox.Location = new System.Drawing.Point(81, 6);
            this.uiNameTextBox.Name = "uiNameTextBox";
            this.uiNameTextBox.Size = new System.Drawing.Size(191, 20);
            this.uiNameTextBox.TabIndex = 0;
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
            // uiCommintButton
            // 
            this.uiCommintButton.Location = new System.Drawing.Point(12, 58);
            this.uiCommintButton.Name = "uiCommintButton";
            this.uiCommintButton.Size = new System.Drawing.Size(87, 23);
            this.uiCommintButton.TabIndex = 8;
            this.uiCommintButton.Text = "OK";
            this.uiCommintButton.UseVisualStyleBackColor = true;
            this.uiCommintButton.Click += new System.EventHandler(this.uiCommintButton_Click);
            // 
            // uiDescriptionLabel
            // 
            this.uiDescriptionLabel.AutoSize = true;
            this.uiDescriptionLabel.Location = new System.Drawing.Point(12, 35);
            this.uiDescriptionLabel.Name = "uiDescriptionLabel";
            this.uiDescriptionLabel.Size = new System.Drawing.Size(57, 13);
            this.uiDescriptionLabel.TabIndex = 10;
            this.uiDescriptionLabel.Text = "Описание";
            // 
            // uiDescriptionTextBox
            // 
            this.uiDescriptionTextBox.Location = new System.Drawing.Point(81, 32);
            this.uiDescriptionTextBox.Name = "uiDescriptionTextBox";
            this.uiDescriptionTextBox.Size = new System.Drawing.Size(191, 20);
            this.uiDescriptionTextBox.TabIndex = 9;
            // 
            // EducationalDisciplineAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 89);
            this.Controls.Add(this.uiDescriptionLabel);
            this.Controls.Add(this.uiDescriptionTextBox);
            this.Controls.Add(this.uiCommintButton);
            this.Controls.Add(this.uiNameLabel);
            this.Controls.Add(this.uiNameTextBox);
            this.Name = "EducationalDisciplineAddForm";
            this.Text = "добавление дичциплины";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiNameTextBox;
        private System.Windows.Forms.Label uiNameLabel;
        private System.Windows.Forms.Button uiCommintButton;
        private System.Windows.Forms.Label uiDescriptionLabel;
        private System.Windows.Forms.TextBox uiDescriptionTextBox;

    }
}