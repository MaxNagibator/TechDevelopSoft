using System;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class GroupsForm : Form
    {
        public int SelectedId;

        public GroupsForm()
        {
            InitializeComponent();
            RefreshGroups();
        }

        private void RefreshGroups()
        {
            var groups = DatabaseManager.GetGroups();
            uiGroupsDataGridView.DataSource = groups;
        }

        private void uiAddStudentButton_Click(object sender, EventArgs e)
        {
            using (var f = new GroupAddForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    RefreshGroups();
                }
            }
        }

        private void uiSelectGroupButton_Click(object sender, EventArgs e)
        {
            SelectGroup();
        }

        private void SelectGroup()
        {
            if (uiGroupsDataGridView.SelectedRows.Count <= 0) return;
            if (uiGroupsDataGridView.SelectedRows[0].Cells["Id"].Value != null)
            {
                DialogResult = DialogResult.OK;
                SelectedId = Convert.ToInt32(uiGroupsDataGridView.SelectedRows[0].Cells["Id"].Value);
            }
        }

        private void uiGroupsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectGroup();
        }
    }
}
