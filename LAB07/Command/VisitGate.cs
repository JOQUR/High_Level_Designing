namespace Command
{
    public class VisitGate : IVisitTouristAttraction
    {
        private CityGate _cityGate = new CityGate();
        private int _time;

        public VisitGate()
        {
            _time = new Random().Next(0, 5);
        }

        public VisitGate(int _time)
        {
            this._time = _time;
        }
        public void Visit()
        {
            Console.Write(this._cityGate.TalkToStranger((uint)_time));
        }
    }
}