using System;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent();
            RefreshStudents();
        }

        private void RefreshStudents()
        {
            var students = DatabaseManager.GetStudents();
            uiStudentsDataGridView.DataSource = students;
        }

        private void uiAddStudentButton_Click(object sender, EventArgs e)
        {
            using (var f = new StudentAddForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    RefreshStudents();
                }
            }
        }
    }
}
