using System;

namespace HW_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Library libraryMain = new Library();
            // evvelceden info elave etmeyi yoxlamaq ucun 
            //--------------------------------------------------
            //Book[] books = new Book[2];
            //books[0] = new Book(1,"Desert fox",5, "History");
            //books[1] = new Book(2, "Mein kampf", 6, "Biography");

            //libraryMain.AddBook(books);

            //Book book = new Book(3, "Infantry Attacks" ,4, "AvtoBiography");

            //libraryMain.AddBook(book);
            //-------------------------------------------------

            Console.Write("Nummber of books : ");
            int bookCount = Convert.ToInt32(Console.ReadLine());
            while (CheakLimit(bookCount,0))
            {
                Console.WriteLine("\nInvalid book count \nEnter nummber of books : ");
                bookCount = Convert.ToInt32(Console.ReadLine());
            }
            Book[] booksMainArr = InsertBooks(bookCount,libraryMain);

            libraryMain.AddBook(booksMainArr);
            FilterMenu(libraryMain);


        }

        static Book[] InsertBooks(int bookCount,Library library)
        {
            Book[] booksArr = new Book[bookCount];

            int[] noTempArr = new int[bookCount + 1];
            int countTemp = 1;
            int noTemp = 0;
            int j = 0;
            double priceTemp = 0;
            string nameTemp = "";
            string genreTemp = "";


            noTempArr[j] = noTemp;
            j++;

            for (int i = 0; i < booksArr.Length; i++)
            {
                Console.WriteLine("=====================================");
                Console.WriteLine($"Book {i+1}                          ");
                Console.WriteLine("=====================================");

                Console.Write("\nEnter Book ID : ");
                noTemp = Convert.ToInt32(Console.ReadLine());

                while (library.CheakID(noTemp,noTempArr) || CheakLimit(noTemp,0))
                {
                    Console.Write("\nInvalid book ID\nEnter Book ID : ");
                    noTemp = Convert.ToInt32(Console.ReadLine());
                }
                noTempArr[j] = noTemp;
                j++;

                Console.Write("\nEnter Book name : ");
                nameTemp = Console.ReadLine();
                while (CheakLimit(nameTemp,1,50))
                {
                    Console.Write("\nName cannot be smaller than 1 or bigger than 50 characters \nEnter Book name : ");
                    nameTemp = Console.ReadLine();
                }

                Console.Write("\nEnter book price : ");
                priceTemp = Convert.ToDouble(Console.ReadLine());
                while (CheakLimit(priceTemp,0))
                {
                    Console.Write("\nPrice is out of range \nEnter book price : ");
                    priceTemp = Convert.ToDouble(Console.ReadLine());
                }

                Console.Write("\nEnter amount of this book : ");
                countTemp = Convert.ToInt32(Console.ReadLine());
                while (CheakLimit(countTemp,0))
                {
                    Console.Write("\nAmount of books is out of range\nEnter amount of this book : ");
                    countTemp = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("\nEnter genre of the book : ");
                genreTemp = Console.ReadLine();
                while (CheakLimit(genreTemp,3,20))
                {
                    Console.Write("\nGenre of the book cannot be smaller than 3 or bigger than 20 charecters \nEnter genre of the book : ");
                    genreTemp = Console.ReadLine();
                }
                Book book = new Book(noTemp,nameTemp,priceTemp,genreTemp);
                book.count = countTemp;

                booksArr[i] = book;
            }
            return booksArr;
        }

        static void FilterMenu (Library library)
        {
            int input = 0;
            int min   = 0;
            int max   = 0;
            string inputStr = "";


            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("Do you want to filer inserted books ?");
            Console.WriteLine("[ y ] / [ n ]");
            inputStr = Console.ReadLine();

            

            if (inputStr == "n")
            {
                Console.Clear();
                library.ShowBook(library.booksArr);
            }
            else if (inputStr == "y")
            {
                Console.Clear();
                Console.WriteLine("=====================================");
                Console.WriteLine("Select your filter ");
                Console.WriteLine("[ 1 ] - by genre");
                Console.WriteLine("[ 2 ] - by price");
                input = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (input == 1)
                {
                    Console.Clear();
                    Console.WriteLine("=====================================");
                    Console.Write("Enter wanted genre : ");
                    inputStr = Console.ReadLine();
                    library.FilterBooksGenre(inputStr);
                }
                else if (input == 2)
                {
                    Console.Clear();
                    Console.WriteLine("=====================================");
                    Console.Write("Enter minimun price tag : ");
                    min = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("=====================================");
                    Console.Write("Enter maxsimum price tag : ");
                    max = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    library.FilterBooksPrice(min, max);
                }
                else
                Console.WriteLine("no such a command");
                
            }
            else
            {
                Console.WriteLine("no such a command");
            }
        }

        #region Check funksions

        
        static bool CheakLimit ( int input , int min = -2147483647, int max = 2147483646)
        {
            if (min > input || input > max)
            {
                return true;
            }
            return false;
        }

        static bool CheakLimit (string input , int min  , int max)
        {
            if (min > input.Length || input.Length > max)
            {
                return true;
            }
            return false;
        }

        static bool CheakLimit ( double input , double min = -1.7976931348623157E+308, double max = 1.7976931348623157E+308)
        {
            if (min > input || input > max)
            {
                return true;
            }
            return false;
        }

        static bool CheakNo (int noInput , int [] idArr)
        {
            for (int i = 0; i < idArr.Length; i++)
              if (noInput == idArr[i]) 
               return true;

               return false;
        }

        #endregion
    }
}
