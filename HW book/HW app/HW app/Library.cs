using System;
using System.Collections.Generic;
using System.Text;

namespace HW_app
{
    class Library
    {
        public Book[] booksArr = new Book [0];

        #region Adding info funksions
        public Book[] AddBook(Book newBook)
        {
            
            Book[] booksTemp = new Book[booksArr.Length+1];

            for (int i = 0; i < booksArr.Length; i++)
            {
                booksTemp[i] = booksArr[i];
            }
            booksTemp[booksTemp.Length-1] = newBook;
            booksArr = booksTemp;
            return booksArr;
        }

        public Book[] AddBook(Book [] newBookArr)
        {
            Book[] booksTemp = new Book[0];
            booksTemp = new Book[booksArr.Length + newBookArr.Length];
            int count = 0;

            for (; count < booksArr.Length; count++)
            {
                booksTemp[count] = booksArr[count];
                
            }
            for (int i = 0; count < booksTemp.Length; i++ , count++)
            {
                booksTemp[count] = newBookArr[i];
            }
            booksArr = booksTemp;
            return booksArr;
        }
        #endregion

        #region Filter Funksions


        public void FilterBooksGenre(string wantedGenre)
        {

            for (int i = 0; i < booksArr.Length; i++)
            {
                if (booksArr[i].genre == wantedGenre)
                {
                    ShowBook(booksArr[i]);
                }
            }
        }

        public void FilterBooksPrice(double minPrice, double maxPirce)
        {
            for (int i = 0; i < booksArr.Length; i++)
            {
                if (booksArr[i].price > minPrice && booksArr[i].price < maxPirce)
                {
                    ShowBook(booksArr[i]);
                }
            }
        }
        #endregion

        #region Show Funksions
        public void ShowBook(Book[] bookArr)
        {
            for (int i = 0; i < bookArr.Length; i++)
            {
                Console.WriteLine("=====================================");
                Console.WriteLine($"Book ID / No : {bookArr[i].no}");
                Console.WriteLine($"Book name    : {bookArr[i].name}");
                Console.WriteLine($"Book genre   : {bookArr[i].genre}");
                Console.WriteLine($"Book price   : {bookArr[i].price}");
                Console.WriteLine($"Book count   : {bookArr[i].count}");
            }
        }

        public void ShowBook(Book book)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine($"Book ID / No : {book.no}");
            Console.WriteLine($"Book name    : {book.name}");
            Console.WriteLine($"Book genre   : {book.genre}");
            Console.WriteLine($"Book price   : {book.price}");
            Console.WriteLine($"Book count   : {book.count}");
        }
        #endregion

        public bool CheakID (int ID , int [] tempID)
        {
            for (int i = 0; i < tempID.Length; i++)
            {
                if (ID == tempID[i])
                {
                    return true;
                }
            }

            for (int i = 0; i < booksArr.Length; i++)
            {
                if (ID == booksArr[i].no )
                {
                    return true;
                }
            }
            return false;
        }
    }
}
