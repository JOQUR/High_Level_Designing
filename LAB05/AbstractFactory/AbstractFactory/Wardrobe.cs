namespace AbstractFactory
{
    public abstract class Wardrobe
    {
        public int Price { get; set; }
        public string? Color { get; set; }
        public double Capacity { get; set; }
        public Styles Style { get; set; }

        public abstract bool storeItem(object _item);
    }
}