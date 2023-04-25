namespace Command
{
    /// <summary>
    /// Invoker
    /// </summary>
    public class TripScheduler
    {
        private IVisitTouristAttraction? _direction;

        public void Direction(IVisitTouristAttraction attraction)
        {
            _direction = attraction;
        }

        public void Trip()
        {
            if(this._direction is IVisitTouristAttraction)
            {
                this._direction.Visit();
            }
        }
    }
}