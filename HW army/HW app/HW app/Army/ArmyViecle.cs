using System;
using System.Collections.Generic;
using System.Text;

namespace HW_app.Army
{
    abstract class ArmyViecle
    {
        public abstract string ModelName { get;}
        public abstract string TireOrTrack { get; set;}
        public abstract string EngineName { get;}
        public abstract string MadeBy { get;}
        public abstract int FuelCapasity { get; set;}
        public abstract int FuelFor1Km { get; set;}
        public abstract int CurrentFuel { get; set;}
        public abstract int CrewSize { get; set; }
        public abstract int Year { get; set;}

        public ArmyViecle(int fuelFor1Km_ , int fuelCapasity_)
        {
            if (fuelFor1Km_ > 0)
            {
                FuelFor1Km = fuelFor1Km_;
            }
            if (fuelCapasity_ > 10)
            {
                FuelCapasity = fuelCapasity_;
            }
        }
        public virtual void Move(int roadLenght)
        {
            if (roadLenght * FuelFor1Km <= CurrentFuel)
            {
                CurrentFuel -= roadLenght * FuelFor1Km;
                Console.WriteLine("Viecle moveing");
            }
            else
            {
                Console.WriteLine("Cannot move . not enought fuel left");
            }
        }
        public virtual void Refuel(int newFuel)
        {
            if (CurrentFuel + newFuel < FuelCapasity)
            {
                CurrentFuel += newFuel;
                Console.WriteLine("Viecle refueled");
            }
            else
            {
                Console.WriteLine("Fuel tank overflow");
            }
        }

    }
}
