using System;

namespace HW_app
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------
            //[ 1 ] sual cox uzundu bura yazmaga ( question string overflow ) 
            //Doctor doctorMain = new Doctor();
            //DoctorMenu(doctorMain);
            //-------------------------------------------
            //[ 2 ]

            //Product [] products = new Product[4];

            //Product product1 = new Product("Milk", 10);
            //product1.Price = 11;

            //Product product2 = new Product("Toy", 3);
            //product2.Price = 4;

            //Product product3 = new Product("Meat", 10);
            //product3.Price = 22;

            //Product product4 = new Product("Juice", 100);
            //product4.Price = 0.4;

            //products[0] = product1;
            //products[1] = product2;
            //products[2] = product3;
            //products[3] = product4;

            //products[0].SellProduct();
            //products[1].SellProduct();
            //products[1].SellProduct();
            //products[1].SellProduct();
            //products[1].SellProduct();
            //products[1].SellProduct();

            //-------------------------------------------
            //[ 2.1 ] 
            //Milk milkMain = new Milk("temp",0);

            //AddMilkMenu(milkMain);
            //milkMain.MilksMainArr[0].SellProduct();
            //milkMain.MilksMainArr[0].SellProduct();
            //milkMain.MilksMainArr[0].SellProduct();


        }

        static void DoctorMenu (Doctor doctorMain)
        {
            
            string strConsole = "";

            Console.WriteLine("====================================");
            Console.WriteLine("[ 1 ] Add Doctorts");
            Console.WriteLine("[ 2 ] Show Doctors list");
            Console.WriteLine("[ 3 ] Exit");
            Console.WriteLine("====================================");
            strConsole = Console.ReadLine();

            switch (strConsole)
            {
                case "1":
                    AddDoctorMenu(doctorMain);
                    DoctorMenu(doctorMain);
                    break;
                case "2":
                    if (doctorMain.DoctorMainArr.Length == 0)
                    {
                        Console.WriteLine("No doctors on the list");
                       
                    }
                    else
                    {
                        foreach (var item in doctorMain.DoctorMainArr)
                        {
                            Console.WriteLine("====================================");
                            item.ShowInfo();
                        }
                        
                    }
                    DoctorMenu(doctorMain);
                    break;
                case "3":
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("No such a command");
                    DoctorMenu(doctorMain);
                    break;
            }
        }
        static void AddDoctorMenu (Doctor doctorMain)
        {
            int doctorCount;
            int intInput;

            string strInput;
            
            Console.Clear();
            Console.WriteLine("====================================");
            do
            {
                Console.Write("\nNummber of doctors you want to add : ");
                strInput = Console.ReadLine();

            } while (!int.TryParse(strInput, out doctorCount) || doctorCount < 1);

            for (int i = 0; i < doctorCount; i++)
            {
                Doctor newDoctor = new Doctor();
                Console.WriteLine("====================================");
                do
                {
                    Console.Write("\nEnter No / ID : ");
                    strInput = Console.ReadLine();

                } while (!int.TryParse(strInput, out intInput) || intInput < 0);
                newDoctor.No = intInput;

                Console.WriteLine("====================================");
                Console.Write("\nEnter name : ");
                newDoctor.Name = Console.ReadLine();

                Console.WriteLine("====================================");
                Console.Write("\nEnter Surname : ");
                newDoctor.Surname = Console.ReadLine();

                intInput = 0;
                do
                {
                    Console.WriteLine("====================================");
                    Console.WriteLine("Select doctors gender");
                    Console.WriteLine("[ 1 ] Male ");
                    Console.WriteLine("[ 2 ] Female");
                    strInput = Console.ReadLine();
                    if (int.TryParse(strInput, out intInput) == true)
                    {
                        if (intInput == 1)
                        {
                            newDoctor.Gender = "Male";
                            break;
                        }
                        else if (intInput == 2)
                        {
                            newDoctor.Gender = "Female";
                            break;
                        }
                        else Console.WriteLine("No such a command");
                    }
                    else Console.WriteLine("No such a command");

                } while (true);

                Console.WriteLine("====================================");
                Console.Write("\nEnter specialit : ");
                newDoctor.Speciality = Console.ReadLine();

                Console.WriteLine("====================================");
                Console.Write("\nEnter experience : ");
                newDoctor.Experience = Console.ReadLine();

                doctorMain.AddDoctor(newDoctor);
            }
        }
        static void AddMilkMenu (Milk milkMAin)
        {
            string strInput = "";
            int milkCount;
            Console.WriteLine("====================================");
            do
            {
                Console.Write("\nHow many milk ? : ");
                strInput = Console.ReadLine();

            } while (!int.TryParse(strInput, out milkCount) || milkCount < 1);

            string nameTemp = "";
            double priceTemp = 0;
            int volumeTemp = 0;
            int fatTemp = 0;
            int countTemp = 0;
            for (int i = 0; i < milkCount; i++)
            {
                do
                {
                    Console.Write("\nMilk name : ");
                    nameTemp = Console.ReadLine();
                } while ( 3 > nameTemp.Length || nameTemp.Length > 35);
                Console.WriteLine("====================================");
                do
                {
                    Console.Write("\nMilk price : ");
                    strInput = Console.ReadLine();
                } while (!double.TryParse(strInput,out priceTemp )|| priceTemp <=0 );
                Console.WriteLine("====================================");
                do
                {
                    Console.Write("\nVolume of the milk : ");
                    strInput = Console.ReadLine();
                } while (!int.TryParse(strInput, out volumeTemp) || volumeTemp <= 0);
                Console.WriteLine("====================================");
                do
                {
                    Console.Write("\nAmount of the milk : ");
                    strInput = Console.ReadLine();
                } while (!int.TryParse(strInput, out countTemp ) || countTemp <= 0);
                Console.WriteLine("====================================");
                do
                {
                    Console.Write("\nFat volume of the milk : ");
                    strInput = Console.ReadLine();
                } while (!int.TryParse(strInput, out fatTemp) || fatTemp <= 0);

                Milk newMilk = new Milk(nameTemp, countTemp);
                newMilk.Price = priceTemp;
                newMilk.Volume = volumeTemp;
                newMilk.Fat = fatTemp;

                milkMAin.AddMilk(newMilk);

            }


        }
    }
}
