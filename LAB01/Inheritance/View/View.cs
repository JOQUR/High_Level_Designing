using System;
using System.Collections.Generic;
using System.Linq;
using Inheritance.Controller;
using Inheritance.Model;

namespace Inheritance.View
{
    class View
    {
        static public List<Car> CarsList= new List<Car>();
        public View(int hp = 100,
                    double eng = 1,
                    int doors = 3,
                    bool manual = false,
                    Companies company = Companies.Ferrari,
                    int wheels = 4,
                    string msg = null,
                    int cap = 0,
                    double len = 0,
                    double weight = 0)
        {
            Cars cars = new Cars(hp, eng, doors, manual, company, wheels, msg, cap, len, weight);
            CarsList.Add((Car)cars.vehicle(hp, eng, doors, manual, company, wheels, msg, cap, len, weight));
        }

        static public void ListCars()
        {
            foreach(var obj in CarsList)
            {
                Console.WriteLine("================================");
                Console.WriteLine("HorsePower: {0}", obj.HorsePower);
                Console.WriteLine("Engine: {0}", obj.Engine);
                Console.WriteLine("Doors: {0}", obj.Doors);
                Console.WriteLine("Is It Manual?: {0}", obj.Manual);
                Console.WriteLine("Company: {0}", obj.Company);
                Console.WriteLine("Wheels: {0}", obj.Wheels);
                Console.WriteLine("Capacity: {0}", obj.Capacity);
                Console.WriteLine("Length: {0}", obj.Length);
                Console.WriteLine("Weight: {0}", obj.Weight);
                Console.WriteLine("ID: {0}", ++Cars.Id);
                obj.drive();
                obj.listenToMusic();
            }
        }
    }
}
