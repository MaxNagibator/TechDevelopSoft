using System;
using System.Windows.Forms;

namespace SchoolManagement.GUI
{
    public partial class TeachersForm : Form
    {
        public TeachersForm()
        {
            InitializeComponent();
            RefreshTeachers();
        }

        private void RefreshTeachers()
        {
            var teachers = DatabaseManager.GetTeachers();
            uiTeachersDataGridView.DataSource = teachers;
        }

        private void uiAddTeacherButton_Click(object sender, EventArgs e)
        {
            using (var f = new TeacherAddForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    RefreshTeachers();
                }
            }
        }
    }
}
