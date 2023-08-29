using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise.SOLID
{
    //public class Vehicle
    //{
    //    void carDisplayPlateNumber() { }
    //    void truckDisplayPlateNumber() { }
    //}

    public class Vehicle
    {
        public virtual string carDisplayPlateNumber()
        {
           return "22234";
        }
    }
   
    public class PassangerCar : Vehicle
    {
        public override string carDisplayPlateNumber()
        {
            return base.carDisplayPlateNumber() + "C";
        }
    }
    public class Truck : Vehicle
    {
        public override string carDisplayPlateNumber()
        {
             return base.carDisplayPlateNumber() + "T";
        }
    }
}
