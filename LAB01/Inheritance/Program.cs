using Inheritance.Model;
using System;
using System.Collections.Generic;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AutonomousCar> cars = new List<AutonomousCar> { new AutonomousCar(2, 4, 200, 2, 5, true, Companies.Ferrari, 4, null, 4, 3.5, 1300.5), new AutonomousCar(2, 0, 100, 1.4, 5, true, Companies.Seat, 4, null, 4, 3.5, 1300.5) };
            foreach(AutonomousCar car in cars)
            {
                Console.WriteLine(car.Company);
            }
        }
    }
}

