namespace C3
{
    public class OxygenBottle : IVisitPort
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
                _weight = _volume * 1000;
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
                _volume = _weight * 1000;
            }
        }

        public double MaxCapacity { get; }

        public OxygenBottle(double capacity) 
        {
            MaxCapacity = capacity;
        }

        public double VisitPort()
        {
            double left = MaxCapacity - Volume;
            Volume = MaxCapacity;
            return left * 5;
        }
    }
}
