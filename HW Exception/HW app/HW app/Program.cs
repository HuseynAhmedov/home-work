using System;
using ClassLibrary;
using HW_app.Custom_exceptions;
namespace HW_app
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //-------------------------------------------
            //[ 1 ] 
            //User user = RegisterMenu();
            //Console.ReadKey();
            //-------------------------------------------
            //[ 2 ] 
            //Check checkLib = new Check();
            //bool a = checkLib.HasDigit("Abc12");
            //bool b = checkLib.HasLower("AAAAA");
            //bool c = checkLib.HasUpper("Asad");
            //Console.ReadKey();
        }

        static User RegisterMenu ()
        {
            string userNameTemp = "";
            bool allRight;
            User newUser = new User("temptemptemp");
            do
            {
                allRight = true;
                try
                {
                    Console.WriteLine("================================");
                    Console.Write("\nEnter username : ");
                    userNameTemp = Console.ReadLine();
                    newUser.UserName = userNameTemp;
                    Console.WriteLine("================================");
                    Console.Write("\nEnter password : ");
                    newUser.PassWord = Console.ReadLine();
                    Console.WriteLine("================================");
                }
                catch (InvalidUserNameException exc)
                {
                    Console.WriteLine(exc.Message);
                    Console.WriteLine(exc.Parameters);
                    allRight = false;
                }
                catch (PasswordIncorrectException exc)
                {
                    Console.WriteLine(exc.Message);
                    Console.WriteLine(exc.Parameters);
                    allRight = false;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    allRight = false;
                }
            } while (!allRight);
            
            return newUser;
        }

    }
}
