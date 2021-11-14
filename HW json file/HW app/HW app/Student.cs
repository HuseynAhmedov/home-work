using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HW_app
{
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public Student(string name, string surname, byte age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

    }
}
