namespace SchoolManagement.GUI
{
    partial class ClassTimeAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassTimeAddForm));
            this.uiStartTimeLabel = new System.Windows.Forms.Label();
            this.uiStartTimeTextBox = new System.Windows.Forms.TextBox();
            this.uiEndTimeLabel = new System.Windows.Forms.Label();
            this.uiEndTimeTextBox = new System.Windows.Forms.TextBox();
            this.uiNumberLabel = new System.Windows.Forms.Label();
            this.uiNumberTextBox = new System.Windows.Forms.TextBox();
            this.uiCommitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiStartTimeLabel
            // 
            this.uiStartTimeLabel.AutoSize = true;
            this.uiStartTimeLabel.Location = new System.Drawing.Point(9, 39);
            this.uiStartTimeLabel.Name = "uiStartTimeLabel";
            this.uiStartTimeLabel.Size = new System.Drawing.Size(78, 13);
            this.uiStartTimeLabel.TabIndex = 10;
            this.uiStartTimeLabel.Text = "Время начала";
            // 
            // uiStartTimeTextBox
            // 
            this.uiStartTimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiStartTimeTextBox.Location = new System.Drawing.Point(112, 36);
            this.uiStartTimeTextBox.Name = "uiStartTimeTextBox";
            this.uiStartTimeTextBox.Size = new System.Drawing.Size(160, 20);
            this.uiStartTimeTextBox.TabIndex = 1;
            this.uiStartTimeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uiTextBoxs_KeyDown);
            // 
            // uiEndTimeLabel
            // 
            this.uiEndTimeLabel.AutoSize = true;
            this.uiEndTimeLabel.Location = new System.Drawing.Point(9, 65);
            this.uiEndTimeLabel.Name = "uiEndTimeLabel";
            this.uiEndTimeLabel.Size = new System.Drawing.Size(90, 13);
            this.uiEndTimeLabel.TabIndex = 12;
            this.uiEndTimeLabel.Text = "Время кончания";
            // 
            // uiEndTimeTextBox
            // 
            this.uiEndTimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiEndTimeTextBox.Location = new System.Drawing.Point(112, 62);
            this.uiEndTimeTextBox.Name = "uiEndTimeTextBox";
            this.uiEndTimeTextBox.Size = new System.Drawing.Size(160, 20);
            this.uiEndTimeTextBox.TabIndex = 2;
            this.uiEndTimeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uiTextBoxs_KeyDown);
            // 
            // uiNumberLabel
            // 
            this.uiNumberLabel.AutoSize = true;
            this.uiNumberLabel.Location = new System.Drawing.Point(9, 13);
            this.uiNumberLabel.Name = "uiNumberLabel";
            this.uiNumberLabel.Size = new System.Drawing.Size(41, 13);
            this.uiNumberLabel.TabIndex = 14;
            this.uiNumberLabel.Text = "Номер";
            // 
            // uiNumberTextBox
            // 
            this.uiNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiNumberTextBox.Location = new System.Drawing.Point(56, 10);
            this.uiNumberTextBox.Name = "uiNumberTextBox";
            this.uiNumberTextBox.Size = new System.Drawing.Size(216, 20);
            this.uiNumberTextBox.TabIndex = 0;
            this.uiNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uiTextBoxs_KeyDown);
            // 
            // uiCommitButton
            // 
            this.uiCommitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiCommitButton.Location = new System.Drawing.Point(12, 88);
            this.uiCommitButton.Name = "uiCommitButton";
            this.uiCommitButton.Size = new System.Drawing.Size(260, 23);
            this.uiCommitButton.TabIndex = 8;
            this.uiCommitButton.Text = "Добавить";
            this.uiCommitButton.UseVisualStyleBackColor = true;
            this.uiCommitButton.Click += new System.EventHandler(this.uiCommitButton_Click);
            // 
            // ClassTimeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 117);
            this.Controls.Add(this.uiCommitButton);
            this.Controls.Add(this.uiNumberLabel);
            this.Controls.Add(this.uiNumberTextBox);
            this.Controls.Add(this.uiEndTimeLabel);
            this.Controls.Add(this.uiEndTimeTextBox);
            this.Controls.Add(this.uiStartTimeLabel);
            this.Controls.Add(this.uiStartTimeTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1024, 155);
            this.MinimumSize = new System.Drawing.Size(300, 155);
            this.Name = "ClassTimeAddForm";
            this.Text = "Добавление времени урока";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uiStartTimeLabel;
        private System.Windows.Forms.TextBox uiStartTimeTextBox;
        private System.Windows.Forms.Label uiEndTimeLabel;
        private System.Windows.Forms.TextBox uiEndTimeTextBox;
        private System.Windows.Forms.Label uiNumberLabel;
        private System.Windows.Forms.TextBox uiNumberTextBox;
        private System.Windows.Forms.Button uiCommitButton;

    }
}