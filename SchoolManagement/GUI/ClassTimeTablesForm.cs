using System;
using System.Collections.Generic;
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
            uiGroupComboBox.DataSource = DatabaseManager.GetGroups();
            RefreshInfo();
        }

        private void RefreshInfo()
        {
            var classTimes = DatabaseManager.GetClassTimes();
            var date = uiDateViewDateTimePicker.Value;
            var dayOfWeek = (int) date.DayOfWeek;
            uiDatePeriodLabel.Text = date.Date.AddDays(1 - dayOfWeek).ToShortDateString() + " - " +
                                     date.Date.AddDays(7 - dayOfWeek).ToShortDateString();
            var day1 = GetElementsByDateAndGroup(date.Date.AddDays(1 - dayOfWeek), classTimes);
            var day2 = GetElementsByDateAndGroup(date.Date.AddDays(2 - dayOfWeek), classTimes);
            var day3 = GetElementsByDateAndGroup(date.Date.AddDays(3 - dayOfWeek), classTimes);
            var day4 = GetElementsByDateAndGroup(date.Date.AddDays(4 - dayOfWeek), classTimes);
            var day5 = GetElementsByDateAndGroup(date.Date.AddDays(5 - dayOfWeek), classTimes);
            var day6 = GetElementsByDateAndGroup(date.Date.AddDays(6 - dayOfWeek), classTimes);
            var day7 = GetElementsByDateAndGroup(date.Date.AddDays(7 - dayOfWeek), classTimes);
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
            RefreshClassTimeTableElemInfo(elements);
        }

        private List<ClassTimeTableDayElem> GetElementsByDateAndGroup(DateTime date, IEnumerable<ClassTime> classTimes)
        {
            var classTimeTables = DatabaseManager.GetClassTimeTables();
            var group = (Group) uiGroupComboBox.SelectedItem;
            var classTimeTablesForDateAndGroup = classTimeTables.Where(c => c.Date.Date == date && c.Group.Id == group.Id);
            var elementsByDateAndGroup = (from c in classTimeTablesForDateAndGroup
                                          select new ClassTimeTableDayElem(
                                              "d: " + c.EducationalDiscipline.Name + " k: " + c.ClassRoom.Number +
                                              " p: " + c.Teacher.Name, c)).ToList();
            return GetVoidClassTimeTables(elementsByDateAndGroup, classTimes, date, group);
        }

        private List<ClassTimeTableDayElem> GetVoidClassTimeTables(List<ClassTimeTableDayElem> classTimeTableDayElems,
                                                                   IEnumerable<ClassTime> classTimes, DateTime date, Group group)
        {
            return
                classTimes.Select(classTime =>
                                  (classTimeTableDayElems.Any(
                                      c => c.ClassTimeTable.ClassTime.Id == classTime.Id)
                                       ? classTimeTableDayElems.First(c => c.ClassTimeTable.ClassTime.Id == classTime.Id)
                                       : new ClassTimeTableDayElem("-", new ClassTimeTable(group, date, classTime))
                                  )).ToList();
        }

        private void RefreshClassTimeTableElemInfo(List<ClassTimeTableWeekElem> elementsByDateAndGroup)
        {
            uiMainDataGridView.DataSource = elementsByDateAndGroup;
            var dataGridViewColumn2 = uiMainDataGridView.Columns["ClassTime"];
            if (dataGridViewColumn2 != null) dataGridViewColumn2.DisplayIndex = 0;
            uiMainDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
            var classTimeTableDayElem = (ClassTimeTableDayElem) uiMainDataGridView.SelectedCells[0].Value;
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
                if (f.ShowDialog() == DialogResult.OK)
                {
                    RefreshInfo();
                }
            }
        }

        private void uiMainDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!Globals.IsRootMode) return;
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && uiMainDataGridView.Columns[e.ColumnIndex].DisplayIndex > 0)
            {
                uiMainDataGridView[e.ColumnIndex, e.RowIndex].Selected = true;
                var a = uiMainDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true).Location;
                uiMenuContextMenuStrip.Show(uiMainDataGridView, a.X + e.X, a.Y + e.Y);
            }
        }
    }
}
