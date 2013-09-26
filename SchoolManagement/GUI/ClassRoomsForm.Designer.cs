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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassRoomsForm));
            this.uiMainDataGridView = new System.Windows.Forms.DataGridView();
            this.uiMainToolStrip = new System.Windows.Forms.ToolStrip();
            this.uiAddToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.uiSelectToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.uiDeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.uiEditToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.uiMainDataGridView)).BeginInit();
            this.uiMainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiMainDataGridView
            // 
            this.uiMainDataGridView.AllowUserToAddRows = false;
            this.uiMainDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiMainDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.uiMainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiMainDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.uiMainDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiMainDataGridView.Location = new System.Drawing.Point(0, 39);
            this.uiMainDataGridView.MultiSelect = false;
            this.uiMainDataGridView.Name = "uiMainDataGridView";
            this.uiMainDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiMainDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.uiMainDataGridView.RowHeadersVisible = false;
            this.uiMainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiMainDataGridView.Size = new System.Drawing.Size(673, 246);
            this.uiMainDataGridView.TabIndex = 1;
            this.uiMainDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiMainDataGridView_CellDoubleClick);
            this.uiMainDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uiMainDataGridView_KeyDown);
            // 
            // uiMainToolStrip
            // 
            this.uiMainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.uiMainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiAddToolStripButton,
            this.uiEditToolStripButton,
            this.uiSelectToolStripButton,
            this.uiDeleteToolStripButton});
            this.uiMainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.uiMainToolStrip.Name = "uiMainToolStrip";
            this.uiMainToolStrip.Size = new System.Drawing.Size(673, 39);
            this.uiMainToolStrip.TabIndex = 5;
            this.uiMainToolStrip.Text = "uiMainToolStrip";
            // 
            // uiAddToolStripButton
            // 
            this.uiAddToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiAddToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("uiAddToolStripButton.Image")));
            this.uiAddToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uiAddToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiAddToolStripButton.Name = "uiAddToolStripButton";
            this.uiAddToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.uiAddToolStripButton.Text = "Добавить";
            this.uiAddToolStripButton.ToolTipText = "Добавить";
            this.uiAddToolStripButton.Click += new System.EventHandler(this.uiAddToolStripButton_Click);
            // 
            // uiSelectToolStripButton
            // 
            this.uiSelectToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiSelectToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("uiSelectToolStripButton.Image")));
            this.uiSelectToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uiSelectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiSelectToolStripButton.Name = "uiSelectToolStripButton";
            this.uiSelectToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.uiSelectToolStripButton.Text = "Выбрать";
            this.uiSelectToolStripButton.ToolTipText = "Выбрать";
            this.uiSelectToolStripButton.Click += new System.EventHandler(this.uiSelectToolStripButton_Click);
            // 
            // uiDeleteToolStripButton
            // 
            this.uiDeleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiDeleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("uiDeleteToolStripButton.Image")));
            this.uiDeleteToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uiDeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiDeleteToolStripButton.Margin = new System.Windows.Forms.Padding(30, 1, 0, 2);
            this.uiDeleteToolStripButton.Name = "uiDeleteToolStripButton";
            this.uiDeleteToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.uiDeleteToolStripButton.Text = "Удалить";
            this.uiDeleteToolStripButton.Click += new System.EventHandler(this.uiDeleteToolStripButton_Click);
            // 
            // uiEditToolStripButton
            // 
            this.uiEditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiEditToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("uiEditToolStripButton.Image")));
            this.uiEditToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uiEditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiEditToolStripButton.Name = "uiEditToolStripButton";
            this.uiEditToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.uiEditToolStripButton.Text = "Редактировать";
            this.uiEditToolStripButton.ToolTipText = "Добавить";
            this.uiEditToolStripButton.Click += new System.EventHandler(this.uiEditToolStripButton_Click);
            // 
            // ClassRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 285);
            this.Controls.Add(this.uiMainDataGridView);
            this.Controls.Add(this.uiMainToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClassRoomsForm";
            this.Text = "Кабинетики";
            this.Load += new System.EventHandler(this.ClassRoomsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiMainDataGridView)).EndInit();
            this.uiMainToolStrip.ResumeLayout(false);
            this.uiMainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uiMainDataGridView;
        private System.Windows.Forms.ToolStrip uiMainToolStrip;
        private System.Windows.Forms.ToolStripButton uiDeleteToolStripButton;
        private System.Windows.Forms.ToolStripButton uiAddToolStripButton;
        private System.Windows.Forms.ToolStripButton uiSelectToolStripButton;
        private System.Windows.Forms.ToolStripButton uiEditToolStripButton;
    }
}