using System;
using System.Windows.Forms;
using SchoolManagement.GUI;

namespace SchoolManagement
{
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent();
            RefreshInfo();
        }

        private void RefreshInfo()
        {
            var students = DatabaseManager.GetStudents();
            uiMainDataGridView.DataSource = students;
            var dataGridViewColumn = uiMainDataGridView.Columns["Id"];
            if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
        }

        private void uiAddButton_Click(object sender, EventArgs e)
        {
            using (var f = new StudentAddForm())
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
                DialogResult = DialogResult.OK;
                var selectedId = Convert.ToInt32(uiMainDataGridView.SelectedRows[0].Cells["Id"].Value);
                DatabaseManager.DeleteStudentById(selectedId);
                RefreshInfo();
            }
        }
    }
}
