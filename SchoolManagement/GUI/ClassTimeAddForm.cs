using System;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement.GUI
{
    public partial class ClassTimeAddForm : Form
    {
        public ClassTimeAddForm()
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
            int number = -217;
            try
            {
                number = Convert.ToInt32(uiNumberTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Заполните пожалуйста номер урока числовым значением!", "Так не камильфо");
            }

            if (number != -217)
            {
                try
                {
                    var group = new ClassTime(number, uiStartTimeTextBox.Text, uiEndTimeTextBox.Text);
                    group.AddToDatabase();
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Номер урока должен быть уникальным!", "Так не камильфо");
                }
            }
        }
    }
}
