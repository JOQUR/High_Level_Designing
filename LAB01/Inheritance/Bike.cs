using System;



namespace Inheritance
{
    public class Bike : GroundVehicle
    {
        private int _size;
        private int _shifts;

        public int Size { get => _size; set => _size = value; }
        public int Shifts { get => _shifts; set => _shifts = value; }
        public Bike(int size = 24, int shifts = 8) : base("Generated Bike", 2)
        {

        }

        public override void drive()
        {
            Console.WriteLine("Gets on the bike");
        }
    }
}
