using System;
using System.Windows.Forms;

namespace SchoolManagement.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void UIQuestionnaireServerMainForm_Load(object sender, EventArgs e)
        {
        }

        private void uiStudentsToolStripButton_Click(object sender, EventArgs e)
        {
            using (var f = new StudentsForm())
            {
                f.ShowDialog();
            }
        }

        private void uiClassRoomToolStripButton_Click(object sender, EventArgs e)
        {
            using (var f = new ClassRoomsForm())
            {
                f.ShowDialog();
            }
        }

        private void uTeacherToolStripButton_Click(object sender, EventArgs e)
        {
            using (var f = new TeachersForm())
            {
                f.ShowDialog();
            }
        }

        private void uiGroupToolStripButton_Click(object sender, EventArgs e)
        {
            using (var f = new GroupsForm())
            {
                f.ShowDialog();
            }
        }

        private void uiEducationalDisciplineToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
