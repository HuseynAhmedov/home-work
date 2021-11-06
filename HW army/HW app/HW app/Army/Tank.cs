using System;
using System.Collections.Generic;
using System.Text;

namespace HW_app.Army
{
    class Tank : ArmyViecle, IFireable, IArmored
    {

        private string _tireOrTrack;
        private int _crewSize;
        private int _gunCaliber;
        private int _year;
        private string _loaderType;
        private string _gunAmmoType;
        private int _sideArmor;
        private int _frontArmor;

        public override string EngineName { get; }
        public override string MadeBy { get; }
        public string GunType { get; }
        public string GunTarget { get; }
        public double GunRange { get; set; }
        public int ReloadSpeed { get; }
        public string ArmorType { get; }
        public override string ModelName { get; }
        public override int CurrentFuel { get; set; }
        public int AmmoCount { get; set; }
        public override int FuelFor1Km { get; set; }
        public string ActiveProtection { get; set; }
        public string ImprovisedArmor { get; set; }
        public override string TireOrTrack
        {
            get
            {
                return _tireOrTrack;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    string fixedValue = value.Trim().ToLower();
                    if (fixedValue.Contains("tire"))
                    {
                        _loaderType = "tired tracking";
                    }
                    else if (fixedValue.Contains("track"))
                    {
                        _loaderType = "tracked endless belt";
                    }
                }
            }
        }
        public override int FuelCapasity { get; set; }
        public string GunAmmoType
        {
            get { return _gunAmmoType; }
            set
            {
                if (CheackAmmo(value))
                {
                    _gunAmmoType = value.Trim().ToUpper();
                }
                else Console.WriteLine("invalid ammo type");
            }
        }
        public override int CrewSize
        {
            get { return _crewSize; }
            set
            {
                if (value > 0 || value < 6)
                {
                    _crewSize = value;
                }
            }
        }
        public override int Year
        {
            get { return _year; }
            set
            {
                if (value > 1914 && value < 2022)
                {
                    _year = value;
                }
            }
        }
        public int GunCaliber
        {
            get { return _gunCaliber; }
            set
            {
                if (value > 0 && value < 187)
                {
                    _gunCaliber = value;
                }
            }
        }
        public string LoaderType
        {
            get { return _loaderType; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    string fixedValue = value.Trim().ToLower();
                    if (fixedValue.Contains("auto"))
                    {
                        _loaderType = "auto loader";
                    }
                    else if (fixedValue.Contains("manual"))
                    {
                        _loaderType = "manual loader";
                    }
                }
            }
        }
        public int FrontArmorMM
        {
            get { return _frontArmor; }
            set
            {
                if (value > 0)
                {
                    _frontArmor = value;
                }
            }
        }
        public int SideArmorMM
        {
            get { return _sideArmor; }
            set
            {
                if (value > 0)
                {
                    _sideArmor = value;
                }
            }
        }


        public Tank(string engineName_, string madeBy_, string gunType_, string gunTarget_, double gunRange_, int reloadSpeed_, string armorType_, string modelName_, int currentFuel_, int ammoCount_, int fuelFor1Km_, string activeProtection_, string improvisedArmor_, string tireOrTrack_, int fuelCapasity_, string gunAmmoType_, int crewSize_, int year_, int gunCaliber_, string loaderType_, int frontArmorMM_, int sideArmorMM_) : base(fuelFor1Km_, fuelCapasity_)
        {
            this.EngineName = engineName_;
            this.MadeBy = madeBy_;
            this.GunType = gunType_;
            this.GunTarget = gunTarget_;
            this.GunRange = gunRange_;
            this.ReloadSpeed = reloadSpeed_;
            this.ArmorType = armorType_;
            this.ModelName = modelName_;
            this.CurrentFuel = currentFuel_;
            this.AmmoCount = ammoCount_;
            this.FuelFor1Km = fuelFor1Km_;
            this.ActiveProtection = activeProtection_;
            this.ImprovisedArmor = improvisedArmor_;
            this.TireOrTrack = tireOrTrack_;
            this.FuelCapasity = fuelCapasity_;
            this.GunAmmoType = gunAmmoType_;
            this.CrewSize = crewSize_;
            this.Year = year_;
            this.GunCaliber = gunCaliber_;
            this.LoaderType = loaderType_;
            this.FrontArmorMM = frontArmorMM_;
            this.SideArmorMM = sideArmorMM_;
        }

        public void Fire(int bulletCount = 1)
        {
            if (AmmoCount < bulletCount)
            {

                Console.WriteLine("Out of ammo");
            }
            else
            {
                AmmoCount -= bulletCount;
                Console.WriteLine($"gun fireing {bulletCount} round");
            }

            
        }
        protected bool CheackAmmo(string ammoToCheack)
        {
            if (!String.IsNullOrWhiteSpace(ammoToCheack))
            {
                string[] ammoTypes = { "AP", "APCR", "HE", "HEAT", "HESH", "APFSDS", "APBC", "APBCSC", "APSC", "CANISTER", "AC", "SHRAPNEL", "SMOKE", "HEC", "ARROWHEAD", "BASH" };
                string fixedValue = ammoToCheack.Trim().ToUpper();
                foreach (var item in ammoTypes)
                {
                    if (fixedValue == item)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

