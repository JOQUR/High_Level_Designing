namespace TheWarTime.Items;

public class Pistol : Weapon
{
    public override void Attack(ref double actualHealth)
    {
        actualHealth -= (this.Damage + (this.CriticalStrike * Damage));
    }
}