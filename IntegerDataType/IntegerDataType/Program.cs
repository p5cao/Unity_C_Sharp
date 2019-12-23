using System;

namespace IntegerDataType
{
    /// <summary>
    /// Integer Data Types Lecture Code
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates integer datatypes
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int totalSecondsPlayed = 100;
            const int SecondsPerMinute = 60; 
            // calculate minutes and seconds played
            int minutesPlayed = totalSecondsPlayed / SecondsPerMinute;
            int secondsPlayed = totalSecondsPlayed % SecondsPerMinute;
            // print results
            Console.WriteLine("Minutes Played:" + minutesPlayed);
            Console.WriteLine("Seconds Played:" + secondsPlayed);
            Console.WriteLine();
        }
    }
}
