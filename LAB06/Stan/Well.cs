namespace Stan
{
    public class Well : State
    {
        public override void Breathing(double _capacity)
        {
            
        }

        public override void Clearance()
        {
        }

        public override void Drinking(double _time)
        {
            if(_time > 0)
            {
                _droplet.TransitionTo(new Human());
            }
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