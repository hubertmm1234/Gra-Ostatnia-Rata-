namespace OstatniaRata.OstatniaRata.App.UI;

public class UI
{


    public void beginOfGame(string nameOfhero)
    {
        Console.Clear();
        Console.WriteLine();
        Pisz($"Nazywasz się {nameOfhero}. Kiedyś miałeś drużynę, sprzęt i reputację.");
        Pisz("Potem przyszła wyprawa do Szarych Jaskiń. Wróciłeś sam,");
        Pisz("bez złota i bez ludzi, za to z długiem u człowieka,");
        Pisz("którego nikt nie nazywa po imieniu.");
        //Pauza();

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Pisz("Marian Kos. Księgowy.", 80);
        Console.ResetColor();
        //    Pauza();

        Console.WriteLine();
        Pisz("Nie podniósł głosu. Nie wyciągnął noża. Otworzył zeszyt,");
        Pisz("wpisał Twoje nazwisko i powiedział spokojnie:");
        //  Pauza();

        Console.ForegroundColor = ConsoleColor.Red;
        Pisz("\n  \"Pięćset złotych. Trzydzieści dni.", 60);
        Pisz($"   Księgowy nie zapomina, {nameOfhero}. Księgowy liczy.\"", 60);
        Console.ResetColor();
        //  Pauza(1800);

        Console.WriteLine();
        Pisz("Widziałeś, co się dzieje z tymi, którzy nie zdążyli.");
        Pisz("Jedni znikają. Inni wracają bez rąk.");
        //  Pauza();

        Console.WriteLine();
        Pisz("Została Ci jedna szansa: Lochy Karhelm.");
        Pisz("Mówią, że pod miastem leży skarb dawnego króla Władysława.");
        Pisz("Mówią też, że nikt, kto zszedł na dół, nie wrócił.");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Wcisnij dowolny przycisk by kontynuowac.");
        Console.ResetColor();
        Console.ReadKey();
        //  Pauza();
    }
   
    static void Pisz(string tekst, int opoznienie = 35)
    {
        foreach (char c in tekst)
        {
            Console.Write(c);
            if (Console.KeyAvailable)
            {
                Console.ReadKey(true);
                opoznienie = 0;
            }
            Thread.Sleep(opoznienie);
        }
        Console.WriteLine();
    }
    
    public void StatisticOfPlayer(int numOfTurns, int level, int actualLife, int maxLife, int power, int exp, int maxExp, int gold)
    {
        Console.WriteLine("╔═══════════════════════════════════════════════════════════════╗");
        Console.WriteLine($"║            \t    Tura: {numOfTurns}   Poziom: {level}  \t\t        ║");
        Console.WriteLine("║═══════════════════════════════════════════════════════════════║");
        Console.WriteLine("║                  ---=== STATYSTYKI ===---                     ║"); ;
        Console.Write("║  ZYCIE:" + actualLife+"/"+maxLife);
        Console.Write("   SILA:" + power);
        Console.Write("   Doswiadczenie " + exp+"/"+maxExp);
        Console.WriteLine("   Monety:" + gold + "  \t║");
        Console.WriteLine("╚═══════════════════════════════════════════════════════════════╝");
    }
    
    public void ChoosingActionScreen()
    {
        Console.WriteLine("╔════════════════════════╗");
        Console.WriteLine("║       CO ROBISZ?       ║");
        Console.WriteLine("╠════════════════════════╣");
        Console.WriteLine("║ 1. eksploracja         ║");
        Console.WriteLine("║ 2. Odpoczynek          ║");
        Console.WriteLine("║ 3. Ekwipunek           ║");
        Console.WriteLine("║ 4. WYJSCIE DO MENU     ║");
        Console.WriteLine("╚════════════════════════╝");
    }

    public void PreFightInfo()
    {
        
    }
}
