using System;
using System.Windows.Forms;

namespace SchoolManagement.GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void uiLoginButton_Click(object sender, EventArgs e)
        {
            CheckLogin();
        }

        private void CheckLogin()
        {
            if (uiLoginTextBox.Text == Globals.LocalSettings.RootLogin && uiPasswordTextBox.Text == Globals.LocalSettings.RootPass)
            {
                Globals.IsRootMode = true;
                Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка");
            }
        }

        private void uiOnlyReadButton_Click(object sender, EventArgs e)
        {
            Globals.IsRootMode = false;
            Close();
        }

        private void uiPasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckLogin();
            }
        }
    }
}
