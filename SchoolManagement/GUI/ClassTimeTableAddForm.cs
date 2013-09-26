using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement.GUI
{
    public partial class ClassTimeTableAddForm : Form
    {
        public bool IsEditMode { get; set; }
        private ClassTimeTable _classTimeTable;

        public ClassTimeTableAddForm()
        {
            InitializeComponent();
        }

        public ClassTimeTableAddForm(ClassTimeTable classTimeTable)
        {
            InitializeComponent();
            _classTimeTable = classTimeTable;
        }

        private void ClassTimeTableAddForm_Load(object sender, EventArgs e)
        {
            SetInformation();
            RefreshDataComboBoxs();
        }

        private void SetInformation()
        {
            Text = IsEditMode ? "Редактирование элемента расписания" : "Добавление элемента расписания";
        }

        private void RefreshDataComboBoxs()
        {
            RefreshTeachers();
            RefreshEducationalDisciplines();
            RefreshGroups();
            RefreshClassRooms();
            RefreshClassTimes();
            uiDateDateTimePicker.Value = _classTimeTable.Date;
        }

        private void RefreshTeachers()
        {
            uiTeacherComboBox.DataSource = DatabaseManager.GetTeachers(); 
            uiTeacherComboBox.SelectedIndex = uiTeacherComboBox.FindStringExact(_classTimeTable.Teacher.ToString());
        }

        private void RefreshEducationalDisciplines()
        {
            uiEducationalDisciplineСomboBox.DataSource = DatabaseManager.GetEducationalDisciplines();
            uiEducationalDisciplineСomboBox.SelectedIndex =
                  uiEducationalDisciplineСomboBox.FindStringExact(_classTimeTable.EducationalDiscipline.ToString());
        }

        private void RefreshGroups()
        {
            uiGroupComboBox.DataSource = DatabaseManager.GetGroups();
            uiGroupComboBox.SelectedIndex = uiGroupComboBox.FindStringExact(_classTimeTable.Group.ToString());
        }

        private void RefreshClassRooms()
        {
            uiClassRoomComboBox.DataSource = DatabaseManager.GetClassRooms();
            uiClassRoomComboBox.SelectedIndex = uiClassRoomComboBox.FindStringExact(_classTimeTable.ClassRoom.ToString());
        }

        private void RefreshClassTimes()
        {
            uiClassTimeСomboBox.DataSource = DatabaseManager.GetClassTimes();
            uiClassTimeСomboBox.SelectedIndex = uiClassTimeСomboBox.FindStringExact(_classTimeTable.ClassTime.ToString());
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
                f.StartPosition = FormStartPosition.Manual;
                f.Location = new Point(Location.X, Location.Y);
                f.IsSelectedMode = true;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    SetClassTime(f.SelectedClassTime);
                }
            }
        }

        private void SetClassTime(ClassTime selectedClassTime)
        {
            _classTimeTable.ClassTime = selectedClassTime;
            RefreshDataComboBoxs();
        }

        private void uiSelectEducationalDisciplineButton_Click(object sender, EventArgs e)
        {
            using (var f = new EducationalDisciplinesForm())
            {
                f.IsSelectedMode = true;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    SetEducationalDiscipline(f.SelectedEducationalDiscipline);
                }
            }
        }

        private void SetEducationalDiscipline(EducationalDiscipline selectedEducationalDiscipline)
        {
            _classTimeTable.EducationalDiscipline = selectedEducationalDiscipline;
           // uiEducationalDisciplineTextBox.Text = _classTimeTable.EducationalDiscipline.ToString();
        }

        private void uiSelectTeacherButton_Click(object sender, EventArgs e)
        {
            using (var f = new TeachersForm())
            {
                f.IsSelectedMode = true;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    SetTeacher( f.SelectedTeacher);
                }
            }
        }

        private void SetTeacher(Teacher selectedTeacher)
        {
            _classTimeTable.Teacher = selectedTeacher;
            //uiTeacherTextBox.Text = _classTimeTable.Teacher.ToString();
        }

        private void uiSelectClassRoomButton_Click(object sender, EventArgs e)
        {
            using (var f = new ClassRoomsForm())
            {
                f.IsSelectedMode = true;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    SetClassRoom(f.SelectedClassRoom);
                }
            }
        }

        private void SetClassRoom(ClassRoom selectedClassRoom)
        {
            _classTimeTable.ClassRoom = selectedClassRoom;
            //uiClassRoomTextBox.Text = _classTimeTable.ClassRoom.ToString();
        }

        private void uiSelectGroupButton_Click(object sender, EventArgs e)
        {
            using (var f = new GroupsForm())
            {
                f.IsSelectedMode = true;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    SetGroup(f.SelectedGroup);
                }
            }
        }

        private void SetGroup(Group selectedGroup)
        {
            _classTimeTable.Group = selectedGroup;
            //uiGroupTextBox.Text = _classTimeTable.Group.ToString();
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
