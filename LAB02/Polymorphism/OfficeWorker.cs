namespace Polymorphism
{
    public class OfficeWorker : Human
    {
        public bool InternetConnection { get; set; }
        public OfficeWorker(int salary, string name, bool isConnected)
        {
            Salary = salary;
            Name = name;
            InternetConnection = isConnected;
        }
        public override int Cost(int months) => (Salary * months) + ((0 == months % 2) ? (Salary / 6) : 0);
    }
}