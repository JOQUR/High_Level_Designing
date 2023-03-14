
namespace Polymorphism
{

    public abstract class Robot 
    {
        public int PowerConsumption { get; protected set; }
        public abstract int AnnualCost(int year);
    }

}
