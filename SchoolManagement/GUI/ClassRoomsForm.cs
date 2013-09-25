using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement.GUI
{
    public partial class ClassRoomsForm : Form
    {
        public bool IsSelectedMode;
        public ClassRoom SelectedClassRoom { get; set; }
        private List<ClassRoom> _classRooms;

        public ClassRoomsForm()
        {
            InitializeComponent();
            CheckSelectedButton();
            RefreshInfo();
        }

        private void CheckSelectedButton()
        {
            uiSelectClassRoomButton.Visible = IsSelectedMode;
        }

        private void RefreshInfo()
        {
            _classRooms = DatabaseManager.GetClassRooms();
            uiMainDataGridView.DataSource = _classRooms;
            var dataGridViewColumn = uiMainDataGridView.Columns["Id"];
            if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
        }

        private void uiAddButton_Click(object sender, EventArgs e)
        {
            using (var f = new ClassRoomAddForm())
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
                DatabaseManager.DeleteClassRoomById(selectedId);
                RefreshInfo();
            }
        }

        private void SelectClassRoom()
        {
            if (uiMainDataGridView.SelectedRows.Count <= 0) return;
            if (uiMainDataGridView.SelectedRows[0].Cells["Id"].Value != null)
            {
                DialogResult = DialogResult.OK;
                SelectedClassRoom = _classRooms.FirstOrDefault(g => g.Id == (int)(uiMainDataGridView.SelectedRows[0].Cells["Id"].Value));
            }
        }

        private void uiSelectClassRoomButton_Click(object sender, EventArgs e)
        {
            SelectClassRoom();
        }

        private void uiMainDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectClassRoom();
        }
    }
}
