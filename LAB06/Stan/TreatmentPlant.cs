namespace Stan
{
    public class TreatmentPlant : State
    {
        public override void Breathing(double _capacity)
        {

        }

        public override void Clearance()
        {
            _droplet.TransitionTo(new River());
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

        public override void Flowing()
        {

        }

       

        public override void Raining(double _amount)
        {

        }
    }
}