namespace Command
{
    public class VisitMuseum : IVisitTouristAttraction
    {
        private MuseumOfWar _museum = new MuseumOfWar();
        private double _amount;

        public VisitMuseum()
        {
            _amount = new Random().Next(0, 6);
        }
        public VisitMuseum(int _amount)
        {
            this._amount = _amount;
        }
        public VisitMuseum(int _amount, Tickets _ticket)
        {
            this._amount = _amount;
            switch (_ticket)
            {
                case Tickets.Normal:
                    this._amount = (this._amount * 1.0);
                    break;
                case Tickets.HalfPrice:
                    this._amount = (this._amount * 0.5);
                    break;
                case Tickets.Student:
                    this._amount = (this._amount * 0.75);
                    break;
            }
        }
        public void Visit()
        {
            Program.Cash = this._museum.BuyTicket(Program.Cash, _amount);
        }
    }
}