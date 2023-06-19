namespace TheWarTime.Characters;

public class Vendor
{
    public int Money { get; set; }
    public List<WeaponVendor> WeaponVendor { get; set; }
    public List<FoodVendor> FoodVendor { get; set; }
}