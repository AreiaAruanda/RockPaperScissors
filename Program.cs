using RockPaperScissors;
using System.ComponentModel.Design;
using System.Xml.Linq;
public class Program
{
     public static void Main(string[] args)
    {
        Console.WriteLine("ROCK PAPER SCISSORS");

        //create players
        List<Player> players = new List<Player>();
        for (int i = 1; i < 3; i++)
        {
            Console.WriteLine($"\nWho is playing? Please enter a name for player {i}:");
            string name = Console.ReadLine();

            Player player = new Player(name);
            players.Add(new Player(name));
        }

        Console.Clear();
        Console.WriteLine($"Welcome {players[0].Name} and {players[1].Name}. Let the game begin!\n");
        Console.ReadKey();
        Console.Clear();

        int won = 0;
        int lost = 0;
        int drew = 0;

        for (int round = 1; round < 4; round++)
        {
            
            Console.WriteLine($"Round {round}/3:\n");
            players[0].MakeChoice();
            Console.Clear();
            Console.WriteLine($"Round {round}/3:\n");
            players[1].MakeChoice();
            Console.Clear();
            Console.WriteLine($"Round {round}'s result for {players[0].Name}: {GameOutcome(players[0], players[1])}\n");
            Console.ReadKey();
            Console.Clear();
            if (GameOutcome(players[0], players[1]) == Result.Win)
                won++;
            else if (GameOutcome(players[0], players[1]) == Result.Lose)
                lost++;
            else if (GameOutcome(players[0], players[1]) == Result.Draw)
                drew++;
        }

        //final result of the 3 rounds
        if (won >= 2)
            Console.WriteLine($"{players[0].Name} won the game.");

        if (lost >= 2)
            Console.WriteLine($"{players[0].Name} lost the game.");

        if (drew == 3 || (drew==1 && won==1 && lost ==1))
            {
            Console.WriteLine($"This game was even.");
        }


        Result GameOutcome(Player p1, Player p2)
        {
            switch (p1.Selection)
            {
                case Choice.Rock:
                    switch (p2.Selection)
                    {
                        case Choice.Rock: return Result.Draw;
                        case Choice.Paper: return Result.Lose;
                        case Choice.Scissors: return Result.Win;
                        default: return Result.Invalid;
                    }

                case Choice.Paper:
                    switch (p2.Selection)
                    {
                        case Choice.Rock: return Result.Win;
                        case Choice.Paper: return Result.Draw;
                        case Choice.Scissors: return Result.Lose;
                        default: return Result.Invalid;
                    }

                case Choice.Scissors:
                    switch (p2.Selection)
                    {
                        case Choice.Rock: return Result.Lose;
                        case Choice.Paper: return Result.Win;
                        case Choice.Scissors: return Result.Draw;
                        default: return Result.Invalid;
                    }

                default: return Result.Invalid;
            }
        }
    }
}




