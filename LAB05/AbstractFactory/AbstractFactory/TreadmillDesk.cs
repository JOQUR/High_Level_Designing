namespace AbstractFactory
{
    public class TreadmillDesk : Desk
    {
        public double Speed { get; set; }
        public TreadmillDesk(Styles _style) => Style = _style;

        public void UseTreadmill(double _time, double _speed)
        {
            Speed = _speed;
            while(_time > 0)
            {
                Console.WriteLine("Exercising");
                _time--;
            }
            Speed = 0;
        }
    }
}