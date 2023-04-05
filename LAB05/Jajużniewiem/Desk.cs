namespace Jajużniewiem
{
    public abstract class Desk : IFurniture
    {
        public int Price;
        public string? Color;

        public abstract void assemble();
    }
}
