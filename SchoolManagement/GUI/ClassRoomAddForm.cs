using System;
using System.Linq;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement.GUI
{
    public partial class ClassRoomAddForm : Form
    {
        private int _id;
        public ClassRoomAddForm(int id)
        {
            InitializeComponent();
            _id = id;
            if (id != -1)
            {
                Text = "Редактирование кабинета";
                uiCommitButton.Text = "Изменить";
                var info = DatabaseManager.GetClassRooms();
                uiNameTextBox.Text = info.First(i => i.Id == id).Name;
                uiNumberTextBox.Text = info.First(i => i.Id == id).Number;
            }
        }

        private void uiCommintButton_Click(object sender, EventArgs e)
        {
            Commit();
        }

        private void Commit()
        {
            if (String.IsNullOrWhiteSpace(uiNumberTextBox.Text))
            {
                MessageBox.Show("Заполните пожалуйста номер кабинета!", "Так не камильфо");
                return;
            }
            var group = new ClassRoom(uiNameTextBox.Text, uiNumberTextBox.Text);
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

        private void uiTextBoxs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Commit();
            }
        }
    }
}
