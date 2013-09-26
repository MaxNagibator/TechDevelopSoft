using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement.GUI
{
    public partial class ClassTimeTablesForm : Form
    {
        public ClassTimeTablesForm()
        {
            InitializeComponent();
            var gr = DatabaseManager.GetGroups();
            gr.Add(new Group("Все группы", "606217"));
            uiGroupComboBox.DataSource = gr;
            RefreshInfo();
        }

        private void RefreshInfo()
        {
            var classTimes = DatabaseManager.GetClassTimes();
            var date = uiDateViewDateTimePicker.Value;
            var dayOfWeek = (int) date.DayOfWeek;
            uiDatePeriodLabel.Text = date.Date.AddDays(1 - dayOfWeek).ToShortDateString() + " - " +
                                     date.Date.AddDays(7 - dayOfWeek).ToShortDateString();
            var group = (Group)uiGroupComboBox.SelectedItem;
            if (group.Comment == "606217")
            {
                var list = new List<ClassTimeTableWeekElem>();
                foreach (Group g in uiGroupComboBox.Items)
                {
                    if (g.Name != "Все группы")
                    {
                        var elements = GeteWeekElemByDateAndGroup(date, dayOfWeek, classTimes, g, true);
                        list.AddRange(elements);
                    }
                }
                RefreshClassTimeTableElemInfo(list);
            }
            else
            {
                var elements = GeteWeekElemByDateAndGroup(date,dayOfWeek, classTimes,group, false);
                RefreshClassTimeTableElemInfo(elements);
            }

            Globals.SetColumnWidthAndFormHeight(this, uiMainDataGridView, uiMainPanel);
        }

        private List<ClassTimeTableWeekElem> GeteWeekElemByDateAndGroup(DateTime date, int dayOfWeek, List<ClassTime> baseClassTimes, Group @group, bool isNeedGroupNameRow)
        {
            var classTimes = baseClassTimes.ToList();
            if(isNeedGroupNameRow)
            {
            classTimes.Insert(0, new ClassTime(-606217,group.Name,""));
            }
            var day1 = GetElementsByDateAndGroup(date.Date.AddDays(1 - dayOfWeek), classTimes, group);
            var day2 = GetElementsByDateAndGroup(date.Date.AddDays(2 - dayOfWeek), classTimes, group);
            var day3 = GetElementsByDateAndGroup(date.Date.AddDays(3 - dayOfWeek), classTimes, group);
            var day4 = GetElementsByDateAndGroup(date.Date.AddDays(4 - dayOfWeek), classTimes, group);
            var day5 = GetElementsByDateAndGroup(date.Date.AddDays(5 - dayOfWeek), classTimes, group);
            var day6 = GetElementsByDateAndGroup(date.Date.AddDays(6 - dayOfWeek), classTimes, group);
            var day7 = GetElementsByDateAndGroup(date.Date.AddDays(7 - dayOfWeek), classTimes, group);
            var elements = classTimes.Select((c, i) => new ClassTimeTableWeekElem
            {
                ClassTime = c,
                Day1 = day1[i],
                Day2 = day2[i],
                Day3 = day3[i],
                Day4 = day4[i],
                Day5 = day5[i],
                Day6 = day6[i],
                Day7 = day7[i],
            }).ToList();
            return elements;
        }

        private List<ClassTimeTableDayElem> GetElementsByDateAndGroup(DateTime date, IEnumerable<ClassTime> classTimes, Group group)
        {
            var classTimeTables = DatabaseManager.GetClassTimeTables();

            var classTimeTablesForDateAndGroup =
                classTimeTables.Where(c => c.Date.Date == date && c.Group.Id == group.Id);
            var elementsByDateAndGroup = (from c in classTimeTablesForDateAndGroup
                                          select new ClassTimeTableDayElem(
                                              c.EducationalDiscipline.Name + Environment.NewLine + c.ClassRoom.Number
                                              + Environment.NewLine + c.Teacher.Name, c)).ToList();
            return GetVoidClassTimeTables(elementsByDateAndGroup, classTimes, date, group);
        }

        private List<ClassTimeTableDayElem> GetVoidClassTimeTables(List<ClassTimeTableDayElem> classTimeTableDayElems,
                                                                   IEnumerable<ClassTime> classTimes, DateTime date,
                                                                   Group group)
        {
            return
                classTimes.Select(classTime =>
                                  (classTimeTableDayElems.Any(
                                      c => c.ClassTimeTable.ClassTime.Id == classTime.Id)
                                       ? classTimeTableDayElems.First(c => c.ClassTimeTable.ClassTime.Id == classTime.Id)
                                       : new ClassTimeTableDayElem(" ", new ClassTimeTable(group, date, classTime))
                                  )).ToList();
        }

        private void RefreshClassTimeTableElemInfo(List<ClassTimeTableWeekElem> elementsByDateAndGroup)
        {
            uiMainDataGridView.DataSource = elementsByDateAndGroup;
            var dataGridViewColumn2 = uiMainDataGridView.Columns["ClassTime"];
            if (dataGridViewColumn2 != null) dataGridViewColumn2.DisplayIndex = 0;
            SetColorFormGroupName();
        }

        private void SetColorFormGroupName()
        {
            foreach (DataGridViewRow dataGridViewRow in uiMainDataGridView.Rows)
            {
                if (((ClassTimeTableDayElem)(dataGridViewRow.Cells[0].Value)).ClassTimeTable.ClassTime.Number == -606217)
                {
                    dataGridViewRow.DefaultCellStyle.BackColor = Color.Gray;
                }
            }
        }

        private void uiDateViewDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            RefreshInfo();
        }

        private void uiGroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshInfo();
        }

        private void uiDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void Delete()
        {
            var classTimeTableDayElem = (ClassTimeTableDayElem)uiMainDataGridView.SelectedCells[0].Value;
            var classTimeTable = classTimeTableDayElem.ClassTimeTable;
            var selectedId = classTimeTable.Id;
            DatabaseManager.DeleteClassTimeTableById(selectedId);
            RefreshInfo();
        }

        private void uiAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var classTimeTableDayElem = (ClassTimeTableDayElem) uiMainDataGridView.SelectedCells[0].Value;
            var classTimeTable = classTimeTableDayElem.ClassTimeTable;
            using (var f = new ClassTimeTableAddForm(classTimeTable))
            {
                f.IsEditMode = true;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    RefreshInfo();
                }
            }
        }

        private void uiMainDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!Globals.IsRootMode) return;
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 &&
                uiMainDataGridView.Columns[e.ColumnIndex].DisplayIndex > 0)
            {
                uiMainDataGridView[e.ColumnIndex, e.RowIndex].Selected = true;
                var a = uiMainDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true).Location;
                uiMenuContextMenuStrip.Show(uiMainDataGridView, a.X + e.X, a.Y + e.Y);
            }
        }

        private void uiMenuContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var classTimeTableDayElem = (ClassTimeTableDayElem) uiMainDataGridView.SelectedCells[0].Value;
            uiDeleteToolStripMenuItem.Enabled = classTimeTableDayElem.Text != " ";
            uiAddToolStripMenuItem.Text = classTimeTableDayElem.Text == " " ? "добавить" : "редактировать";
        }

        private void ClassTimeTablesForm_Load(object sender, EventArgs e)
        {
            Globals.SetColumnWidthAndFormHeight(this, uiMainDataGridView, uiMainPanel);
        }

        private void uiMainDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!Globals.IsRootMode) return;
            if (e.Button == MouseButtons.Left && e.RowIndex > -1
                && uiMainDataGridView.Columns[e.ColumnIndex].DisplayIndex > 0)
            {
                var classTimeTableDayElem = (ClassTimeTableDayElem) uiMainDataGridView.SelectedCells[0].Value;
                var classTimeTable = classTimeTableDayElem.ClassTimeTable;
                using (var f = new ClassTimeTableAddForm(classTimeTable))
                {
                    f.IsEditMode = true;
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        RefreshInfo();
                    }
                }
            }
        }

        private void uiMainDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Globals.IsRootMode) return;
            if (e.KeyCode == Keys.Delete)
            {
                if (uiMainDataGridView.SelectedCells.Count == 1
                    && uiMainDataGridView.SelectedCells[0].RowIndex > -1
                    && uiMainDataGridView.Columns[uiMainDataGridView.SelectedCells[0].ColumnIndex].DisplayIndex > 0)
                {
                    var classTimeTableDayElem = (ClassTimeTableDayElem)uiMainDataGridView.SelectedCells[0].Value;
                    if(classTimeTableDayElem.Text != " ")
                    {
                        Delete();
                    }
                }
            }
        }
    }
}
