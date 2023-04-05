namespace AbstractFactory
{
    public class Dresser : Wardrobe
    {
        public int NumberofDrawers { get; set; }

        public Dresser(Styles _style) => Style = _style;
        public override bool storeItem(object _item)
        {
            return false;
        }
    }
}