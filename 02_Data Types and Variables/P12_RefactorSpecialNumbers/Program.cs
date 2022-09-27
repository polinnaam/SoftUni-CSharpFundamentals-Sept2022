using System;

namespace P12_RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            { 
                int totalSum = 0;
                int copyNum = i;
                while (copyNum > 0)
                {
                    totalSum += copyNum % 10;
                    copyNum = copyNum / 10;
                }
                if (totalSum == 5 || totalSum == 7 || totalSum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
