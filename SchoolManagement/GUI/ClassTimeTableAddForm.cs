using System;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement.GUI
{
    public partial class ClassTimeTableAddForm : Form
    {
        private ClassTimeTable _classTimeTable;
        private Group _selectedGroup;
        private ClassRoom _selectedClassRoom;
        private Teacher _selectedTeacher;
        private EducationalDiscipline _educationalDiscipline;
        private ClassTime _classTime;

        public ClassTimeTableAddForm()
        {
            InitializeComponent();
        }

        public ClassTimeTableAddForm(ClassTimeTable classTimeTable)
        {
            InitializeComponent();
            _classTimeTable = classTimeTable;
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
                    _classTime = f.SelectedClassTime;
                    uiClassRoomTextBox.Text = _classTime.ToString();
                }
            }
        }

        private void uiSelectEducationalDisciplineButton_Click(object sender, EventArgs e)
        {
            using (var f = new EducationalDisciplinesForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _educationalDiscipline = f.SelectedEducationalDiscipline;
                    uiClassRoomTextBox.Text = _educationalDiscipline.ToString();
                }
            }
        }

        private void uiSelectTeacherButton_Click(object sender, EventArgs e)
        {
            using (var f = new TeachersForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _selectedTeacher = f.SelectedTeacher;
                    uiTeacherTextBox.Text = _selectedTeacher.ToString();
                }
            }
        }

        private void uiSelectClassRoomButton_Click(object sender, EventArgs e)
        {
            using (var f = new ClassRoomsForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _selectedClassRoom = f.SelectedClassRoom;
                    uiClassRoomTextBox.Text = _selectedClassRoom.ToString();
                }
            }
        }

        private void uiSelectGroupButton_Click(object sender, EventArgs e)
        {
            using (var f = new GroupsForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _selectedGroup = f.SelectedGroup;
                    uiGroupTextBox.Text = _selectedGroup.ToString();
                }
            }
        }
    }
}
