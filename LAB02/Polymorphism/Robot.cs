
namespace Polymorphism
{

    public abstract class Robot
    {
        protected const int electricityPrice = 1;
        protected const int hoursPerDay = 16;
        protected const int k = 1000;
        public object? Type { get; protected set; }

        public int PowerConsumption { get; protected set; }
        public abstract int AnnualCost(int year);
    }

}
