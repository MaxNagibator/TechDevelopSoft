using System;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement.GUI
{
    public partial class TeacherAddForm : Form
    {
        public TeacherAddForm()
        {
            InitializeComponent();
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
            var teacher = new Teacher(uiNameTextBox.Text, uiBirthDayDateTimePicker.Value,
                                      uiStartWorkDateDateTimePicker.Value);
            teacher.AddToDatabase();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
