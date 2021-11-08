using System;
using System.Collections.Generic;
using System.Text;

namespace HW_app
{
    class Student
    {
        protected int _noStudent;
        public int NoStudent
        {
            get
            {
                return _noStudent;
            }
            set
            {
                if (_noStudent <= 0)
                {
                    _noStudent = NoTemp;
                }
            }
        }
        private string _fullName;
        public string FullName { get { return _fullName; }
            set 
            {
                _fullName = value;
            }
        }
        public static int NoTemp = 1;
        public Student(string name_ , string surname_)
        {
            _noStudent = NoTemp++;
            FullName = name_.Trim() + " " + surname_.Trim();
        }
    }
}
