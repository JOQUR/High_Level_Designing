namespace Stan
{
    public class River : State
    {
        public override void Breathing(double _capacity)
        {
            
        }

        public override void Clearance()
        {
        }

        public override void Drinking(double _time)
        {
            if (_time > 0)
            {
                _droplet.TransitionTo(new Animal());
            }
        }

        public override void Evaporation(double _time)
        {
            _droplet.TransitionTo(new Cloud());
        }

        public override void Excretion()
        {
        }

        

        public override void Raining(double _amount)
        {

        }
        public override void Flowing()
        {
            _droplet.TransitionTo(new Ocean());
        }
    }
}