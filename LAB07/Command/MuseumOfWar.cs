namespace Command
{
    public class MuseumOfWar
    {
        public double BuyTicket(double _cash, double _amount)
        {
            if (0 == _amount)
            {
                Console.WriteLine("Buying 1 ticket no matter what");
                _amount++;
            }
            Console.WriteLine($"Cost is {(99.99 * _amount)}");
            _cash -= (99.99 * _amount);
            return _cash;
        }
    }
}