namespace Command
{
    public class VisitFountain : IVisitTouristAttraction
    {
        private int _tossed;
        private TritonFountain _tritonFountain = new TritonFountain();

        public VisitFountain()
        {
            this._tossed = new Random().Next(2, 10);
        }
        public VisitFountain(int _tossed)
        {
            this._tossed = _tossed;
        }
        public void Visit()
        {
            int _caught = new Random().Next(0, 2);
            Program.Cash = this._tritonFountain.TossCoin(Program.Cash, _tossed);
            if (0 != _caught) Program.Cash = this._tritonFountain.Swim(Program.Cash);
        }
    }
}