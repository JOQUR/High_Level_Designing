namespace C3
{
    public class Engine
    {
        private const int hoursPerDay = 24;
        private FuelTank? tank;
        private Waste? waste;
        private int fuelCoeff;

        public Engine(FuelTank tank, Waste waste) 
        {
            this.tank = tank;
            this.waste = waste;
            fuelCoeff = (this.tank.CheckFuelMaterial() == "nuclear") ? 2 : 1;
        }

        public double GetVelocity(double submarineWeight) => (submarineWeight / 1000) * fuelCoeff;
        public bool CheckFuelBeforeTravel(double travelTime) => (tank.Volume / ((int)travelTime % hoursPerDay)) > 1;
        public void Travel(double travelTime)
        {
            tank.Volume--;
            waste.Volume++;
        }
    }
}
