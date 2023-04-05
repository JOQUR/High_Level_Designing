namespace Jajużniewiem
{
    public class AdjustableDesk : Desk
    {
        public AdjustableDesk(string style, int price)
        {
            Price = price;
            Console.WriteLine($"Created {style} desk");
        }
        public override void assemble()
        {
            Console.WriteLine($"AdjustingDesk costs {Price}");
        }
    }
}
