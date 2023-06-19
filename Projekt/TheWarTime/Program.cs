using TheWarTime.ConfigHandler;
using TheWarTime.Items;

namespace TheWarTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            using (var handler = new JsonHandler())
            {
                var pistol = handler.DeserializeRoot()!.Item.Weapon.Pistol;
                var knife  = handler.DeserializeRoot()!.Item.Weapon.Knife;
                var soupcan = handler.DeserializeRoot()!.Item.Food.SoupCan;
                Console.WriteLine("Pistol weight " + pistol!.Weight);
                Console.WriteLine("Knife weight " + knife!.Weight);
                Console.WriteLine("soupcan weight " + soupcan!.Weight);
            }

            Console.WriteLine("HI");
        }
    }
}