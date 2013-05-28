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

        private void uiCommintButton_Click(object sender, EventArgs e)
        {
            var group = new ClassTime(uiNameTextBox.Text, Convert.ToInt32(uiNumberTextBox.Text), uiStartTimeTextBox.Text,
                                      uiEndTimeTextBox.Text);
            group.AddToDatabase();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
