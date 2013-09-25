using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement.GUI
{
    public partial class EducationalDisciplinesForm : Form
    {
        public bool IsSelectedMode;
        public EducationalDiscipline SelectedEducationalDiscipline { get; set; }
        private List<EducationalDiscipline> _educationalDiscipline;

        public EducationalDisciplinesForm()
        {
            InitializeComponent();
            CheckSelectedButton();
            RefreshInfo();
        }

        private void CheckSelectedButton()
        {
            uiSelectToolStripButton.Visible = IsSelectedMode;
        }

        private void RefreshInfo()
        {
            _educationalDiscipline = DatabaseManager.GetEducationalDisciplines();
            uiMainDataGridView.DataSource = _educationalDiscipline;
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
                SelectedEducationalDiscipline = _educationalDiscipline.FirstOrDefault(g => g.Id == (int)(uiMainDataGridView.SelectedRows[0].Cells["Id"].Value));
            }
        }


        private void uiAddToolStripButton_Click(object sender, EventArgs e)
        {
            using (var f = new EducationalDisciplineAddForm())
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
                    var selectedId = Convert.ToInt32(uiMainDataGridView.SelectedRows[0].Cells["Id"].Value);
                    DatabaseManager.DeleteEducationalDisciplineById(selectedId);
                    RefreshInfo();
                }
                catch (Exception)
                {
                    MessageBox.Show("Данный кабинет используется в расписание, его невозможно удалить.", "Информация");
                }
            }
        }

        private void uiSelectToolStripButton_Click(object sender, EventArgs e)
        {
            SelectItem();
        }

        private void uiMainDataGridView_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
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
