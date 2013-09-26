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
            ShowForm(new ClassRoomsForm());
        }

        private void ShowForm(Form form)
        {
            using (var f = form)
            {
                f.StartPosition = FormStartPosition.Manual;
                f.Location = new Point(Location.X, Location.Y);
                Hide();
                f.ShowDialog();
                Show();
            }
        }

        private void uTeacherToolStripButton_Click(object sender, EventArgs e)
        {
            ShowForm(new TeachersForm());
        }

        private void uiGroupToolStripButton_Click(object sender, EventArgs e)
        {
            ShowForm(new GroupsForm());
        }

        private void uiEducationalDisciplineToolStripButton_Click(object sender, EventArgs e)
        {
            ShowForm(new EducationalDisciplinesForm());
        }

        private void uiClassTimeToolStripButton_Click(object sender, EventArgs e)
        {
            ShowForm(new ClassTimesForm());
        }

        private void uiClassTimeTableToolStripButton_Click(object sender, EventArgs e)
        {
            ShowForm(new ClassTimeTablesForm());
        }
    }
}
