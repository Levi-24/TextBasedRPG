namespace DisplayMethods
{
    internal class Program
    {
        public void MainScreen()
        {
            Console.WriteLine("XxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXx");
            Console.WriteLine(@"
                                                                       
                                _-_ _,,   ,,                ,, ,,                 |\   
                                   -/  )  ||                || ||      _           \\  
                                  ~||_<   ||  /'\\  /'\\  /-|| ||/|,  < \, \\/\\  / \\ 
                                   || \\  || || || || || || || || ||  /-|| || || || || 
                                   ,/--|| || || || || || || || || |' (( || || || || || 
                                  _--_-'  \\ \\,/  \\,/   \\/  \\/    \/\\ \\ \\  \\/  
                                 (                                                     

                              ");
            Console.WriteLine("XxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXx");
            Console.WriteLine("This is a basic text based RPG made for fun.");
            Console.WriteLine("Please choose from the options below:");
            Console.WriteLine("\t1. Start New Game");
            Console.WriteLine("\t2. Load Game");
            Console.WriteLine("\t3. Exit");
        }
        public void RemoveLastCharacter()
        {
            int currentLeft = Console.CursorLeft;
            int currentTop = Console.CursorTop;
            Console.SetCursorPosition(currentLeft - 1, currentTop);
            Console.Write(' ');
        }
    }
}