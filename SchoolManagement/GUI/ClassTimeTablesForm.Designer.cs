namespace SchoolManagement.GUI
{
    partial class ClassTimeTablesForm
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
            this.components = new System.ComponentModel.Container();
            this.uiAddButton = new System.Windows.Forms.Button();
            this.uiMainDataGridView = new System.Windows.Forms.DataGridView();
            this.uiDeleteButton = new System.Windows.Forms.Button();
            this.uiClassTimesDataGridView = new System.Windows.Forms.DataGridView();
            this.uiDateViewDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uiGroupComboBox = new System.Windows.Forms.ComboBox();
            this.uiDatePeriodLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uiDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.uiMainDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiClassTimesDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            this.uiMainDataGridView.Location = new System.Drawing.Point(136, 51);
            this.uiMainDataGridView.MultiSelect = false;
            this.uiMainDataGridView.Name = "uiMainDataGridView";
            this.uiMainDataGridView.ReadOnly = true;
            this.uiMainDataGridView.RowHeadersVisible = false;
            this.uiMainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.uiMainDataGridView.Size = new System.Drawing.Size(847, 199);
            this.uiMainDataGridView.TabIndex = 1;
            this.uiMainDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.uiMainDataGridView_CellMouseClick);
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
            // uiClassTimesDataGridView
            // 
            this.uiClassTimesDataGridView.AllowUserToAddRows = false;
            this.uiClassTimesDataGridView.AllowUserToDeleteRows = false;
            this.uiClassTimesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiClassTimesDataGridView.Location = new System.Drawing.Point(12, 51);
            this.uiClassTimesDataGridView.MultiSelect = false;
            this.uiClassTimesDataGridView.Name = "uiClassTimesDataGridView";
            this.uiClassTimesDataGridView.ReadOnly = true;
            this.uiClassTimesDataGridView.RowHeadersVisible = false;
            this.uiClassTimesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiClassTimesDataGridView.Size = new System.Drawing.Size(94, 199);
            this.uiClassTimesDataGridView.TabIndex = 4;
            // 
            // uiDateViewDateTimePicker
            // 
            this.uiDateViewDateTimePicker.Location = new System.Drawing.Point(485, 12);
            this.uiDateViewDateTimePicker.Name = "uiDateViewDateTimePicker";
            this.uiDateViewDateTimePicker.Size = new System.Drawing.Size(153, 20);
            this.uiDateViewDateTimePicker.TabIndex = 5;
            this.uiDateViewDateTimePicker.ValueChanged += new System.EventHandler(this.uiDateViewDateTimePicker_ValueChanged);
            // 
            // uiGroupComboBox
            // 
            this.uiGroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiGroupComboBox.FormattingEnabled = true;
            this.uiGroupComboBox.Location = new System.Drawing.Point(358, 11);
            this.uiGroupComboBox.Name = "uiGroupComboBox";
            this.uiGroupComboBox.Size = new System.Drawing.Size(121, 21);
            this.uiGroupComboBox.TabIndex = 7;
            this.uiGroupComboBox.SelectedIndexChanged += new System.EventHandler(this.uiGroupComboBox_SelectedIndexChanged);
            // 
            // uiDatePeriodLabel
            // 
            this.uiDatePeriodLabel.AutoSize = true;
            this.uiDatePeriodLabel.Location = new System.Drawing.Point(482, 35);
            this.uiDatePeriodLabel.Name = "uiDatePeriodLabel";
            this.uiDatePeriodLabel.Size = new System.Drawing.Size(10, 13);
            this.uiDatePeriodLabel.TabIndex = 8;
            this.uiDatePeriodLabel.Text = "-";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiDeleteToolStripMenuItem,
            this.uiAddToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // uiDeleteToolStripMenuItem
            // 
            this.uiDeleteToolStripMenuItem.Name = "uiDeleteToolStripMenuItem";
            this.uiDeleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uiDeleteToolStripMenuItem.Text = "удалить";
            this.uiDeleteToolStripMenuItem.Click += new System.EventHandler(this.uiDeleteToolStripMenuItem_Click);
            // 
            // uiAddToolStripMenuItem
            // 
            this.uiAddToolStripMenuItem.Name = "uiAddToolStripMenuItem";
            this.uiAddToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uiAddToolStripMenuItem.Text = "добавить";
            this.uiAddToolStripMenuItem.Click += new System.EventHandler(this.uiAddToolStripMenuItem_Click);
            // 
            // ClassTimeTablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 262);
            this.Controls.Add(this.uiDatePeriodLabel);
            this.Controls.Add(this.uiGroupComboBox);
            this.Controls.Add(this.uiDateViewDateTimePicker);
            this.Controls.Add(this.uiClassTimesDataGridView);
            this.Controls.Add(this.uiDeleteButton);
            this.Controls.Add(this.uiMainDataGridView);
            this.Controls.Add(this.uiAddButton);
            this.Name = "ClassTimeTablesForm";
            this.Text = "Расписание уроков";
            ((System.ComponentModel.ISupportInitialize)(this.uiMainDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiClassTimesDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiAddButton;
        private System.Windows.Forms.DataGridView uiMainDataGridView;
        private System.Windows.Forms.Button uiDeleteButton;
        private System.Windows.Forms.DataGridView uiClassTimesDataGridView;
        private System.Windows.Forms.DateTimePicker uiDateViewDateTimePicker;
        private System.Windows.Forms.ComboBox uiGroupComboBox;
        private System.Windows.Forms.Label uiDatePeriodLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uiDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uiAddToolStripMenuItem;
    }
}