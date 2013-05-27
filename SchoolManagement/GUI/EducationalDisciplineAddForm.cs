using System;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement.GUI
{
    public partial class EducationalDisciplineAddForm : Form
    {
        public EducationalDisciplineAddForm()
        {
            InitializeComponent();
        }

        private void uiCommintButton_Click(object sender, EventArgs e)
        {
            var teacher = new Teacher(uiNameTextBox.Text, uiBirthDayDateTimePicker.Value,
                                      uiStartWorkDateDateTimePicker.Value);
            teacher.AddToDatabase();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
