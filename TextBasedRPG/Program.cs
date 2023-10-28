using DisplayMethods;

namespace TextBasedRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayMethods.Program DisplayMethods = new DisplayMethods.Program();
            DisplayMethods.MainScreen();

            bool exit = false;
            while (!exit)
            {
                ConsoleKey titleScreenSelect = Console.ReadKey().Key;
                switch (titleScreenSelect)
                {
                    //New Game
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine("You chose to start a new game.");

                        Console.Write("Choose a name: ");
                        string Name = Console.ReadLine();
                        
                        string[] StatusEffects = new string[] { "None" };

                        Character character = new Character(Name, StatusEffects);
                        StreamWriter writer = new StreamWriter($@"..\..\..\Characters\{character.Name}.txt");
                        writer.WriteLine($"{character.Name};{character.Level};{character.Experience};{character.Health};{character.Stamina};{character.StatusEffects};{character.Strength};{character.Speed};{character.Luck};{character.Gold};{character.StatPoints}");
                        writer.Close();
                        break;
                        //Load Game
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("You choose to load your game.");
                        break;
                        //Exit
                    case ConsoleKey.D3:
                        exit = true;
                        break;
                    default:
                        exit = true;
                        break;
                }

         
            }
        }
    }
}