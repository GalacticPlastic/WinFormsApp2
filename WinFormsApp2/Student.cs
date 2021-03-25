using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp2
{
    public class Student:Person
    {
        private string _major;

        public String Major
        {
            get { return _major; }
            set { _major = value; }
        }

        public char GetGrade()
        {
            char grade = 'A';
            return grade;
        }
    }
}
