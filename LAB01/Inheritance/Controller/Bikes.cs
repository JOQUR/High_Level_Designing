using Inheritance.Model;

namespace Inheritance.Controller
{
    class Bikes : IGarage
    {
        public Bikes() { }

        public object vehicle(int hp = 100,
                              double eng = 1.8,
                              int doors = 5,
                              bool manual = false,
                              Companies company = Companies.notSpecified,
                              int wheels = 4,
                              string msg = "Car Factory",
                              int cap = 0,
                              double len = 0,
                              double weight = 0) { return new Bike(); }
    }
}
