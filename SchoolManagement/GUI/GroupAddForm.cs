using System;
using System.Linq;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement.GUI
{
    public partial class GroupAddForm : Form
    {
        private int _id;
        public GroupAddForm(int id)
        {
            InitializeComponent();
            _id = id;
            if (id != -1)
            {
                var info = DatabaseManager.GetGroups();
                uiNameTextBox.Text = info.First(i => i.Id == id).Name;
                uiCommentTextBox.Text = info.First(i => i.Id == id).Comment;
            }
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
            if (_id == -1)
            {
                group.AddToDatabase();
            }
            else
            {
                group.UpdateInDatabase(_id);
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
