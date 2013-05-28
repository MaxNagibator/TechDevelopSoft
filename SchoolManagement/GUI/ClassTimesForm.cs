﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement.GUI
{
    public partial class ClassTimesForm : Form
    {
        public ClassTime SelectedClassTime { get; set; }

        private List<ClassTime> _classTimes;

        public ClassTimesForm()
        {
            InitializeComponent();
            RefreshInfo();
        }

        private void RefreshInfo()
        {
            _classTimes = DatabaseManager.GetClassTimes();
            uiMainDataGridView.DataSource = _classTimes;
            var dataGridViewColumn = uiMainDataGridView.Columns["Id"];
            if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
        }

        private void uiAddButton_Click(object sender, EventArgs e)
        {
            using (var f = new ClassTimeAddForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    RefreshInfo();
                }
            }
        }

        private void uiDeleteButton_Click(object sender, EventArgs e)
        {
            if (uiMainDataGridView.SelectedRows.Count <= 0) return;
            if (uiMainDataGridView.SelectedRows[0].Cells["Id"].Value != null)
            {
                var selectedId = Convert.ToInt32(uiMainDataGridView.SelectedRows[0].Cells["Id"].Value);
                DatabaseManager.DeleteClassTimeById(selectedId);
                RefreshInfo();
            }
        }

        private void uiSelectButton_Click(object sender, EventArgs e)
        {
            SelectItem();
        }

        private void SelectItem()
        {
            if (uiMainDataGridView.SelectedRows.Count <= 0) return;
            if (uiMainDataGridView.SelectedRows[0].Cells["Id"].Value != null)
            {
                DialogResult = DialogResult.OK;
                SelectedClassTime = _classTimes.FirstOrDefault(g => g.Id == (int)(uiMainDataGridView.SelectedRows[0].Cells["Id"].Value));
            }
        }

        private void uiMainDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectItem();
        }
    }
}
