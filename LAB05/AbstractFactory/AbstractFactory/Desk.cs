namespace AbstractFactory
{
    public abstract class Desk
    {
        public int Price { get; set; }
        public string? Color { get; set; }
        public Styles Style { get; set; }
        public Desk()
        {

        }
    }
}