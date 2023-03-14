namespace Polymorphism
{
    public class PersonalComputer : Robot
    {
        private const int electricityPrice = 1;
        private const int hoursPerDay = 8;
        public PersonalComputers ComputerType { get; private set; }
        public PersonalComputer(PersonalComputers type)
        {
            PowerConsumption = (int)type;
            ComputerType = type;
        }
        public override int AnnualCost(int year)
        {
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                return electricityPrice * PowerConsumption * hoursPerDay * (365); // return (price) * (powerConsumption) * (dailyHours) * (days)
            }
            else
            {
                return electricityPrice * PowerConsumption * hoursPerDay * (366); // return (price) * (powerConsumption) * (dailyHours) * (days)
            }
        }
    }
}