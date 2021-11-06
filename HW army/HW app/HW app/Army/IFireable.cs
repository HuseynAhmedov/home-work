using System;
using System.Collections.Generic;
using System.Text;

namespace HW_app.Army
{
    interface IFireable
    {
        public string GunType { get;}
        public string GunTarget { get;}
        public int GunCaliber { get; set;}
        public double GunRange { get; set;}
        public int ReloadSpeed { get;}
        public string LoaderType { get; set; }
        public int AmmoCount { get; set; }
        public string GunAmmoType { get; set; }

        public void Fire(int bulletCount);
    }
}
