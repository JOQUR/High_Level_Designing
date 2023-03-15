namespace Polymorphism
{
    public class PersonalComputer : Robot
    {
        public bool InternetConnection { get; set; }
        public PersonalComputer(PersonalComputers type, bool isConnected)
        {
            PowerConsumption = (int)type;
            Type = type;
            InternetConnection = isConnected;
        }
        public override int AnnualCost(int year)
        {
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                return electricityPrice * PowerConsumption * hoursPerDay * (366); // return (price) * (powerConsumption) * (dailyHours) * (days)
            }
            else
            {
                return electricityPrice * PowerConsumption * hoursPerDay * (365); // return (price) * (powerConsumption) * (dailyHours) * (days)
            }
        }
    }
}