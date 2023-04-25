namespace Command
{
    public class Beach
    {
        public double BuyIceCream(double _cash, uint _amount, IceCreams _iceCreams)
        {
            _cash -= ((int)_iceCreams * 3 * _amount);
            return _cash;
        }
    }
}