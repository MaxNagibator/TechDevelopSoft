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

        }

        private void uiSelectDisciplineButton_Click(object sender, EventArgs e)
        {

        }

        private void uiSelectTeacherButton_Click(object sender, EventArgs e)
        {

        }

        private void uiSelectClassRoomButton_Click(object sender, EventArgs e)
        {

        }

        private void uiSelectGroupButton_Click(object sender, EventArgs e)
        {
            
            using (var f = new GroupsForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    uiGroupTextBox.Text = f.SelectedGroup.ToString();
                }
            }
        }
    }
}
