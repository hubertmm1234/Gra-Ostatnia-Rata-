namespace OstatniaRata.OstatniaRata.Core.Characters;

public class Monster
{
    protected int ExpierienceToGet;
    public string[] Monsters = new[] { "Goblin ", "Zombi", "Umarly Rycerz" };

    public int Power { get;protected set; }
    public int Health { get; protected set; }
    public string Name { get; protected set; }

    public Monster()
    {
        Random rnd =  new Random();
        int type = rnd.Next(0, Monsters.Length);
        this.Name = Monsters[type] += " ";

        if (Name == "Goblin")
        {
            Power =  rnd.Next(2,5);
            Health = rnd.Next(8,12);
        }
        else if (Name == "Zombi")
        {
            Power = rnd.Next(3,6);
            Health = rnd.Next(9,12);
        }
        else if (Name == "Umarly Rycerz")
        {
            Power = rnd.Next(5,10);
            Health = rnd.Next(12,16);
        }
        
    }
    
   
    



}

