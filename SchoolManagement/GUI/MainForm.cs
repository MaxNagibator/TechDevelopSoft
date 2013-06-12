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

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (var f = new LoginForm())
            {
                f.ShowDialog();
            }
            SetVisible();
        }

        private void SetVisible()
        {
            uiClassRoomToolStripButton.Visible = Globals.IsRootMode;
            uiStudentsToolStripButton.Visible = Globals.IsRootMode;
            uiTeacherToolStripButton.Visible = Globals.IsRootMode;
            uiEducationalDisciplineToolStripButton.Visible = Globals.IsRootMode;
            uiGroupToolStripButton.Visible = Globals.IsRootMode;
            uiClassTimeToolStripButton.Visible = Globals.IsRootMode;
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
            using (var f = new EducationalDisciplinesForm())
            {
                f.ShowDialog();
            }
        }

        private void uiClassTimeToolStripButton_Click(object sender, EventArgs e)
        {
            using (var f = new ClassTimesForm())
            {
                f.ShowDialog();
            }
        }

        private void uiClassTimeTableToolStripButton_Click(object sender, EventArgs e)
        {
            using (var f = new ClassTimeTablesForm())
            {
                f.ShowDialog();
            }
        }
    }
}
