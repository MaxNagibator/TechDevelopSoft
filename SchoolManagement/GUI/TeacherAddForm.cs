using System;
using System.Linq;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement.GUI
{
    public partial class TeacherAddForm : Form
    {
        private int _id;
        public TeacherAddForm(int id)
        {
            InitializeComponent();
            _id = id;
            if (id != -1)
            {
                var info = DatabaseManager.GetTeachers();
                uiNameTextBox.Text = info.First(i => i.Id == id).Name;
                uiBirthDayDateTimePicker.Value = info.First(i => i.Id == id).BirthDay;
                uiStartWorkDateDateTimePicker.Value = info.First(i => i.Id == id).StartWorkDate;
            }
        }
        private void uiCommitButton_Click(object sender, EventArgs e)
        {
            Commit();
        }

        private void uiNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Commit();
            }
        }

        private void Commit()
        {
            if (String.IsNullOrWhiteSpace(uiNameTextBox.Text))
            {
                MessageBox.Show("Заполните пожалуйста ФИО учителя!", "Так не камильфо");
                return;
            }
            var teacher = new Teacher(uiNameTextBox.Text, uiBirthDayDateTimePicker.Value,
                                      uiStartWorkDateDateTimePicker.Value);
            if (_id == -1)
            {
                teacher.AddToDatabase();
            }
            else
            {
                teacher.UpdateInDatabase(_id);
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
