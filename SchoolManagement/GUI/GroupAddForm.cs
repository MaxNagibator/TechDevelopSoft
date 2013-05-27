using System;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement
{
    public partial class GroupAddForm : Form
    {
        public GroupAddForm()
        {
            InitializeComponent();
        }

        private void uiCommintButton_Click(object sender, EventArgs e)
        {
            var group = new Group(uiNameTextBox.Text, uiCommentTextBox.Text);
            group.AddToDatabase();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
