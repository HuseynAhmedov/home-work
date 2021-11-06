
using System;
namespace HW_app
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //--------------------------------
            //[ 1 ]
            //string a = " goodbye world";
            //a.ToCapitalize();
            //a.GetValueIndexes('o');
            //Console.ReadKey();
            //--------------------------------
            //[ 2 ]
            //Student student = StudentMenu();
            //Console.ReadKey();
        }

        public static Student StudentMenu ()
        {
            string tempName = "";
            string tempSurname = "";
            string tempgroupNo = "";
            string ageStr = "";
            byte tempAge = 0;

            Console.Write("Enter students name : ");
            tempName = Console.ReadLine();
            while (!Student.CheckStr(tempName))
            {
                Console.WriteLine("Invalid name entry \nEnter student name :");
                tempName = Console.ReadLine();
            }

            Console.Write("Enter students surname : ");
            tempSurname = Console.ReadLine();
            while (!Student.CheckStr(tempSurname))
            {
                Console.WriteLine("Invalid surname entry \nEnter student surname :");
                tempSurname = Console.ReadLine();
            }

            Console.Write("Enter students group NO / ID : ");
            tempgroupNo = Console.ReadLine();
            while (!Student.CheckGroupNo(tempgroupNo))
            {
                Console.WriteLine("Invalid group ID / No entry \nEnter student group ID :");
                tempgroupNo = Console.ReadLine();
            }

            Console.Write("Enter students age : ");
            ageStr = Console.ReadLine();
            while (!byte.TryParse(ageStr, out tempAge) || tempAge < 0 || tempAge > 100)
            {
                Console.WriteLine("Invalid student age entry \nEnter student age :");
                ageStr = Console.ReadLine();
            }
            Student newStudent = new Student(tempName,tempSurname,tempgroupNo,tempAge);
            return newStudent;
        }
    }
}
