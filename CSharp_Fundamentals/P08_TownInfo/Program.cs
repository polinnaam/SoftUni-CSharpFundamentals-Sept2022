using System;

namespace P08_TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Town {town name} has population of {population} and area {area} square km".

            string townName = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {townName} has population of {population} and area {area} square km.");
        }
    }
}
