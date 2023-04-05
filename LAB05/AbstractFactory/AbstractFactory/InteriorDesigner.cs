namespace AbstractFactory
{
    public abstract class InteriorDesigner
    {
        protected const Styles style = Styles.Classical;

        public abstract Desk CreateDesk(Desk type, int _priceLimit);
        public abstract Wardrobe CreateWardrobe(Wardrobe wardrobe, int _priceLimit);
    }

    public class ClassicDesigner : InteriorDesigner
    {
        
        public override Desk CreateDesk(Desk type, int _priceLimit)
        {
            var draftingTable = new DraftingTable(style);
            var adjustableDesk = new AdjustableDesk(style);
            var treadmillDesk = new TreadmillDesk(style);
        }

        public override Wardrobe CreateWardrobe(Wardrobe wardrobe, int _priceLimit)
        {
            throw new NotImplementedException();
        }
    }
}