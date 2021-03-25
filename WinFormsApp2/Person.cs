using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp2
{
    public class Person
    {
        private int _id;
        private string _firstName;
        private string _lastName;

        public Person()
        {

        }

        public Person(int id, string firstname, string lastname)
        {
            _id = id;
            _firstName = firstname;
            _lastName = lastname;
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
    }
}
