namespace Jajużniewiem
{
    public class ClassicalDesign : InteriorDesign
    {
        public ClassicalDesign()
        {
            Style = "Classical";
        }

        

        public override Desk CreateDesk(DeskTypes type) 
        {
            switch(type)
            {
                case DeskTypes.Adjustable: return new AdjustableDesk(Style!, (int)type);
                case DeskTypes.Normal: return new AdjustableDesk(Style!, (int)type);
                case DeskTypes.Treadmill: return new AdjustableDesk(Style!, (int)type);
                default: return null!;
            }
            
        }

        public override Wardrobe CreateWardrobe()
        {
            return new Dresser();
        }

    }
}
