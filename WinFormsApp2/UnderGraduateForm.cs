using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class UnderGraduateForm : Form
    {
        public UnderGraduateForm()
        {
            InitializeComponent();
        }

        public string GetYear()
        {
            return dropdownYear.SelectedItem.ToString();
        }

        private void buttonYear_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
