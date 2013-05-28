using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement.GUI
{
    public partial class TeachersForm : Form
    {
        public Teacher SelectedTeacher { get; set; }

        private List<Teacher> _teachers;

        public TeachersForm()
        {
            InitializeComponent();
            RefreshTeachers();
        }

        private void RefreshTeachers()
        {
            _teachers = DatabaseManager.GetTeachers();
            uiMainDataGridView.DataSource = _teachers;
            var dataGridViewColumn = uiMainDataGridView.Columns["Id"];
            if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
        }

        private void uiAddButton_Click(object sender, EventArgs e)
        {
            using (var f = new TeacherAddForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    RefreshTeachers();
                }
            }
        }

        private void SelectItem()
        {
            if (uiMainDataGridView.SelectedRows.Count <= 0) return;
            if (uiMainDataGridView.SelectedRows[0].Cells["Id"].Value != null)
            {
                DialogResult = DialogResult.OK;
                SelectedTeacher =
                    _teachers.FirstOrDefault(g => g.Id == (int) (uiMainDataGridView.SelectedRows[0].Cells["Id"].Value));
            }
        }

        private void uiDeleteButton_Click(object sender, EventArgs e)
        {
            if (uiMainDataGridView.SelectedRows.Count <= 0) return;
            if (uiMainDataGridView.SelectedRows[0].Cells["Id"].Value != null)
            {
                var selectedId = Convert.ToInt32(uiMainDataGridView.SelectedRows[0].Cells["Id"].Value);
                DatabaseManager.DeleteTeacherById(selectedId);
                RefreshTeachers();
            }
        }

        private void uiMainDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectItem();
        }

        private void uiSelectButton_Click(object sender, EventArgs e)
        {
            SelectItem();
        }
    }
}
