using System;

namespace P04_BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	The first number is hours and will be between 0 and 23.
            //•	The second number is minutes and will be between 0 and 59.

            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int after30Min = minutes + 30;

            if (after30Min >= 60)
            {
                hour++;
                after30Min -= 60;
            }

            if (hour >= 24)
            {
                hour = 0;
            }

            Console.WriteLine($"{hour}:{after30Min:d2}");
        }
    }
}
