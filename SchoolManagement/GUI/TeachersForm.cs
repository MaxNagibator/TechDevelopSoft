using System;
using System.Windows.Forms;

namespace SchoolManagement.GUI
{
    public partial class TeachersForm : Form
    {
        public TeachersForm()
        {
            InitializeComponent();
            RefreshTeachers();
        }

        private void RefreshTeachers()
        {
            var teachers = DatabaseManager.GetTeachers();
            uiMainDataGridView.DataSource = teachers;
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
    }
}
