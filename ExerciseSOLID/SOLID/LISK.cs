using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.SOLID
{
    //abstract class Car1
    //{
    //    abstract public void speed(int meters);
    //    abstract public void refuel(int litres);
    //}
    //class ElectricCar : Car1
    //{
    //    public override void refuel(int litres)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public override void speed(int meters)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    abstract class Car { abstract public void speed(int meters);  }
    class GasPoweredCar : Car
    {
        public override void speed(int meters)
        {
            throw new NotImplementedException();
        }
        public void refuel(int litres)
        {
        }
    }
    class ElectricPoweredCar : Car
    {
        public override void speed(int meters)
        {
            throw new NotImplementedException();
        }
        public void refuel(int watt) { }
    }
}
