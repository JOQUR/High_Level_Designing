namespace Command
{
    /// <summary>
    /// Visiting Triton Fountain
    /// </summary>
    public class TritonFountain
    {
        public double TossCoin(double cash, double _howmanycoins)
        {
            return cash < _howmanycoins ? throw new ArgumentException("You cannot afford that") : cash - _howmanycoins;
        }
        public double Swim(double cash)
        {
            Console.WriteLine("Pay 300$ fine");
            return cash -= 300;
        }
    }
}