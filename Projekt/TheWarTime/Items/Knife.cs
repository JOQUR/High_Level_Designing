namespace TheWarTime.Items;

public class Knife : Weapon
{
    public override void Attack(ref double actualHealth)
    {
        actualHealth -= (this.Damage);
    }
}