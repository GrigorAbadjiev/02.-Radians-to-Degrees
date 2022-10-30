using System;

namespace _02._Radians_to_Degrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //input
           double angleInRadians = double.Parse(Console.ReadLine());
            // calculate
            Double angleInDegrees = angleInRadians * 180 / Math.PI;
            // output
            Console.WriteLine(angleInDegrees);
        }
    }
}
