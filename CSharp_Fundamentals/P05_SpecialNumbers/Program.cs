using System;

namespace P05_SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= num; i++)
            {
                int sum = 0;
                if (i >= 10)
                {
                    int copyNum = i;
                    while (copyNum % 10 > 0 || copyNum / 10 > 0)
                    {
                        int a = copyNum % 10;
                        copyNum /= 10;
                        sum += a;
                    }
                }
                if (sum == 5 || sum == 7 || sum == 11 || i == 5 || i == 7)
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
