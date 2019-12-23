using System;

namespace Exercise4
{
    class Program
    {
        /// <summary>
        /// Prompt for and get the altitudes for 2 locations 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Enter first altitude: ");
            int firstAltitude = int.Parse(Console.ReadLine());
            Console.Write("Enter second altitude: ");
            int secondAltitude = int.Parse(Console.ReadLine());
            int altitudeChange = secondAltitude - firstAltitude;
            Console.WriteLine("Altitude Changed: " + altitudeChange);
        }
    }
}
