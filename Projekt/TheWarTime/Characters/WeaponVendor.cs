using TheWarTime.Items;

namespace TheWarTime.Characters;

public class WeaponVendor
{
    public int Pistol { get; set; }
    public int? Ammunition { get; set; }
    public int? Knife { get; set; }
    public List<PistolPerk> PistolPerks { get; set; }
    public List<KnifePerk> KnifePerks { get; set; }
}