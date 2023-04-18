namespace Stan
{
    public class Cloud : State
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
        }

        public override void Excretion()
        {
        }


        public override void Raining(double _amount)
        {
            if(_amount < 50)
            {
                this._droplet.TransitionTo(new Plant());
            }
            else if((_amount >= 50) && (_amount < 100))
            {
                this._droplet.TransitionTo(new Well());
            }
            else if (_amount >= 100)
            {
                this._droplet.TransitionTo(new River());
            }
        }
        public override void Flowing()
        {

        }
    }
}