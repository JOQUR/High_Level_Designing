using System;

namespace Inheritance.Model
{
    public class Bike : GroundVehicle
    {

        public int Size { get; private set; }
        public int Shifts { get; private set; }
        public Bike(
            int size = 24,
            int shifts = 8,
            int wheels = 2,
            string msg = null,
            int cap = 0,
            double len = 0,
            double weight = 0) : base(msg, wheels, cap, len, weight)
        {
            Size = size;
            Shifts = shifts;
        }

        public override void drive()
        {
            Console.WriteLine("Get on the bike");
        }
    }
}
