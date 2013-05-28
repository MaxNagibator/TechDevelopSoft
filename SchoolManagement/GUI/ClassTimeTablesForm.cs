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
            uiGroupComboBox.DataSource = DatabaseManager.GetGroups();
            uiGroupComboBox.DisplayMember = "Name";
            RefreshInfo();
        }

        private void RefreshInfo()
        {
            var classTimes = DatabaseManager.GetClassTimes();
            RefreshClassTimeInfo(classTimes);

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
                                     Day1 = day1[i],
                                     Day2 = day2[i],
                                     Day3 = day3[i],
                                     Day4 = day4[i],
                                     Day5 = day5[i],
                                     Day6 = day6[i],
                                     Day7 = day7[i],
                                 });
            }
            RefreshClassTimeTableElemInfo(uiMainDataGridView, elements);
        }

        private void RefreshClassTimeInfo(IEnumerable<ClassTime> classTimes)
        {
            var source = (from c in classTimes
                          select new {Time = c.Number + ": " + c.StartTime + "-" + c.EndTime}).ToArray();
            uiClassTimesDataGridView.DataSource = source;
        }

        private List<ClassTimeTableDayElem> GetElementsByDateAndGroup(DateTime date, IEnumerable<ClassTime> classTimes)
        {
            var classTimeTables = DatabaseManager.GetClassTimeTables();
            var group = ((Group) uiGroupComboBox.SelectedItem).Id;
            var classTimeTablesForDateAndGroup = classTimeTables.Where(c => c.Date.Date == date && c.Group.Id == group);
            var elementsByDateAndGroup = (from c in classTimeTablesForDateAndGroup
                                          select new ClassTimeTableDayElem(
                                              "d: " + c.EducationalDiscipline.Name + " k: " + c.ClassRoom.Number +
                                              " p: " + c.Teacher.Name,
                                              c.ClassTime.Id, c)).ToList();
            return GetVoidClassTimeTables(elementsByDateAndGroup, classTimes);
        }

        private List<ClassTimeTableDayElem> GetVoidClassTimeTables(List<ClassTimeTableDayElem> elementsByDateAndGroup,
                                                                   IEnumerable<ClassTime> classTimes)
        {
            foreach (var classTime in classTimes.Where(r => elementsByDateAndGroup.All(s => s.ClassTimeNumber != r.Id)))
            {
                elementsByDateAndGroup.Add(new ClassTimeTableDayElem("-", classTime.Id, null));
            }
            return elementsByDateAndGroup;
        }

        private void RefreshClassTimeTableElemInfo(DataGridView dataGridView,
                                                   List<ClassTimeTableWeekElem> elementsByDateAndGroup)
        {
            dataGridView.DataSource = elementsByDateAndGroup;
            var dataGridViewColumn = dataGridView.Columns["ClassTimeNumber"];
            if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
            var classTimeTableDayElem = (ClassTimeTableDayElem) uiMainDataGridView.SelectedCells[0].Value;
            var classTimeTable = classTimeTableDayElem.ClassTimeTable;
            RefreshInfo();
        }

        private void uiAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var classTimeTableDayElem = (ClassTimeTableDayElem)uiMainDataGridView.SelectedCells[0].Value;
            var classTimeTable = classTimeTableDayElem.ClassTimeTable;
            using (var f = new ClassTimeTableAddForm(classTimeTable))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    RefreshInfo();
                }
            }
            RefreshInfo();
        }
    }
}
