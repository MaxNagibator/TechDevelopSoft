using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement.GUI
{
    public partial class EducationalDisciplinesForm : Form
    {
        public EducationalDiscipline SelectedEducationalDiscipline { get; set; }
        private List<EducationalDiscipline> _educationalDiscipline;

        public EducationalDisciplinesForm()
        {
            InitializeComponent();
            RefreshInfo();
        }

        private void RefreshInfo()
        {
            _educationalDiscipline = DatabaseManager.GetEducationalDisciplines();
            uiMainDataGridView.DataSource = _educationalDiscipline;
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
                SelectedEducationalDiscipline = _educationalDiscipline.FirstOrDefault(g => g.Id == (int)(uiMainDataGridView.SelectedRows[0].Cells["Id"].Value));
            }
        }

        private void uiMainDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectItem();
        }
    }
}
