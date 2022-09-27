using System;

namespace P04_CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Assume that a year has 365.2422 days on average

            //of centuries and convert it to years, days, hours and minutes.

            byte centuries = byte.Parse(Console.ReadLine());
            ushort years = (ushort)(centuries * 100);
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
