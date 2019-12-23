using System;
namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {   ///Prompt for and get an angle in degrees and store it in a float variable.
            Console.Write("Enter an angle in degrees:");
            float angle = float.Parse(Console.ReadLine());
            ///Convert angle to radians
            angle = angle / 180 * (float)Math.PI;
            ///Calculate and display the cosine and sine of the angle.
            float cosine = (float)Math.Cos(angle);
            float sine = (float)Math.Sin(angle);
            Console.WriteLine("Cosine of the angle:" + cosine);
            Console.WriteLine("Sine of the angle:" + sine);
        }
    }
}
