using System;
using System.Linq;
using System.Windows.Forms;
using SchoolManagement.School;

namespace SchoolManagement.GUI
{
    public partial class ClassTimeAddForm : Form
    {
        private int _id;
        public ClassTimeAddForm(int id)
        {
            InitializeComponent();
            _id = id;
            if (id != -1)
            {
                Text = "Редактирование времени урока";
                uiCommitButton.Text = "Изменить";
                var info = DatabaseManager.GetClassTimes();
                uiStartTimeTextBox.Text= info.First(i => i.Id == id).StartTime;
                uiEndTimeTextBox.Text = info.First(i => i.Id == id).EndTime;
                uiNumberTextBox.Text = info.First(i => i.Id == id).Number.ToString();
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
                    var classTime = new ClassTime(number, uiStartTimeTextBox.Text, uiEndTimeTextBox.Text); 
                    if (_id == -1)
                    {
                        classTime.AddToDatabase();
                    }
                    else
                    {
                        classTime.UpdateInDatabase(_id);
                    }
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
