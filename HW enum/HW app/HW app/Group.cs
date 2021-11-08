using System;
using System.Collections.Generic;
using System.Text;

namespace HW_app
{
    public enum Types
    {
        programming,
        design,
        system

    }

    class Group
    {
        Student[] studentsMainArr = new Student[0];

        private string _type;
        public string Type { get { return _type; }
            set 
            {
                foreach (var item in Enum.GetValues(typeof(Types)))
                {
                    if (value == item.ToString())
                    {
                        _type = value;
                    }
                }
            }
        }
        private string _groupNo;
        public string GroupNo { get { return _groupNo; }
            private set 
            {
                _groupNo = Char.ToUpper(_type[0]) + NoTemp.ToString();
            }
        }
        private static int NoTemp = 99;
        public Group(string type_ )
        {
            NoTemp++;
            this.Type = type_;
            GroupNo = "";

        }

        public Student GetStudent(int wantedNo)
        {
            Student student = new Student("not found","not found");
            foreach (var item in studentsMainArr)
            {
                if (item.NoStudent == wantedNo)
                {
                    student = item;
                    return item;
                }
            }
            return student;
        }

        public void AddStudent(Student newStudent)
        {
            Array.Resize(ref studentsMainArr, studentsMainArr.Length + 1);
            studentsMainArr[studentsMainArr.Length - 1] = newStudent;
        }
    }
}
