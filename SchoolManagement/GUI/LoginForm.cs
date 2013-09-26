using System;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolManagement.GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //ForDevelop();
        }

        private void ForDevelop()
        {
            using (var f = new MainForm())
            {
                Globals.IsRootMode = true;
                Hide();
                f.StartPosition = FormStartPosition.Manual;
                f.Location = new Point(500, 300);
                f.ShowDialog();
                Location = new Point(f.Location.X, f.Location.Y);
                uiPasswordTextBox.Text = "";
            }
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
                    f.StartPosition = FormStartPosition.Manual;
                    f.Location = new Point(Location.X, Location.Y);
                    f.ShowDialog();
                    Location = new Point(f.Location.X, f.Location.Y);
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
                f.StartPosition = FormStartPosition.Manual;
                f.Location = new Point(Location.X, Location.Y);
                Hide();
                f.ShowDialog();
                Location = new Point(f.Location.X, f.Location.Y);
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
