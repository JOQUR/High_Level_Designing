namespace C3
{
    public class Waste : IVisitPort
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
                _weight = _volume * 1.4;
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
                _volume = _weight * 1.4;
            }
        }
        public double VisitPort()
        {
            Volume = 0;
            return Volume * 50;
        }
    }
}
