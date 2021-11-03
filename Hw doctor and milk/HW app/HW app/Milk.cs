using System;
using System.Collections.Generic;
using System.Text;

namespace HW_app
{
    class Milk : Product 
    {
        public Milk[] MilksMainArr = new Milk[0];
        public Milk (string nameInput , int countInput) : base (nameInput , countInput)
        {

        }
        private int _volume;
        public int Volume 
        { 
            get 
            {
                return _volume;
            } 
            set 
            {
                if (value > 0)
                {
                    this._volume = value;
                }
            } 
        }

        public int Fat;
        public int FatRate 
        { 
            get 
            {
                if (Fat > 0)
                    return (Fat * 100) / Volume;
                else
                    return 0;
            } 
            set 
            {
                if (Fat > 0)
                {
                    value = (Fat * 100) / Volume;
                }
            } 
        }

        public void AddMilk(Milk newMilk)
        {
            Array.Resize(ref MilksMainArr, MilksMainArr.Length + 1);
            MilksMainArr[MilksMainArr.Length - 1] = newMilk;
        }
    }
}
