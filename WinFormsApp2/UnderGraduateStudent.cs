using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp2
{
    public class UnderGraduateStudent:Student
    {
        private string _year;

        public String Year
        {
            get { return _year; }
            set { _year = value; }
        }
    }
}
