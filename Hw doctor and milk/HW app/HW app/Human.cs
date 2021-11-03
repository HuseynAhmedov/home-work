using System;
using System.Collections.Generic;
using System.Text;

namespace HW_app
{
    class Human
    {
        public string Name;

        public string Surname;

        public string Gender;
     
        public virtual void ShowInfo ()
        {
            Console.WriteLine($"Name    : {Name}");
            Console.WriteLine($"Surname : {Surname}");
            Console.WriteLine($"Gender  : {Gender}");
        }

    }
}
