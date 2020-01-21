using System;
using System.Collections.Generic;

namespace C2W1Exercise3
{
    /// <summary>
    /// Exercise 3 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {   
            // Create a list and populate it with 1-10
            List<int> intList = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                intList.Add(i + 1);
            }
            // print the elems in the list
            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine(intList[i]);
            }

            // remove the even numbers from the list using backward forloop
            for (int i = intList.Count; i -- >0;)
            {
                if (intList[i] % 2 == 0)
                {
                    intList.Remove(intList[i]);
                }
            }
            // print the elems in the list
            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine(intList[i]);
            }

            // Create a list and populate it with 1-5
            for (int i = 0; i < 5; i++)
            {
                intList.Add(i + 1);
            }
            // print the elems in the list to see 2 and 3 get skipped over
            for (int i = 0; i < intList.Count; i++)
            {
                if ((intList[i] == 1) || (intList[i] == 2) || (intList[i] == 3))
                {
                    intList.Remove(intList[i]);
                }
            }
            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine(intList[i]);
            }
        }
    }
}
