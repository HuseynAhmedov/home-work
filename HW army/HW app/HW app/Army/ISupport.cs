using System;
using System.Collections.Generic;
using System.Text;

namespace HW_app.Army
{
    interface ISupport
    {
        public abstract string SupportType { get;}
        public abstract int TransportSize { get; set; }
        public abstract int CurrentlyTransporting { get; set; }
        public abstract int LogisticSize { get; set; }
        public abstract int CurrentLogistic { get; set; }

        public void Supply(int supplyCount);

        public void GetSupplys(int supplyCount);
    }
}
