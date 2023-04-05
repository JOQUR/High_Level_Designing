namespace AbstractFactory
{
    public class DraftingTable : Desk
    {
        public bool hasDrawers { get; set; }
        public DraftingTable(Styles _style) => Style = _style;
    }
}