using System;
using System.Collections.Generic;
using System.Text;

namespace HW_app.Army
{
    interface IArmored
    {
        public string ArmorType { get;}
        public int FrontArmorMM { get; set; }
        public int SideArmorMM { get; set; }
        public string ActiveProtection { get; set; }
        public string ImprovisedArmor { get; set; }
    }
}
