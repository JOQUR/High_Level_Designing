namespace Polymorphism
{
    public class PhysicalWorker : Human
    {
        private const int healthCare = 500;

        public PhysicalWorker(int salary, string name)
        {
            Salary = salary;
            Name = name;
        }

        public override int Cost(int months) => (Salary + healthCare) * months;
    }
}