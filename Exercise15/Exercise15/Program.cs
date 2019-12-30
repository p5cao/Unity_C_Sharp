using System;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            //print out the menu options
            Console.WriteLine("************");
            Console.WriteLine("Menu:\n" +
                "1 - NewGame\n"+
                "2 - LoadGame\n"+
                "3 - Options\n"+
                "4 - Quit");
            Console.WriteLine("************");
            Console.Write("Please give your choice: ");
            int userInput = int.Parse(Console.ReadLine());
            //print appropriate message according to the userInput
            switch(userInput)
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
                    Console.WriteLine("Quitting game...\n");
                    break;
                default:
                    Console.WriteLine("Invalid input, please give input from 1 to 4.");
                    break;
            }
        }
    }
}
