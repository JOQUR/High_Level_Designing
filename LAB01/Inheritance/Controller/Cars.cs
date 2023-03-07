using Inheritance.Model;

namespace Inheritance.Controller
{
    class Cars : IGarage
    {
        public static int Id;
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
            return new Car(hp, eng, doors, manual, company, wheels, msg, cap, len, weight); 
        }
    }
}
