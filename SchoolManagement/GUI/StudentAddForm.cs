using System;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement.GUI
{
    public partial class StudentAddForm : Form
    {
        private Group _group;
        public StudentAddForm()
        {
            InitializeComponent();
        }

        private void uiCommintButton_Click(object sender, EventArgs e)
        {
            var student = new Student(uiNameTextBox.Text, uiBirthDayDateTimePicker.Value, uiCommentTextBox.Text,
                                       _group);
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
                    _group = f.SelectedGroup;
                    uiGroupTextBox.Text = _group.ToString();
                }
            }
        }
    }
}
