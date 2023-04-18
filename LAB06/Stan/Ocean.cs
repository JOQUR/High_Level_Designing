namespace Stan
{
    public class Ocean : State
    {
        public override void Breathing(double _capacity)
        {
            
        }

        public override void Clearance()
        {
            
        }

        public override void Drinking(double _time)
        {
            
        }

        public override void Evaporation(double _time)
        {
            if(_time > 0)
            {
                _droplet.TransitionTo(new Cloud());
            }
        }

        public override void Excretion()
        {
            
        }

        public override void Flowing()
        {
            
        }


        public override void Raining(double _amount)
        {
            
        }
    }
}