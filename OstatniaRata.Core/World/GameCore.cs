namespace OstatniaRata.OstatniaRata.Core.World;

public class GameCore
{
    public bool ChanceOfSpawnMonster(int chance)
    {
        bool is_Alive = false;
        Random random = new Random();
        int x = random.Next(0, 10);
        if (x < chance)
        {
            is_Alive = true;
        }
        else
        {
            is_Alive = false;
        }
        return is_Alive;
    }
}