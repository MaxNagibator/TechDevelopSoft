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
            var elements = new List<ClassTimeTableWeekElem>();
            for (var i = 0; i < classTimes.Count; i++)
            {
                elements.Add(new ClassTimeTableWeekElem
                                 {
                                     ClassTime = classTimes[i],
                                     Day1 = day1[i],
                                     Day2 = day2[i],
                                     Day3 = day3[i],
                                     Day4 = day4[i],
                                     Day5 = day5[i],
                                     Day6 = day6[i],
                                     Day7 = day7[i],
                                 });
            }
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
                                              " p: " + c.Teacher.Name,
                                              c.ClassTime, c)).ToList();
            return GetVoidClassTimeTables(elementsByDateAndGroup, classTimes, date, group);
        }

        private List<ClassTimeTableDayElem> GetVoidClassTimeTables(List<ClassTimeTableDayElem> classTimeTableDayElems,
                                                                   IEnumerable<ClassTime> classTimes, DateTime date, Group group)
        {
            foreach (
                var classTime in classTimes.Where(r => classTimeTableDayElems.All(s => s.ClassTime.Id != r.Id)))
            {
                classTimeTableDayElems.Add(new ClassTimeTableDayElem("-", classTime, new ClassTimeTable(group, date)));
            }

            return classTimeTableDayElems;
        }

        private void RefreshClassTimeTableElemInfo(List<ClassTimeTableWeekElem> elementsByDateAndGroup)
        {
            uiMainDataGridView.DataSource = elementsByDateAndGroup;
            var dataGridViewColumn2 = uiMainDataGridView.Columns["ClassTime"];
            if (dataGridViewColumn2 != null) dataGridViewColumn2.DisplayIndex = 0;
            uiMainDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void uiDeleteButton_Click(object sender, EventArgs e)
        {
            if (uiMainDataGridView.SelectedRows.Count <= 0) return;
            if (uiMainDataGridView.SelectedRows[0].Cells["Id"].Value != null)
            {
                var selectedId = Convert.ToInt32(uiMainDataGridView.SelectedRows[0].Cells["Id"].Value);
                DatabaseManager.DeleteClassTimeById(selectedId);
                RefreshInfo();
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
            //var classTimeTableDayElem = (ClassTimeTableDayElem) uiMainDataGridView.SelectedCells[0].Value;
            //var classTimeTable = classTimeTableDayElem.ClassTimeTable;
            //RefreshInfo();
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

        private void uiMenuContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void uiMainDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            uiMenuContextMenuStrip.Show(e.X,e.Y);
        }
    }
}
