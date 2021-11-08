
using System;
namespace HW_app
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Student student = new Student("Huseyn1", "Ahmedov");
            Student student1 = new Student("Huseyn2", "Ahmedov2");
            Student student2 = new Student("Huseyn3", "Ahmedov3");
            Student student3 = new Student("Huseyn4", "Ahmedov4");
            student1.NoStudent = 10;

            Group group = new Group(Types.programming.ToString());

            group.AddStudent(student);
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);
            group.GetStudent(3);
            Console.WriteLine(group.GroupNo);

            Group group1 = new Group(Types.design.ToString());
            Console.WriteLine(group1.GroupNo);
            Console.ReadKey();
        }

       
    }
}
