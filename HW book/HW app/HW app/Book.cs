using System;
using System.Collections.Generic;
using System.Text;

namespace HW_app
{
    class Book : Product
    {
        public Book (int noInput, string nameInput, double priceInput , string genreInput) : base ( noInput , nameInput , priceInput)
        {
            this.genre = genreInput; 
        }

        public string genre;

    }
}
