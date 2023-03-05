using System;


namespace Inheritance
{
    public abstract class GroundVehicle : Vehicle
    {
        private int _wheels;

        public int Wheels { get => _wheels; set => _wheels = value; }

        public abstract void drive();

        public GroundVehicle(string msg, int wheels)
        {
            _wheels = wheels;
            Console.WriteLine(msg);
        }
    }
}
