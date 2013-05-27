using System;
using System.Windows.Forms;

namespace SchoolManagement.GUI
{
    public partial class ClassRoomsForm : Form
    {
        public ClassRoomsForm()
        {
            InitializeComponent();
            RefreshClassRoom();
        }

        private void RefreshClassRoom()
        {
            var classRooms = DatabaseManager.GetClassRooms();
            uiStudentsDataGridView.DataSource = classRooms;
        }

        private void uiAddStudentButton_Click(object sender, EventArgs e)
        {
            using (var f = new ClassRoomAddForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    RefreshClassRoom();
                }
            }
        }
    }
}
