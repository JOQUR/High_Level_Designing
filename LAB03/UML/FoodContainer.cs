namespace C3
{
    public class FoodContainer : IVisitPort
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
                _weight = _volume * 0.5;
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
                _volume = _weight * 0.5;
            }
        }
        public double MaxCapacity { get; }

        public FoodContainer(double capacity)
        {
            MaxCapacity = capacity;
        }
        public double VisitPort()
        {
            double left = MaxCapacity - Volume;
            Volume = MaxCapacity;
            return left;
        }
    }
}
