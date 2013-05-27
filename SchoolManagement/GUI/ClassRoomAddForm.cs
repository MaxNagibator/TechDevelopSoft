using System;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement
{
    public partial class ClassRoomAddForm : Form
    {
        public ClassRoomAddForm()
        {
            InitializeComponent();
        }

        private void uiCommintButton_Click(object sender, EventArgs e)
        {
            var group = new ClassRoom(uiNameTextBox.Text, uiNumberTextBox.Text);
            group.AddToDatabase();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
