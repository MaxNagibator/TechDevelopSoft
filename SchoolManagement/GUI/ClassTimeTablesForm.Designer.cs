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
            this.uiMainDataGridView = new System.Windows.Forms.DataGridView();
            this.uiMenuContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uiDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiDateViewDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uiGroupComboBox = new System.Windows.Forms.ComboBox();
            this.uiDatePeriodLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.uiMainDataGridView)).BeginInit();
            this.uiMenuContextMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiMainDataGridView
            // 
            this.uiMainDataGridView.AllowUserToAddRows = false;
            this.uiMainDataGridView.AllowUserToDeleteRows = false;
            this.uiMainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiMainDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiMainDataGridView.Location = new System.Drawing.Point(0, 42);
            this.uiMainDataGridView.MultiSelect = false;
            this.uiMainDataGridView.Name = "uiMainDataGridView";
            this.uiMainDataGridView.ReadOnly = true;
            this.uiMainDataGridView.RowHeadersVisible = false;
            this.uiMainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.uiMainDataGridView.Size = new System.Drawing.Size(978, 220);
            this.uiMainDataGridView.TabIndex = 1;
            this.uiMainDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.uiMainDataGridView_CellMouseClick);
            // 
            // uiMenuContextMenuStrip
            // 
            this.uiMenuContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiDeleteToolStripMenuItem,
            this.uiAddToolStripMenuItem});
            this.uiMenuContextMenuStrip.Name = "contextMenuStrip1";
            this.uiMenuContextMenuStrip.Size = new System.Drawing.Size(125, 48);
            // 
            // uiDeleteToolStripMenuItem
            // 
            this.uiDeleteToolStripMenuItem.Name = "uiDeleteToolStripMenuItem";
            this.uiDeleteToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.uiDeleteToolStripMenuItem.Text = "удалить";
            this.uiDeleteToolStripMenuItem.Click += new System.EventHandler(this.uiDeleteToolStripMenuItem_Click);
            // 
            // uiAddToolStripMenuItem
            // 
            this.uiAddToolStripMenuItem.Name = "uiAddToolStripMenuItem";
            this.uiAddToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.uiAddToolStripMenuItem.Text = "добавить";
            this.uiAddToolStripMenuItem.Click += new System.EventHandler(this.uiAddToolStripMenuItem_Click);
            // 
            // uiDateViewDateTimePicker
            // 
            this.uiDateViewDateTimePicker.Location = new System.Drawing.Point(139, 12);
            this.uiDateViewDateTimePicker.Name = "uiDateViewDateTimePicker";
            this.uiDateViewDateTimePicker.Size = new System.Drawing.Size(153, 20);
            this.uiDateViewDateTimePicker.TabIndex = 5;
            this.uiDateViewDateTimePicker.ValueChanged += new System.EventHandler(this.uiDateViewDateTimePicker_ValueChanged);
            // 
            // uiGroupComboBox
            // 
            this.uiGroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiGroupComboBox.FormattingEnabled = true;
            this.uiGroupComboBox.Location = new System.Drawing.Point(12, 12);
            this.uiGroupComboBox.Name = "uiGroupComboBox";
            this.uiGroupComboBox.Size = new System.Drawing.Size(121, 21);
            this.uiGroupComboBox.TabIndex = 7;
            this.uiGroupComboBox.SelectedIndexChanged += new System.EventHandler(this.uiGroupComboBox_SelectedIndexChanged);
            // 
            // uiDatePeriodLabel
            // 
            this.uiDatePeriodLabel.AutoSize = true;
            this.uiDatePeriodLabel.Location = new System.Drawing.Point(298, 15);
            this.uiDatePeriodLabel.Name = "uiDatePeriodLabel";
            this.uiDatePeriodLabel.Size = new System.Drawing.Size(10, 13);
            this.uiDatePeriodLabel.TabIndex = 8;
            this.uiDatePeriodLabel.Text = "-";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uiGroupComboBox);
            this.panel1.Controls.Add(this.uiDateViewDateTimePicker);
            this.panel1.Controls.Add(this.uiDatePeriodLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 42);
            this.panel1.TabIndex = 9;
            // 
            // ClassTimeTablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 262);
            this.Controls.Add(this.uiMainDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "ClassTimeTablesForm";
            this.Text = "Расписание уроков";
            ((System.ComponentModel.ISupportInitialize)(this.uiMainDataGridView)).EndInit();
            this.uiMenuContextMenuStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView uiMainDataGridView;
        private System.Windows.Forms.DateTimePicker uiDateViewDateTimePicker;
        private System.Windows.Forms.ComboBox uiGroupComboBox;
        private System.Windows.Forms.Label uiDatePeriodLabel;
        private System.Windows.Forms.ContextMenuStrip uiMenuContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem uiDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uiAddToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}