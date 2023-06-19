namespace TheWarTime.Items;

public class Weapon : Item
{

    public int Damage { get; set; }
    
    public double CriticalStrike { get; set; }
    public Pistol Pistol { get; set; }
    public Knife Knife { get; set; }

    public virtual void Attack(ref double actualHealth)
    {
        throw new Exception("Weapon is too abstract");
    }
}