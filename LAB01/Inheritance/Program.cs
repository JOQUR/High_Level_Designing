using Inheritance.View;
using System;
using System.Collections.Generic;

namespace Inheritance
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            View.View view = new View.View(200, 5.0, 5, true, (Model.Companies)3, 4, "UA", 2, 3, 1100);
            view = new View.View(450, 7.0, 3, true, Model.Companies.Ferrari, 4, "Fast", 2, 3, 900);
            view = new View.View(100, 1.2, 5, true, Model.Companies.Skoda, 4, "hmm", 2, 3.5, 1300);
            view = new View.View(150, 1.5, 5, true, Model.Companies.Ford, 4, "Fast", 2, 3, 1100);

            View.View.ListCars();
        }
    }
}
