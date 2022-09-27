using System;

namespace P10_MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //{theInteger} X {times} = {product}
            int integer = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int product = i * integer;
                Console.WriteLine($"{integer} X {i} = {product}");
            }
        }
    }
}
