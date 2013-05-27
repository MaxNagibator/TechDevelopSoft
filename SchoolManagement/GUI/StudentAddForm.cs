using System;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement
{
    public partial class StudentAddForm : Form
    {
        public StudentAddForm()
        {
            InitializeComponent();
        }

        private void uiCommintButton_Click(object sender, EventArgs e)
        {
            var student = new Student(uiNameTextBox.Text, uiBirthDayDateTimePicker.Value, uiCommentTextBox.Text,
                                       new Group(Convert.ToInt16(uiGroupTextBox.Text)));
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
                    uiGroupTextBox.Text = f.SelectedId.ToString();
                }
            }
        }
    }
}
