using System;
using System.Collections.Generic;
using System.Text;

namespace HW_app
{
    class Doctor : Human
    {
        public Doctor[] DoctorMainArr = new Doctor[0];

        public int No;

        public string Speciality;

        public string Experience;

        public override void ShowInfo()
        {
            base.ShowInfo();
            
                Console.WriteLine($"No / ID    : {No}");
                Console.WriteLine($"Speciality : {Speciality}");
                Console.WriteLine($"Experience : {Experience}");
        }

        public void AddDoctor (Doctor newDoctor)
        {
            Array.Resize(ref DoctorMainArr, DoctorMainArr.Length + 1);
            DoctorMainArr[DoctorMainArr.Length - 1] = newDoctor;
        }
    }
}
