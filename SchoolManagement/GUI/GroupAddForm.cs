using System;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement.GUI
{
    public partial class GroupAddForm : Form
    {
        public GroupAddForm()
        {
            InitializeComponent();
        }

        private void uiCommitButton_Click(object sender, EventArgs e)
        {
            Commit();
        }

        private void uiTextBoxs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Commit();
            }
        }

        private void Commit()
        {
            if (String.IsNullOrWhiteSpace(uiNameTextBox.Text))
            {
                MessageBox.Show("Заполните пожалуйста название класса!", "Так не камильфо");
                return;
            }
            var group = new Group(uiNameTextBox.Text, uiCommentTextBox.Text);
            group.AddToDatabase();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
