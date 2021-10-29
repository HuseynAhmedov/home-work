using System;

namespace HW_app
{
    class Program
    {
        static void Main(string[] args)
        {
            //<-------------------------------------------------------------------------------->
            //[ 2 ]bir metod yaradin, o metod parametr olaraq  Product arrayi , double olaraq minPrice ve maxPrice deyerleri qebul etsin ve gonderilen product arrayinde Price xususiyyetinin deyeri gonderilen minPrice ve maxPrice araliginda olan productlardan ibaret yeni bir array qaytarsin

            Product[] arr_products = new Product[6] ;
            arr_products[0] = new Product();
            arr_products[0].name = "Doner";
            arr_products[0].brandName = "Istanbul";
            arr_products[0].price = 2.2;
            //------------
            arr_products[1] = new Product();
            arr_products[1].name = "Ayran";
            arr_products[1].brandName = "Bizimsud";
            arr_products[1].price = 0.6;
            //------------
            arr_products[2] = new Product();
            arr_products[2].name = "Cola";
            arr_products[2].brandName = "CocaCola";
            arr_products[2].price = 0.9;
            //------------
            arr_products[3] = new Product();
            arr_products[3].name = "Ice tea";
            arr_products[3].brandName = "Lipton";
            arr_products[3].price = 1.5;
            //------------
            arr_products[4] = new Product();
            arr_products[4].name = "Chips";
            arr_products[4].brandName = "Pringles";
            arr_products[4].price = 3.5;
            //------------
            arr_products[5] = new Product();
            arr_products[5].name = "Orange juice";
            arr_products[5].brandName = "Grand";
            arr_products[5].price = 4;

            Product [] products_ranged = PriceRange(arr_products, 1, 3.9);

            //<-------------------------------------------------------------------------------->
        }

        static Product [] PriceRange (Product [] products , double min_price , double max_price) //[ 2 ];
        {
            Product[] temp = new Product[products.Length];
            int j = 0;

            for (int i = 0; i < temp.Length; i++)
            {
                if ( min_price < products[i].price && products[i].price < max_price)
                {
                    temp[j] = products[i];
                    j++;
                }
            }
            Product[] products_ranged = new Product[j];
            for (int i = 0; i < j; i++) products_ranged[i] = temp[i];
            return products_ranged;
        }

    }
}
