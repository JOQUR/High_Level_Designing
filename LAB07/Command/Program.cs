namespace Command
{
    internal class Program
    {
        public static double Cash = 2000;
        static void Main(string[] args)
        {
            Console.WriteLine($"You have {Cash}$");
            TripScheduler tripScheduler = new TripScheduler();

            Console.WriteLine("|=============== Scenario 1 ===================|");
            // 1st Scenario
            List<IVisitTouristAttraction> directions = new List<IVisitTouristAttraction>
            {
                new VisitFountain(), new VisitMuseum(3, Tickets.HalfPrice), new VisitGate(), new VisitBeach(2, IceCreams.Strawberry)
            };

            foreach( var direction in directions )
            {
                tripScheduler.Direction(direction);
                tripScheduler.Trip();
                Console.WriteLine($"You have {Cash}$");
            }

            Console.WriteLine("|=============== Scenario 2 ===================|");
            // 2nd Scenario
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

            Console.WriteLine("|=============== Scenario 3 ===================|");
            // 3rd Scenario
            directions = new List<IVisitTouristAttraction>
            {
                new VisitFountain(5), new VisitMuseum(4, Tickets.Student), new VisitGate(4), new VisitBeach(1)
            };

            foreach (var direction in directions)
            {
                tripScheduler.Direction(direction);
                tripScheduler.Trip();
                Console.WriteLine($"You have {Cash}$");
            }
        }
    }
}