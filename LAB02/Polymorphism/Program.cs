namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lists
            List<Robot> robots = new List<Robot>
            { 
                new MechArm(MechArms.Crane),
                new MechArm(MechArms.Transformer),
                new MechArm(MechArms.AssemblyArm)
            };

            List<PersonalComputer> computers = new List<PersonalComputer>()
            {
                new PersonalComputer(PersonalComputers.Laptop, true),
                new PersonalComputer(PersonalComputers.Station, false),
                new PersonalComputer(PersonalComputers.Console, false),
                new PersonalComputer(PersonalComputers.Console, true),
            };

            List<Human> humans = new List<Human>
            {
                new PhysicalWorker(4000, "John"),
                new PhysicalWorker(3500, "Andrew"),
                new OfficeWorker(7000, "Paweł", true),
                new OfficeWorker(7000, "Sarah", true),
                new OfficeWorker(12000, "Xardas", true),
            };
            robots.AddRange(computers);
            #endregion

            #region Listing bill and state of network
            Console.WriteLine("Total electrecity bill for 2022 year is {0} PLN", getElectricityBill(2022, robots));
            Console.WriteLine("Total electrecity bill for 2020 year is {0} PLN", getElectricityBill(2020, robots));
            Console.WriteLine("For last year we spend {0} PLN for salaries", getTotalSalaries(12, humans));
            Console.WriteLine("For last half year we spend {0} PLN for salaries", getTotalSalaries(6, humans));
            fixConnectivity(computers);
            #endregion
        }
        #region Helper Methods
        static int getElectricityBill(int year, List<Robot> robots)
        {
            int retVal = 0;
            foreach (var item in robots)
            {
                retVal += item.AnnualCost(year);
            }
            return retVal;
        }

        static int getTotalSalaries(int months, List<Human> humans)
        {
            int retVal = 0;
            foreach (var item in humans) 
            {
                retVal += item.Cost(months);
            }
            return retVal;
        }

        static void fixConnectivity(List<PersonalComputer> computers)
        {
            foreach (var item in computers)
            {
                if (!item.InternetConnection)
                {
                    Console.WriteLine("We need to fix connectivity for {0}", item.Type);
                    Console.WriteLine("*Fixing wires*");
                    item.InternetConnection = true;
                }
            }
            Console.WriteLine("Connectivity in our company is in ideal state :)");
        }
        #endregion
    }
}