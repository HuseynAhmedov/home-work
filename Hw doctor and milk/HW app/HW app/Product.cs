using System;
using System.Collections.Generic;
using System.Text;

namespace HW_app
{
    class Product
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (String.IsNullOrWhiteSpace(Name))
                {
                    if (3 < value.Length && value.Length < 35)
                    {
                        this._name = value;
                    }
                } 
            } 
        }

        private double _price;
        public double Price
        { 
            get 
            {
                return _price;
            } 
            set 
            {
                if (value > 0 )
                {
                    this._price = value;
                }
            } 
        }

        private int _count;

        private double _totalIncome;

        public double TotalIncome { get { return this._totalIncome; } }

        public int Count { get { return this._count; } }

        public Product (string nameIncome , int countInput)
        {
            this._count = countInput;
            this.Name = nameIncome;
        }

        public void SellProduct()
        {
            if (_count <= 0)
            {
                Console.WriteLine("====================================");
                Console.WriteLine("Amound of this product is 0 or under 0 \nTransaction denied");
                return;
            }
            else
            {
                Console.WriteLine("====================================");
                Console.WriteLine($"1 {Name} item sold in maket place\nTransaction completed");
                _totalIncome += Price;
                _count--;
            }
        }
    }
}
