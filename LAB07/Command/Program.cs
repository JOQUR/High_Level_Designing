namespace Command
{
    internal class Program
    {
        public static double Cash = 1000;
        static void Main(string[] args)
        {
            #region Initialize Trip Scheduler
            Console.WriteLine($"You have {Cash}$");
            TripScheduler tripScheduler = new TripScheduler();
            #endregion


            #region Scenario 1
            Console.WriteLine("|=============== Scenario 1 ===================|");
            List<IVisitTouristAttraction> directions = new List<IVisitTouristAttraction>
            {
                new VisitMuseum(3, Tickets.HalfPrice), new VisitFountain(), new VisitBeach(2, IceCreams.Strawberry), new VisitGate()
            };

            foreach( var direction in directions )
            {
                tripScheduler.Direction(direction);
                tripScheduler.Trip();
                Console.WriteLine($"You have {Cash}$");
            }
            #endregion


            #region Scenario 2
            Console.WriteLine("|=============== Scenario 2 ===================|");
            Cash += 500;
            directions = new List<IVisitTouristAttraction>
            {
                new VisitFountain(3), new VisitMuseum(5, Tickets.Normal), new VisitGate(1), new VisitBeach(3, IceCreams.Caramel)
            };

            foreach (var direction in directions)
            {
                tripScheduler.Direction(direction);
                tripScheduler.Trip();
                Console.WriteLine($"You have {Cash}$");
            }
            #endregion


            #region Scenario 3
            Console.WriteLine("|=============== Scenario 3 ===================|");
            Cash += 500;
            directions = new List<IVisitTouristAttraction>
            {
                 new VisitBeach(1),  new VisitGate(4), new VisitMuseum(4, Tickets.Student), new VisitFountain(5)
            };

            foreach (var direction in directions)
            {
                tripScheduler.Direction(direction);
                tripScheduler.Trip();
                Console.WriteLine($"You have {Cash}$");
            }
            #endregion
        }
    }
}