using System;

namespace Inheritance
{
    public class Car : GroundVehicle
    {
        private int _horsePower;
        private double _engine;
        private int _doors;
        private bool _manual;
        private Companies _company;

        public int HorsePower { get => _horsePower; }
        public double Engine { get => _engine; }
        public int Doors { get => _doors; }
        public bool Manual { get => _manual; }
        public Companies Company { get => _company; set => _company = value; }

        public Car(int hp = 100, double eng = 1.8, int doors = 5, bool manual = false, Companies company = Companies.notSpecified) : base("Generated Car", 4)
        {
            _horsePower = hp;
            _engine = eng;
            _doors = doors;
            _manual = manual;
            _company= company;
        }
        public override void drive()
        {
            Console.WriteLine("Turning on Engine!");
        }
    }
}
