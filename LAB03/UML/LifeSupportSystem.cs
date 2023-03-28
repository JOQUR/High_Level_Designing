using System.Threading.Tasks;

namespace C3
{
    public class LifeSupportSystem
    {
        private readonly int hoursPerDay = 24;
        private List<OxygenBottle>? oxygenBottles;
        private FoodContainer? foodContainer;
        private Waste? waste;
        private List<Human>? crew;

        public LifeSupportSystem(List<OxygenBottle>? oxygenBottles, FoodContainer? foodContainer, Waste? waste, List<Human>? crew)
        {
            this.oxygenBottles = oxygenBottles;
            this.foodContainer = foodContainer;
            this.waste = waste;
            this.crew = crew;
        }

        public bool CheckSuppliesBeforeTravel(double travelTime)
        {
            if(oxygenBottles.Count < (0.01 * travelTime)) return false;
            else if(foodContainer.Weight < 1) return false;
            else if(crew.Count < (1)) return false;
            else return true;
        }

        public void Run(double travelTime)
        {
            for(int i = 0; i < travelTime / 10000; i++)
            {
                oxygenBottles[i].Volume -= 0.001;
            }       
            foodContainer.Volume -= 10;
            waste.Volume ++;
        }
    }
}
