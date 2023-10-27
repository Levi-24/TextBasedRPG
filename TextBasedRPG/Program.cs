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

                        Character character = new Character();
                        Console.Write("Choose a name: ");
                        character.Name = Console.ReadLine();

                        Console.WriteLine("Choose a class:");
                        Console.WriteLine("\tKnight = K");
                        Console.WriteLine("\tMage = M");
                        ConsoleKey classSelect = Console.ReadKey().Key;
                        do
                        {
                            
                            switch (classSelect)
                            {
                                //Knight class selected
                                case ConsoleKey.K:
                                    character.Class = true;
                                    break;
                                //Mage class selected
                                case ConsoleKey.M:
                                    character.Class = false;
                                    break;
                                //Invalid class selection
                                default:
                                    Console.WriteLine("Please choose a valid class.");
                                    classSelect = Console.ReadKey().Key;
                                    break;
                            }
                        } while (classSelect != ConsoleKey.K || classSelect != ConsoleKey.M);

                        Console.WriteLine("--------------");
                        Console.WriteLine(character.Name);
                        Console.WriteLine(character.Class);
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