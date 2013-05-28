using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement.GUI
{
    public partial class GroupsForm : Form
    {
        public Group SelectedGroup;
        private List<Group> _groups;

        public GroupsForm()
        {
            InitializeComponent();
            RefreshInfo();
        }

        private void RefreshInfo()
        {
            _groups = DatabaseManager.GetGroups();
            uiMainDataGridView.DataSource = _groups;
            var dataGridViewColumn = uiMainDataGridView.Columns["Id"];
            if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
        }

        private void uiAddButton_Click(object sender, EventArgs e)
        {
            using (var f = new GroupAddForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    RefreshInfo();
                }
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
                SelectedGroup = _groups.FirstOrDefault(g => g.Id == (int)(uiMainDataGridView.SelectedRows[0].Cells["Id"].Value));
            }
        }

        private void uiGroupsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectItem();
        }

        private void uiDeleteButton_Click(object sender, EventArgs e)
        {
            if (uiMainDataGridView.SelectedRows.Count <= 0) return;
            if (uiMainDataGridView.SelectedRows[0].Cells["Id"].Value != null)
            {
                var selectedId = Convert.ToInt32(uiMainDataGridView.SelectedRows[0].Cells["Id"].Value);
                DatabaseManager.DeleteGroupById(selectedId);
                RefreshInfo();
            }
        }
    }
}
