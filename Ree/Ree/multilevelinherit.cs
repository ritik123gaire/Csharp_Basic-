using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ree
{ 
     public class Car
{
    protected string model;
    protected string brand;

        public string Model { get { return model; } set { model = value; } }
        public string Brand { get { return brand; } set { brand = value; } }
}

    public class FourWheelDrive : Car
    {
        protected int gear;

    public int Gear { get { return gear; } set { gear = value; } }
    }

    public class Prado : FourWheelDrive
    {
        private int speed;
        public int Speed { get { return speed; } set { speed = value; } }
        
    }


    internal class multilevelinherit
    {

    }
}
