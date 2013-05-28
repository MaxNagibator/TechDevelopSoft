using System;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement.GUI
{
    public partial class StudentAddForm : Form
    {
        private Group _selectedGroup;
        public StudentAddForm()
        {
            InitializeComponent();
        }

        private void uiCommintButton_Click(object sender, EventArgs e)
        {
            var student = new Student(uiNameTextBox.Text, uiBirthDayDateTimePicker.Value, uiCommentTextBox.Text,
                                       _selectedGroup);
            student.AddToDatabase();
            DialogResult = DialogResult.OK;
            Close();
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
