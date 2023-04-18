namespace Stan
{
    public class DropOfWater
    {
        private State? _state = null;
        public DropOfWater() 
        {
        }

        public void TransitionTo(State state)
        {
            this._state = state;
            Console.WriteLine(_state.Info()); ;
            this._state.SetContext(this);
        }
        public void Breathing(double _capacity)
        {
            this._state.Breathing(_capacity);
        }

        public void Clearance()
        {
            this._state.Clearance();
        }

        public void Drinking(double _time)
        {
            this._state.Drinking(_time);
        }

        public void Evaporation(double _time)
        {
            this._state.Evaporation(_time);
        }

        public void Excretion()
        {
            this._state.Excretion();
        }

        public void Flowing()
        {
            this._state.Flowing();
        }

        public void Raining(double _amount)
        {
            this._state.Raining(_amount);
        }
    }
}