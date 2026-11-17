namespace OstatniaRata.OstatniaRata.Core.Characters;

public class Player
{
    public int Experience { get; protected set; }
    public int ExperienceMax { get; protected set; }
    
    public string Name { get; protected set; }
    
    public  int LifeActual{ get; protected set; }
    public  int LifeMax{ get; protected set; }
    
    public bool isLiving { get; protected set; }
    
    public  int Power{ get; protected set; }
    
    public int lvl{ get; protected set; }
    public int gold { get; protected set; }
    

    public Player(string name)
    {
        Name = name;
        LifeMax = 100;
        LifeActual = LifeMax;
        Power = 3;
        lvl = 1;
        gold = 0;

    }
    public bool TryingName(string NameOfHero)
    {
        if (NameOfHero == string.Empty)
        {
            Console.Write("PODAJ IMIE BOHATERA!");
            Console.WriteLine("");
            Console.WriteLine("     (Wcisni Dowolny Przycisk by kontynuowac)         ");
            Console.ReadKey();
            return false;
        }

        if (NameOfHero.Length < 3)
        {
            Console.Write("IMIE BOHATERA JEST ZA KROTKIE!");
            Console.WriteLine("");
            Console.WriteLine("     (Wcisni Dowolny Przycisk by kontynuowac)         ");
            Console.ReadKey();
            return false;
        }

        if (NameOfHero.Length > 10)
        {
            Console.WriteLine("IMIE BOHATERA JEST ZA DLUGIE!");
            Console.WriteLine("");
            Console.WriteLine("     (Wcisni Dowolny Przycisk by kontynuowac)         ");
            Console.ReadKey();
            return false;
        }
        return true;
    }

    public void NameChoose()
    {
        string nameOfHero = Name;
        
        bool prawidloweImie = false;
        while (!prawidloweImie)
        {
            Console.WriteLine(" ");
            Console.Write(    "║ Podaj imie: ");
            nameOfHero = Console.ReadLine();
            prawidloweImie= TryingName(nameOfHero); 
        }
        this.Name = nameOfHero;
        
    }

    public void Smierc()
    {
        Thread.Sleep(100);
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Thread.Sleep(100);
        Console.WriteLine("║                   UMARLES                  ║");
        Thread.Sleep(100);
        Console.WriteLine("╚════════════════════════════════════════════╝" );
        isLiving = false;
    }

}