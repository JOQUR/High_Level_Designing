namespace AbstractFactory
{
    public class NightTable : Wardrobe
    {
        public bool HasLamp { get; set; }
        public NightTable(Styles _style) => Style = _style;

        public override bool storeItem(object _item)
        {
            return false;
        }
    }
}