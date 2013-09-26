using System;
using System.Drawing;
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
            if (IsEditMode)
            {
                uiDateDateTimePicker.Enabled = false;
                uiSelectClassTimeButton.Enabled = false;
                uiClassTimeСomboBox.Enabled = false;
                uiSelectGroupButton.Enabled = false;
                uiGroupComboBox.Enabled = false;
            }
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
            if (_classTimeTable.Teacher != null)
            {
                uiTeacherComboBox.SelectedIndex = uiTeacherComboBox.FindStringExact(_classTimeTable.Teacher.ToString());
            }
            else
            {
                uiTeacherComboBox.SelectedIndex = -1;
            }
        }

        private void RefreshEducationalDisciplines()
        {
            uiEducationalDisciplineСomboBox.DataSource = DatabaseManager.GetEducationalDisciplines();
            if (_classTimeTable.EducationalDiscipline != null)
            {
                uiEducationalDisciplineСomboBox.SelectedIndex =
                      uiEducationalDisciplineСomboBox.FindStringExact(_classTimeTable.EducationalDiscipline.ToString());
            }
            else
            {
                uiEducationalDisciplineСomboBox.SelectedIndex = -1;
            }
        }

        private void RefreshGroups()
        {
            uiGroupComboBox.DataSource = DatabaseManager.GetGroups(); 
            if (_classTimeTable.Group != null)
            {
                uiGroupComboBox.SelectedIndex = uiGroupComboBox.FindStringExact(_classTimeTable.Group.ToString());
            }
            else
            {
                uiGroupComboBox.SelectedIndex = -1;
            }
        }

        private void RefreshClassRooms()
        {
            uiClassRoomComboBox.DataSource = DatabaseManager.GetClassRooms();
            if (_classTimeTable.ClassRoom != null)
            {
                uiClassRoomComboBox.SelectedIndex =
                    uiClassRoomComboBox.FindStringExact(_classTimeTable.ClassRoom.ToString());
            }
            else
            {
                uiClassRoomComboBox.SelectedIndex = -1;
            }
        }

        private void RefreshClassTimes()
        {
            uiClassTimeСomboBox.DataSource = DatabaseManager.GetClassTimes();
            if (_classTimeTable.ClassTime != null)
            {
                uiClassTimeСomboBox.SelectedIndex =
                    uiClassTimeСomboBox.FindStringExact(_classTimeTable.ClassTime.ToString());
            }
            else
            {
                uiClassTimeСomboBox.SelectedIndex = -1;
            }
        }

        private void uiCommintButton_Click(object sender, EventArgs e)
        {

            _classTimeTable.Date = uiDateDateTimePicker.Value;
            _classTimeTable.ClassTime = (ClassTime)uiClassTimeСomboBox.SelectedItem;
            _classTimeTable.ClassRoom = (ClassRoom)uiClassRoomComboBox.SelectedItem;
            _classTimeTable.EducationalDiscipline = (EducationalDiscipline)uiEducationalDisciplineСomboBox.SelectedItem;
            _classTimeTable.Group = (Group)uiGroupComboBox.SelectedItem;
            _classTimeTable.Teacher = (Teacher)uiTeacherComboBox.SelectedItem;
            var classTimeTable = _classTimeTable;
            var message = CheckFillFields();
            if (message == "")
            {
                DatabaseManager.DeleteClassTimeTableById(classTimeTable.Id);
                classTimeTable.AddToDatabase();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(message, "Будьте внимательнее");
            }
        }

        private string CheckFillFields()
        {
            var message = "";
            if (_classTimeTable.EducationalDiscipline == null)
            {
                message += "дисциплину";
            }
            if (_classTimeTable.Teacher == null)
            {
                if (message != "")
                {
                    message += ", ";
                } 
                message += "учителя";
            } 
            if (_classTimeTable.ClassRoom == null)
            {
                if (message != "")
                {
                    message += ", ";
                } 
                message += "кабинет";
            }
            if (message != "")
            {
                message = "Нужно выбрать " + message + "!";
            }
            return message;
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
            RefreshClassTimes();
        }

        private void uiSelectEducationalDisciplineButton_Click(object sender, EventArgs e)
        {
            using (var f = new EducationalDisciplinesForm())
            {
                f.StartPosition = FormStartPosition.Manual;
                f.Location = new Point(Location.X, Location.Y);
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
           RefreshEducationalDisciplines();
        }

        private void uiSelectTeacherButton_Click(object sender, EventArgs e)
        {
            using (var f = new TeachersForm())
            {
                f.StartPosition = FormStartPosition.Manual;
                f.Location = new Point(Location.X, Location.Y);
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
            RefreshTeachers();
        }

        private void uiSelectClassRoomButton_Click(object sender, EventArgs e)
        {
            using (var f = new ClassRoomsForm())
            {
                f.StartPosition = FormStartPosition.Manual;
                f.Location = new Point(Location.X, Location.Y);
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
            RefreshClassRooms();
        }

        private void uiSelectGroupButton_Click(object sender, EventArgs e)
        {
            using (var f = new GroupsForm())
            {
                f.StartPosition = FormStartPosition.Manual;
                f.Location = new Point(Location.X, Location.Y);
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
            RefreshGroups();
        }
    }
}
