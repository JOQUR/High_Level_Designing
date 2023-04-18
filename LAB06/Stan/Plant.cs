namespace Stan
{
    public class Plant : State
    {
        public override void Breathing(double _capacity)
        {
            if (_capacity > 1)
                _droplet.TransitionTo(new Cloud());
        }

        public override void Clearance()
        {
        }

        public override void Drinking(double _time)
        {
        }

        public override void Evaporation(double _time)
        {
        }

        public override void Excretion()
        {
        }

        

        public override void Raining(double _amount)
        {

        }
        public override void Flowing()
        {

        }
    }
}