using DisplayMethods;

namespace TextBasedRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayMethods.Program DisplayMethods = new DisplayMethods.Program();
            DisplayMethods.MainScreen();
            ConsoleKey titleScreenSelect = Console.ReadKey().Key;
            switch (titleScreenSelect)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("You chose to start a new game.");
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("You chose to load a game.");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You chose to exit.");
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}