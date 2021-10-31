using System;
using System.Collections.Generic;
using System.Text;

namespace HW_app
{
    class Product
    {
        public Product (int inputNo , string nameInput , double priceInput)
        {
            this.no = inputNo;
            this.name = nameInput;
            this.price = priceInput;
        }

        public int no;

        public string name;

        public double price;

        public int count;
    }
}
