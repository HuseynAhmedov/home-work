using HW_app.Army;
using System;
namespace HW_app
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Tank panzer4 = new Tank("Maybach HL120 TRM","Natzi germany", "7.5 cm (2.95 in) KwK 40", "anti-tank",2500,10,"steel plate", @"Panzerkampfwagen IV Sd.Kfz. 161 / VK 622(Ausf.A)",100,87,10,"none","skirt armor","track",150,"HEAT",5,1939,7,"manual",80,30);
            panzer4.Move(100000);
            panzer4.Fire(100);
            panzer4.Refuel(100);
            Console.ReadKey();
        }

    }
}
