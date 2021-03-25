using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp2
{
    public class GraduateStudent:Student
    {
        private string _thesis;

        public String Thesis
        {
            get { return _thesis; }
            set { _thesis = value; }
        }

    }
}
