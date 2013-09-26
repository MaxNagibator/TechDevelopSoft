using System;
using System.Linq;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement.GUI
{
    public partial class EducationalDisciplineAddForm : Form
    {
        private int _id;
        public EducationalDisciplineAddForm(int id)
        {
            InitializeComponent();
            _id = id;
            if (id != -1)
            {
                Text = "Редактирование дисциплины";
                uiCommitButton.Text = "Изменить";
                var info = DatabaseManager.GetEducationalDisciplines();
                uiNameTextBox.Text = info.First(i => i.Id == id).Name;
                uiDescriptionTextBox.Text = info.First(i => i.Id == id).Description;
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
                MessageBox.Show("Заполните пожалуйста название дисчиплины!", "Так не камильфо");
                return;
            }
            var educationalDiscipline = new EducationalDiscipline(uiNameTextBox.Text, uiDescriptionTextBox.Text);
            if (_id == -1)
            {
                educationalDiscipline.AddToDatabase();
            }
            else
            {
                educationalDiscipline.UpdateInDatabase(_id);
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
