using System;

namespace C2exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************");
            Console.WriteLine("1 - NewGame");
            Console.WriteLine("2 - LoadGame");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("**************");
            //print appropriate message according to the userInput
            while (true)
            {
                Console.Write("Please give your choice: ");
                int userInput = int.Parse(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Starting a new game...\n");
                        break;
                    case 2:
                        Console.WriteLine("Loading game...\n");
                        break;
                    case 3:
                        Console.WriteLine("Loading Options...\n");
                        break;
                    case 4:
                        // Exit the Console App when pressing Enter
                        Console.WriteLine("Quitting game...\n");
                        Console.Write("Press <Enter> to exit... ");
                        while (Console.ReadKey().Key == ConsoleKey.Enter) {
                            Environment.Exit(0);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input, please give input from 1 to 4.");
                        break;
                }
            }
        }
    }
}
