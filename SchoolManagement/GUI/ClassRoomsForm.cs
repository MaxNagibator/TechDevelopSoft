﻿using System;
using System.Collections.Generic;
using System.Drawing;
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
            RefreshInfo();
        }

        private void CheckSelectedButton()
        {
            uiSelectToolStripButton.Visible = IsSelectedMode;
        }

        private void ClassRoomsForm_Load(object sender, EventArgs e)
        {
            CheckSelectedButton();
            RefreshInfo();
        }

        private void RefreshInfo()
        {
            _classRooms = DatabaseManager.GetClassRooms();
            uiMainDataGridView.DataSource = _classRooms;
            var dataGridViewColumn = uiMainDataGridView.Columns["Id"];
            if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
            Globals.SetColumnWidthAndFormHeight(this, uiMainDataGridView, uiMainToolStrip);
        }

        private void SelectClassRoom()
        {
            if (!IsSelectedMode)
            {
                Edit();
                return;
            }
            if (uiMainDataGridView.SelectedRows.Count <= 0) return;
            if (uiMainDataGridView.SelectedRows[0].Cells["Id"].Value != null)
            {
                DialogResult = DialogResult.OK;
                SelectedClassRoom =
                    _classRooms.FirstOrDefault(g => g.Id == (int) (uiMainDataGridView.SelectedRows[0].Cells["Id"].Value));
            }
        }

        private void Edit()
        {
            if (uiMainDataGridView.SelectedRows.Count > 0)
            {
                ShowForm(true);
            }
        }

        private void uiMainDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectClassRoom();
        }

        private void uiAddToolStripButton_Click(object sender, EventArgs e)
        {
            ShowForm(false);
        }

        private void ShowForm(bool isEditMode)
        {
            int id = isEditMode ? (int) (uiMainDataGridView.SelectedRows[0].Cells["Id"].Value) : -1;
            using (var f = new ClassRoomAddForm(id))
            {
                f.StartPosition = FormStartPosition.Manual;
                f.Location = new Point(Location.X, Location.Y);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    RefreshInfo();
                }
            }
        }

        private void uiSelectToolStripButton_Click(object sender, EventArgs e)
        {
            SelectClassRoom();
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
                    DatabaseManager.DeleteClassRoomById(selectedId);
                    RefreshInfo();
                }
                catch (Exception)
                {
                    MessageBox.Show("Данный кабинет используется в расписание, его невозможно удалить.", "Информация");
                }
            }
        }

        private void uiMainDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Delete();
            }
        }

        private void uiEditToolStripButton_Click(object sender, EventArgs e)
        {
            Edit();
        }
    }
}
