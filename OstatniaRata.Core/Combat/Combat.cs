namespace OstatniaRata.OstatniaRata.Core.Combat;

public class Combat
{


    public int DealingDamage(int damage, int health)
    {
        Random rnd = new Random();
        damage = rnd.Next(damage-1, damage+1);
        
        return health-damage;
    }
}