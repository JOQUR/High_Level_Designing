namespace Polymorphism
{
    public class MechArm : Robot
    {
        private const int electricityPrice = 1;
        private const int hoursPerDay = 16;
        private const int k = 1000;

        public MechArms Type { get; private set; }
        public MechArm(MechArms type)
        {
            PowerConsumption = (int)type;
            Type = type;
        }

        public override int AnnualCost(int year)
        {
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                return electricityPrice * PowerConsumption * k * hoursPerDay * (365); // return (price) * (powerConsumption) * (dailyHours) * (days)
            }
            else
            {
                return electricityPrice * PowerConsumption * k * hoursPerDay * (366); // return (price) * (powerConsumption) * (dailyHours) * (days)
            }
        }
    }
}