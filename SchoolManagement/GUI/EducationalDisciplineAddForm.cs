using System;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement.GUI
{
    public partial class EducationalDisciplineAddForm : Form
    {
        public EducationalDisciplineAddForm()
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
                MessageBox.Show("Заполните пожалуйста название дисчиплины!", "Так не камильфо");
                return;
            }
            var educationalDiscipline = new EducationalDiscipline(uiNameTextBox.Text, uiDescriptionTextBox.Text);
            educationalDiscipline.AddToDatabase();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
