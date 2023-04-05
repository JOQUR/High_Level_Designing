namespace Jajużniewiem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IFurniture> furniture = new List<IFurniture>();
            furniture.Add(new ClassicalDesign().CreateDesk(DeskTypes.Adjustable));
            furniture.Add(new ClassicalDesign().CreateDesk(DeskTypes.Treadmill));
            furniture.Add(new ClassicalDesign().CreateDesk(DeskTypes.Normal));

            foreach(var a in furniture)
            {
                a.assemble();
            }
        }
    }
}
