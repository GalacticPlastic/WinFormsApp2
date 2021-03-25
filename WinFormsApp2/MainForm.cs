using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class MainForm : Form
    {
        Student student = new Student();

        public MainForm()
        {
            InitializeComponent();

            /* student.ID = 100;
             student.FirstName = "Mary";
             student.LastName = "Kniffin";
             student.Major = "Computer Engineering";*/
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>();

            student.ID = int.Parse(inputId.Text);
            student.FirstName = inputFirstName.Text;
            student.LastName = inputLastName.Text;
            student.Major = inputMajor.Text;

            /*students.Add(student);
            inputId.Text = student.ID;
            inputFirstName.Text = student.FirstName;
            inputLastName.Text = student.LastName;
            inputMajor.Text = student.Major;*/

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UnderGraduateForm ugForm = new UnderGraduateForm();
            ugForm.ShowDialog();
            inputYear.Text = ugForm.GetYear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
