using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class ChildForm : Form
    {
        Student clsStudent = new Student();

        public ChildForm(Student student)
        {
            InitializeComponent();

            clsStudent = student;

            inputId.Text = student.ID.ToString();
            inputFirstName.Text = student.FirstName.ToString();
            inputLastName.Text = student.LastName.ToString();
            inputMajor.Text = student.Major.ToString();

        }

        private void ChildForm_Load(object sender, EventArgs e)
        {

        }

        private void inputId_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelId_Click(object sender, EventArgs e)
        {

        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void inputFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelLastName_Click(object sender, EventArgs e)
        {

        }

        private void labelMajor_Click(object sender, EventArgs e)
        {

        }

        private void inputMajor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
