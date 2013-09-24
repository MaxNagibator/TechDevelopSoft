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
                using (var f = new MainForm())
                {
                    Globals.IsRootMode = true;
                    Hide();
                    f.ShowDialog();
                    uiPasswordTextBox.Text = "";
                    Show();
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка авторизации");
            }
        }

        private void uiOnlyReadButton_Click(object sender, EventArgs e)
        {
            using(var f = new ClassTimeTablesForm())
            {
                Globals.IsRootMode = false;
                Hide();
                f.ShowDialog();
                Show();
            }
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
