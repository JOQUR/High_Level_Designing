namespace C3
{
    public abstract class Fuel : ITransportable
    {
        private double _volume, _weight;
        private string? _material;
        public string? Material
        {
            get
            {
                return _material;
            }
            set
            {
                _material = value;
            }
        }
        public double Volume
        {
            get
            {
                return _volume;
            } 
            set
            {
                _volume = value;
                _weight = (density / _volume);
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
                _volume = (density * _weight);
            }
        }

        protected double density;

    }
}
