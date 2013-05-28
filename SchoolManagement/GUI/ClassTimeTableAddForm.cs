using System;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement.GUI
{
    public partial class ClassTimeTableAddForm : Form
    {
        private ClassTimeTable _classTimeTable;
        private DateTime _selectedDate;
        private Group _selectedGroup;
        private ClassRoom _selectedClassRoom;
        private Teacher _selectedTeacher;
        private EducationalDiscipline _selectedEducationalDiscipline;
        private ClassTime _classTime;

        public ClassTimeTableAddForm()
        {
            InitializeComponent();
        }

        public ClassTimeTableAddForm(ClassTimeTable classTimeTable)
        {
            InitializeComponent();
            _classTimeTable = classTimeTable;
            LoadInfo();
        }

        private void LoadInfo()
        {
            SetGroup(_classTimeTable.Group);
            SetDate(_classTimeTable.Date);
        }

        private void uiCommintButton_Click(object sender, EventArgs e)
        {
           // var group = new ClassTime(uiNameTextBox.Text, Convert.ToInt32(uiClassTimeTextBox.Text), uiDisciplineTextBox.Text,
            //                          uiEndTimeTextBox.Text);
          //  group.AddToDatabase();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void uiSelectClassTimeButton_Click(object sender, EventArgs e)
        {
            using (var f = new ClassTimesForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    SetClassTime(f.SelectedClassTime);
                }
            }
        }

        private void SetClassTime(ClassTime selectedClassTime)
        {
            _classTime = selectedClassTime;
            uiClassTimeTextBox.Text = _classTime.ToString();
        }

        private void uiSelectEducationalDisciplineButton_Click(object sender, EventArgs e)
        {
            using (var f = new EducationalDisciplinesForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    SetEducationalDiscipline(f.SelectedEducationalDiscipline);
                }
            }
        }

        private void SetEducationalDiscipline(EducationalDiscipline selectedEducationalDiscipline)
        {
            _selectedEducationalDiscipline = selectedEducationalDiscipline;
            uiEducationalDisciplineTextBox.Text = _selectedEducationalDiscipline.ToString();
        }

        private void uiSelectTeacherButton_Click(object sender, EventArgs e)
        {
            using (var f = new TeachersForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    SetTeacher( f.SelectedTeacher);
                }
            }
        }

        private void SetTeacher(Teacher selectedTeacher)
        {
            _selectedTeacher = selectedTeacher;
            uiTeacherTextBox.Text = _selectedTeacher.ToString();
        }

        private void uiSelectClassRoomButton_Click(object sender, EventArgs e)
        {
            using (var f = new ClassRoomsForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    SetClassRoom(f.SelectedClassRoom);
                }
            }
        }

        private void SetClassRoom(ClassRoom selectedClassRoom)
        {
            _selectedClassRoom = selectedClassRoom;
            uiTeacherTextBox.Text = _selectedClassRoom.ToString();
        }

        private void uiSelectGroupButton_Click(object sender, EventArgs e)
        {
            using (var f = new GroupsForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    SetGroup(f.SelectedGroup);
                }
            }
        }

        private void SetGroup(Group selectedGroup)
        {
            _selectedGroup = selectedGroup;
            uiTeacherTextBox.Text = _selectedGroup.ToString();
        }

        private void uiDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _selectedDate = uiDateDateTimePicker.Value;
        }

        private void SetDate(DateTime date)
        {
            _selectedDate = date;
            uiTeacherTextBox.Text = _selectedDate.ToString();
        }
    }
}
