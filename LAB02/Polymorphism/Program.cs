namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MechArm mechArm = new MechArm(MechArms.Crane);
            MechArm mechArm1 = new MechArm(MechArms.Transformer);
            MechArm mechArm2 = new MechArm(MechArms.AssemblyArm);

            PersonalComputer personalComputer = new(PersonalComputers.Laptop);
            PersonalComputer personalComputer2 = new(PersonalComputers.Station);
            PersonalComputer personalComputer3 = new(PersonalComputers.Console);


            Console.WriteLine("Daily Cost for {0} is {1} PLN", mechArm.Type, mechArm.AnnualCost(2020));
            Console.WriteLine("Daily Cost for {0} is {1} PLN", mechArm.Type, mechArm.AnnualCost(2023));
            Console.WriteLine("Daily Cost for {0} is {1} PLN", mechArm1.Type, mechArm1.AnnualCost(2022));
            Console.WriteLine("Daily Cost for {0} is {1} PLN", mechArm2.Type, mechArm2.AnnualCost(2022));
            Console.WriteLine("==============================================================================================");
            Console.WriteLine("Daily Cost for {0} is {1} PLN", personalComputer.ComputerType, personalComputer.AnnualCost(2020));
            Console.WriteLine("Daily Cost for {0} is {1} PLN", personalComputer.ComputerType, personalComputer.AnnualCost(2023));
            Console.WriteLine("Daily Cost for {0} is {1} PLN", personalComputer2.ComputerType, personalComputer2.AnnualCost(2022));
            Console.WriteLine("Daily Cost for {0} is {1} PLN", personalComputer3.ComputerType, personalComputer3.AnnualCost(2022));
        }
    }
}