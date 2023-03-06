using System;


namespace Inheritance.Model
{
    public abstract class GroundVehicle : Vehicle
    {

        // You can anytime add additional wheel ;)
        public int Wheels { get; set; }

        public abstract void drive();

        public GroundVehicle(string msg,
                             int wheels,
                             int cap = 0,
                             double len = 0,
                             double weight = 0) : base(cap, len, weight)
        {
            Wheels = wheels;
            Console.WriteLine(msg);
        }
    }
}
