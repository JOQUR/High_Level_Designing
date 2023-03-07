namespace Inheritance.Model
{
    public class Vehicle
    {
        public int Capacity { get; private set; }
        public double Length { get; set; }
        public double Weight { get; set; }


        public Vehicle(int cap = 0, double len = 0, double weight = 0)
        {
            Capacity = cap;
            Length = len;
            Weight = weight;
        }
    }

}
