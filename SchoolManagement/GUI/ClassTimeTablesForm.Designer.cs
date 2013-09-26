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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassTimeTablesForm));
            this.uiMainDataGridView = new System.Windows.Forms.DataGridView();
            this.uiMenuContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uiDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiDateViewDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uiGroupComboBox = new System.Windows.Forms.ComboBox();
            this.uiDatePeriodLabel = new System.Windows.Forms.Label();
            this.uiMainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.uiMainDataGridView)).BeginInit();
            this.uiMenuContextMenuStrip.SuspendLayout();
            this.uiMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiMainDataGridView
            // 
            this.uiMainDataGridView.AllowUserToAddRows = false;
            this.uiMainDataGridView.AllowUserToDeleteRows = false;
            this.uiMainDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiMainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiMainDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.uiMainDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiMainDataGridView.Location = new System.Drawing.Point(0, 42);
            this.uiMainDataGridView.MultiSelect = false;
            this.uiMainDataGridView.Name = "uiMainDataGridView";
            this.uiMainDataGridView.ReadOnly = true;
            this.uiMainDataGridView.RowHeadersVisible = false;
            this.uiMainDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.uiMainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.uiMainDataGridView.Size = new System.Drawing.Size(983, 220);
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
            this.uiMenuContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.uiMenuContextMenuStrip_Opening);
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
            this.uiDateViewDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiDateViewDateTimePicker.Location = new System.Drawing.Point(356, 13);
            this.uiDateViewDateTimePicker.Name = "uiDateViewDateTimePicker";
            this.uiDateViewDateTimePicker.Size = new System.Drawing.Size(150, 20);
            this.uiDateViewDateTimePicker.TabIndex = 5;
            this.uiDateViewDateTimePicker.ValueChanged += new System.EventHandler(this.uiDateViewDateTimePicker_ValueChanged);
            // 
            // uiGroupComboBox
            // 
            this.uiGroupComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiGroupComboBox.FormattingEnabled = true;
            this.uiGroupComboBox.Location = new System.Drawing.Point(12, 12);
            this.uiGroupComboBox.Name = "uiGroupComboBox";
            this.uiGroupComboBox.Size = new System.Drawing.Size(335, 21);
            this.uiGroupComboBox.TabIndex = 7;
            this.uiGroupComboBox.SelectedIndexChanged += new System.EventHandler(this.uiGroupComboBox_SelectedIndexChanged);
            // 
            // uiDatePeriodLabel
            // 
            this.uiDatePeriodLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiDatePeriodLabel.AutoSize = true;
            this.uiDatePeriodLabel.Location = new System.Drawing.Point(515, 16);
            this.uiDatePeriodLabel.Name = "uiDatePeriodLabel";
            this.uiDatePeriodLabel.Size = new System.Drawing.Size(10, 13);
            this.uiDatePeriodLabel.TabIndex = 8;
            this.uiDatePeriodLabel.Text = "-";
            // 
            // uiMainPanel
            // 
            this.uiMainPanel.Controls.Add(this.uiGroupComboBox);
            this.uiMainPanel.Controls.Add(this.uiDateViewDateTimePicker);
            this.uiMainPanel.Controls.Add(this.uiDatePeriodLabel);
            this.uiMainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiMainPanel.Location = new System.Drawing.Point(0, 0);
            this.uiMainPanel.Name = "uiMainPanel";
            this.uiMainPanel.Size = new System.Drawing.Size(983, 42);
            this.uiMainPanel.TabIndex = 9;
            // 
            // ClassTimeTablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 262);
            this.Controls.Add(this.uiMainDataGridView);
            this.Controls.Add(this.uiMainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClassTimeTablesForm";
            this.Text = "Расписание уроков";
            ((System.ComponentModel.ISupportInitialize)(this.uiMainDataGridView)).EndInit();
            this.uiMenuContextMenuStrip.ResumeLayout(false);
            this.uiMainPanel.ResumeLayout(false);
            this.uiMainPanel.PerformLayout();
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
        private System.Windows.Forms.Panel uiMainPanel;
    }
}