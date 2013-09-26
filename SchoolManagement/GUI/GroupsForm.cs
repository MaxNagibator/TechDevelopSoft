using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement.GUI
{
    public partial class GroupsForm : Form
    {
        public bool IsSelectedMode;
        public Group SelectedGroup;
        private List<Group> _groups;

        public GroupsForm()
        {
            InitializeComponent();
            RefreshInfo();
        }

        private void GroupsForm_Load(object sender, EventArgs e)
        {
            CheckSelectedButton();
        }

        private void CheckSelectedButton()
        {
            uiSelectToolStripButton.Visible = IsSelectedMode;
        }

        private void RefreshInfo()
        {
            _groups = DatabaseManager.GetGroups();
            uiMainDataGridView.DataSource = _groups;
            var dataGridViewColumn = uiMainDataGridView.Columns["Id"];
            if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
            Globals.SetColumnWidthAndFormHeight(this, uiMainDataGridView, uiMainToolStrip);
        }

        private void SelectItem()
        {
            if (!IsSelectedMode)
            {
                return;
            }
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

        private void uiAddToolStripButton_Click(object sender, EventArgs e)
        {
            using (var f = new GroupAddForm())
            {
                f.StartPosition = FormStartPosition.Manual;
                f.Location = new Point(Location.X, Location.Y);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    RefreshInfo();
                }
            }
        }

        private void uiDeleteToolStripButton_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void Delete()
        {
            if (uiMainDataGridView.SelectedRows.Count <= 0) return;
            if (uiMainDataGridView.SelectedRows[0].Cells["Id"].Value != null)
            {
                try
                {
                    if(IsDeleteConfirm())
                    {
                        var selectedId = Convert.ToInt32(uiMainDataGridView.SelectedRows[0].Cells["Id"].Value);
                        DatabaseManager.DeleteGroupById(selectedId);
                        RefreshInfo();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Данный кабинет используется в расписание, его невозможно удалить.", "Информация");
                }
            }
        }

        private bool IsDeleteConfirm()
        {
            return MessageBox.Show("Удалить группу и расписание для неё?", "Требуется подтверждение",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
        }

        private void uiSelectToolStripButton_Click(object sender, EventArgs e)
        {
            SelectItem();
        }

        private void uiMainDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Delete();
            }
        }
    }
}
