using System;

namespace P02_PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());

            decimal dollars = Convert.ToDecimal(pounds) * 1.31m;

            Console.WriteLine($"{dollars:f3}");
        }
    }
}
