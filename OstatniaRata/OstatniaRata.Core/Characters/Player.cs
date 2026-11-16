namespace OstatniaRata.OstatniaRata.Core.Characters;

public class Player
{
    public int Experience { get; protected set; }
    public int ExperienceMax { get; protected set; }
    
    public string Name { get; protected set; }
    
    public  int LifeActual{ get; protected set; }
    public  int LifeMax{ get; protected set; }
    
    public  int Power{ get; protected set; }

    public Player(string name)
    {
        Name = name;
        LifeMax = 100;
        LifeActual = LifeMax;
        Power = 3;
        
    }
    
}