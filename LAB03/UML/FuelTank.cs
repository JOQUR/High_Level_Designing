namespace C3
{
    public class FuelTank : IVisitPort
    {
        private double _volume, _weight;
        public double Volume
        {
            get
            {
                return _volume;
            }
            set
            {
                _volume = value;
                _weight = _volume * 2;
            }
        } 
        public double Weight 
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
                _volume = _weight * 2;
            }
        }
        public double MaxCapacity { get; }
        private Fuel fuel;


        public FuelTank(double capacity, Fuel fuel)
        {
            MaxCapacity = capacity;
            this.Volume = fuel.Volume;
            this.fuel = fuel;
        }
        public double VisitPort()
        {
            double left = MaxCapacity - Volume;
            Volume = left + Volume;
            return left * ((CheckFuelMaterial() == "nuclear") ? 1.5 : 1) * 10000;
        }

        public string? CheckFuelMaterial() => fuel.Material;
    }
}
