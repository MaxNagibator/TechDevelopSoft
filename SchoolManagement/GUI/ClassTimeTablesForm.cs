using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement.GUI
{
    public partial class ClassTimeTablesForm : Form
    {
        private int _row;
        private int _column;

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
                                     Day1 = day1[i].Text,
                                     ClassTimeTable1 = day1[i].ClassTimeTable,
                                     Day2 = day2[i].Text,
                                     ClassTimeTable2 = day2[i].ClassTimeTable,
                                     Day3 = day3[i].Text,
                                     ClassTimeTable3 = day3[i].ClassTimeTable,
                                     Day4 = day4[i].Text,
                                     ClassTimeTable4 = day4[i].ClassTimeTable,
                                     Day5 = day5[i].Text,
                                     ClassTimeTable5 = day5[i].ClassTimeTable,
                                     Day6 = day6[i].Text,
                                     ClassTimeTable6 = day6[i].ClassTimeTable,
                                     Day7 = day7[i].Text,
                                     ClassTimeTable7 = day7[i].ClassTimeTable,
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
            dataGridView.DataMember = "";
            var dataGridViewColumn = dataGridView.Columns["ClassTimeNumber"];
            if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void uiAddButton_Click(object sender, EventArgs e)
        {
            using (var f = new ClassTimeAddForm())
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

        private void uiMainDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                _row = e.RowIndex;
                _column = e.ColumnIndex;
                var a = uiMainDataGridView[_column, _row].Value;
                contextMenuStrip1.Show();
            }
        }

        private void uiDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_row.ToString());

            RefreshInfo();
        }

        private void uiAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_column.ToString());

            RefreshInfo();
        }
    }
}
