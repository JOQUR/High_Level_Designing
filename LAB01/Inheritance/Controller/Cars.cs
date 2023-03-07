using Inheritance.Model;

namespace Inheritance.Controller
{
    class Cars : IGarage
    {
        public int HorsePower { get; set; }
        public double Engine { get; set; }
        public int Doors { get; private set; }
        public bool Manual { get; private set; }
        public Companies Company { get; private set; }
        public int Wheels { get; set; }
        public int Capacity { get; private set; }
        public double Length { get; set; }
        public double Weight { get; set; }
        public string Message { get; set; }
        public static int Id;
        public Cars(int hp = 100,
                   double eng = 1.8,
                   int doors = 5,
                   bool manual = false,
                   Companies company = Companies.notSpecified,
                   int wheels = 4,
                   string msg = "Car Factory",
                   int cap = 0,
                   double len = 0,
                   double weight = 0) 
        {
            HorsePower = hp;
            Engine = eng;
            Doors = doors;
            Manual = manual;
            Wheels = wheels;
            Capacity = cap;
            Length = len;
            Weight = weight;
            Message = msg;
            Company= company;
        }

        public object vehicle(int hp = 100,
                              double eng = 1.8,
                              int doors = 5,
                              bool manual = false,
                              Companies company = Companies.notSpecified,
                              int wheels = 4,
                              string msg = "Car Factory",
                              int cap = 0,
                              double len = 0,
                              double weight = 0) 
        { 
            return new Car(HorsePower, Engine, Doors, Manual, Company, Wheels, Message); 
        }
    }
}
