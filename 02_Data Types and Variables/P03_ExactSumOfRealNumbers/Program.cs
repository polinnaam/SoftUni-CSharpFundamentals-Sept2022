using System;

namespace P03_ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 1; i <= number; i++)
            {
                decimal newNumber = decimal.Parse(Console.ReadLine());
                sum += newNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
