namespace C3
{
    public abstract class Human : ITransportable
    {
        private double _weight, _volume;
        public double Volume 
        { 
            get 
            { 
                return _volume; 
            } 
            set 
            { 
                _volume = value; 
                _weight = _volume * 1; 
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
                _volume = _weight * 1; 
            } 
        }
    }
}
