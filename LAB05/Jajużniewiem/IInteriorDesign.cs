namespace Jajużniewiem
{
    public abstract class InteriorDesign
    {
        protected string? Style;
        public abstract Desk CreateDesk(DeskTypes type);
        public abstract Wardrobe CreateWardrobe();
    }
}
