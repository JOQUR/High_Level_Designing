using System;
using System.Collections.Generic;

namespace Inheritance.View
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Many cars?");
            int howMany = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < howMany; i++)
            {

                Console.WriteLine("How many HorsePower?");
                int hp = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Size of the engine?");
                double eng = Double.Parse(Console.ReadLine());

                Console.WriteLine("How many doors?");
                int doors = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Is it manual? {true/false}");
                bool manual = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Which Company?");
                int company = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How many wheels?");
                int wheels = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Any message?");
                string msg = Console.ReadLine();

                Console.WriteLine("How many passengers?");
                int cap = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the length?");
                double len = Double.Parse(Console.ReadLine());

                Console.WriteLine("And weight?");
                double weight = Double.Parse(Console.ReadLine());

                View.AddCar(hp, eng, doors, manual, (Model.Companies)company, wheels, msg, cap, len, weight);
                Console.WriteLine("=======================================================================");
            }
            View.ListCars();
        }
    }
}
