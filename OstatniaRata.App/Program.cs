
using OstatniaRata.OstatniaRata.App.UI;

bool menuBool = true;
bool startGry = false;

Player player = new Player("#");
UI gameUi = new UI();

GameCore gameCore = new GameCore();

int numOfTurn = 1;


while (menuBool) // Petla Menu Startowego Gry
{
    Console.Clear();
    Console.WriteLine("╔════════════════════════╗");
    Console.WriteLine("║       HIDDEN PATH      ║");
    Console.WriteLine("╠════════════════════════╣");
    Console.WriteLine("║      WITAJ W GRZE      ║");
    Console.WriteLine("║                        ║");
    Console.WriteLine("║  1. Nowa Gra           ║ ");
    Console.WriteLine("║  2. Wczytaj Gre        ║ ");
    Console.WriteLine("║  3. WYJDZ              ║ ");
    Console.WriteLine("╠════════════════════════╣");
    Console.Write("   podaj numer opcji: ");
    bool poprawnyFormat =int.TryParse(Console.ReadLine(),out int menuWybor);

    switch (menuWybor)
    {
        case 1:
            Console.Clear();
            menuBool = true;
            startGry = true;
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("BAJO JAJO JESZCZE NIE ZROBIONE :)");
            Console.WriteLine("Kliknij cokolwiek");
            Console.ReadKey();
            Console.Clear();
            break;
        case 3:
            Console.Clear();
            menuBool = false;
            startGry =false;
            break;
        default:
            Console.WriteLine("Blad! nie ten klawisz!");
            Console.Clear();
            break;
    }

    if (startGry) // Gdy Gracz wybierze opcje Nowej Gry
    {
        player.NameChoose();
        gameUi.beginOfGame(player.Name);

        while (startGry)
        {
            bool goodChoose = false;
            int mainGameChoose =0;
            while (!goodChoose)
            {
                Console.Clear();
                gameUi.StatisticOfPlayer(numOfTurn, player.lvl, player.LifeActual, player.LifeMax, player.Power,
                    player.Experience, player.ExperienceMax, player.gold);
                gameUi.ChoosingActionScreen();
                goodChoose = int.TryParse(Console.ReadLine(),out mainGameChoose);
            }

            switch (mainGameChoose)
            {
                case 1:
                    numOfTurn++;
                    Console.Clear();
                    bool chanceOfMonster = gameCore.ChanceOfSpawnMonster(8);
                    
                    if (chanceOfMonster == true)
                    {
                        Monster monster = new Monster();
                        Combat combat = new Combat();
                        
                        
                    }
                break;
                
            }
            
            Console.ReadKey();
        }
        
    }

}