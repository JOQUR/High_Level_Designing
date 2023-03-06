using System;

namespace Inheritance.Model
{
    public class Car : GroundVehicle
    {
        public int HorsePower { get; set; }
        public double Engine { get; set; }
        public int Doors { get; private set; }
        public bool Manual { get; private set; }
        public Companies Company { get; private set; }

        public Car(int hp = 100,
                   double eng = 1.8,
                   int doors = 5,
                   bool manual = false,
                   Companies company = Companies.notSpecified,
                   int wheels = 4,
                   string msg = null,
                   int cap = 0,
                   double len = 0,
                   double weight = 0) : base("Created Car", wheels, cap, len, weight)
        {
            HorsePower = hp;
            Engine = eng;
            Doors = doors;
            Manual = manual;
            Company = company;
            Console.WriteLine(msg);
        }
        public override void drive()
        {
            Console.WriteLine("Turning on Engine!");
        }
        public void listenToMusic()
        {
            Console.WriteLine("*listening to music*");
        }
    }
}
