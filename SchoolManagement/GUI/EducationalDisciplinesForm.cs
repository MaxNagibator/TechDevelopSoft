using System;
using System.Windows.Forms;

namespace SchoolManagement.GUI
{
    public partial class EducationalDisciplinesForm : Form
    {
        public EducationalDisciplinesForm()
        {
            InitializeComponent();
            RefreshInfo();
        }

        private void RefreshInfo()
        {
            var teachers = DatabaseManager.GetEducationalDisciplines();
            uiMainDataGridView.DataSource = teachers;
            var dataGridViewColumn = uiMainDataGridView.Columns["Id"];
            if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
        }

        private void uiAddButton_Click(object sender, EventArgs e)
        {
            using (var f = new EducationalDisciplineAddForm())
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
                DatabaseManager.DeleteEducationalDisciplineById(selectedId);
                RefreshInfo();
            }
        }
    }
}
