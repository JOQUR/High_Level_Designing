namespace AbstractFactory
{
    public class CornerWardrobe : Wardrobe
    {
        public int NumberofShelves { get; set; }
        public CornerWardrobe(Styles _style) 
        {
            Style = _style;
        }

        public override bool storeItem(object _item)
        {
            return false;
        }
    }
}