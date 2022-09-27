using System;

namespace P01_ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            float km = (float)(meters * 1.0 / 1000);

            Console.WriteLine($"{km:f2}");
        }
    }
}
