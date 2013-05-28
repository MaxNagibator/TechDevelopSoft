using System;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement.GUI
{
    public partial class ClassTimeTableAddForm : Form
    {
        private ClassTimeTable _classTimeTable;

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
            var classTimeTable = _classTimeTable;
            classTimeTable.AddToDatabase();
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
            _classTimeTable.ClassTime = selectedClassTime;
            uiClassTimeTextBox.Text = _classTimeTable.ClassTime.ToString();
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
            _classTimeTable.EducationalDiscipline = selectedEducationalDiscipline;
            uiEducationalDisciplineTextBox.Text = _classTimeTable.EducationalDiscipline.ToString();
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
            _classTimeTable.Teacher = selectedTeacher;
            uiTeacherTextBox.Text = _classTimeTable.Teacher.ToString();
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
            _classTimeTable.ClassRoom = selectedClassRoom;
            uiClassRoomTextBox.Text = _classTimeTable.ClassRoom.ToString();
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
            _classTimeTable.Group = selectedGroup;
            uiGroupTextBox.Text = _classTimeTable.Group.ToString();
        }

        private void uiDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _classTimeTable.Date = uiDateDateTimePicker.Value;
        }

        private void SetDate(DateTime date)
        {
            _classTimeTable.Date = date;
            uiDateDateTimePicker.Value = _classTimeTable.Date;
        }
    }
}
