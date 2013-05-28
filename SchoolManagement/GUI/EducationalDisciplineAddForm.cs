﻿using System;
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

        private void uiCommintButton_Click(object sender, EventArgs e)
        {
            var educationalDiscipline = new EducationalDiscipline(uiNameTextBox.Text, uiDescriptionTextBox.Text);
            educationalDiscipline.AddToDatabase();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
