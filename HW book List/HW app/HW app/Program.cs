
using System;
using System.Collections.Generic;

namespace HW_app
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Book book = new Book("Test1","Test1",100);
            Book book1 = new Book("Test2", "Test2", 200);
            Book book2 = new Book("Test3", "Test3", 300);
            Book book3 = new Book("Test4", "Test4", 400);
            Book book4 = new Book("Test5", "Test5", 500);
            Book book5 = new Book("Test6", "Test6", 100);

            Library library = new Library();
            library.booksMainList.Add(book);
            library.booksMainList.Add(book1);
            library.booksMainList.Add(book2);
            library.booksMainList.Add(book3);
            library.booksMainList.Add(book4);
            library.booksMainList.Add(book5);

            List <Book> test = library.FindAllBooksByName("Test3");
            List<Book> test1 = library.FindAllBooksByPageCountRange(100,400);
            List<Book> test2 = library.SearchBooks("400");
            library.RemoveAllBookByName("Test6");
            library.RemoveByCode(5);

            Console.ReadKey();
        }

       
    }
}
