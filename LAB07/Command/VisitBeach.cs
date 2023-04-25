namespace Command
{
    public class VisitBeach : IVisitTouristAttraction
    {
        private Beach _beach = new Beach();
        private uint _amount = 1;
        private IceCreams _iceCreams = IceCreams.Chocolate;
        public VisitBeach(uint _amount)
        {
            this._amount = _amount;
        }

        public VisitBeach(uint _amount, IceCreams _iceCreams)
        {
            this._amount = _amount;
            this._iceCreams = _iceCreams;
        }
        public void Visit()
        {
            Program.Cash = this._beach.BuyIceCream(Program.Cash, this._amount, this._iceCreams);
        }
    }
}