using System;

namespace P17_PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int sumOfNum = 0;

            for (int i = startNum; i <= endNum; i++)
            {
                Console.Write($"{i} ");
                sumOfNum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sumOfNum}");
        }
    }
}
