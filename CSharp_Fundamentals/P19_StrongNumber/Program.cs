using System;

namespace P19_StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumOfFactoriels = 0;
            int numCopy = number;

            for (int i = 1; i <= number.ToString().Length ; i++)
            {
                int factoriel = 1;

                for (int j = numCopy % 10; j >= 1; j --)
                {
                    factoriel *= j;
                }
                sumOfFactoriels += factoriel;
                numCopy = numCopy / 10;

                if (numCopy == 0)
                {
                    break;
                }
            }
            if (sumOfFactoriels == number)
            {
                Console.WriteLine("yes");
            }
            else 
            {
                Console.WriteLine("no");
            }
        }
    }
}
