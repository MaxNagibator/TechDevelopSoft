using System;
using System.Drawing;
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
            // няняня пусто :)
        }

        private void uiClassRoomToolStripButton_Click(object sender, EventArgs e)
        {
            using (var f = new ClassRoomsForm())
            {
                f.StartPosition = FormStartPosition.Manual;
                f.Location = new Point(Location.X,Location.Y);
                f.ShowDialog();
            }
        }

        private void uTeacherToolStripButton_Click(object sender, EventArgs e)
        {
            using (var f = new TeachersForm())
            {
                f.StartPosition = FormStartPosition.Manual;
                f.Location = new Point(Location.X, Location.Y);
                f.ShowDialog();
            }
        }

        private void uiGroupToolStripButton_Click(object sender, EventArgs e)
        {
            using (var f = new GroupsForm())
            {
                f.StartPosition = FormStartPosition.Manual;
                f.Location = new Point(Location.X, Location.Y);
                f.ShowDialog();
            }
        }

        private void uiEducationalDisciplineToolStripButton_Click(object sender, EventArgs e)
        {
            using (var f = new EducationalDisciplinesForm())
            {
                f.StartPosition = FormStartPosition.Manual;
                f.Location = new Point(Location.X, Location.Y);
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
