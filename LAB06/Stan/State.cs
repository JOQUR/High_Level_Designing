namespace Stan
{
    public abstract class State
    {
        protected DropOfWater? _droplet;

        public void SetContext(DropOfWater droplet) 
        {
            this._droplet = droplet;
        }

        public string Info()
        {
            return $"Droplet is in {this.GetType().Name}!";
        }
        public abstract void Raining(double _amount);
        public abstract void Breathing(double _capacity);
        public abstract void Evaporation(double _time);
        public abstract void Drinking(double _time);
        public abstract void Clearance();
        public abstract void Excretion();
        public abstract void Flowing();
    }
}