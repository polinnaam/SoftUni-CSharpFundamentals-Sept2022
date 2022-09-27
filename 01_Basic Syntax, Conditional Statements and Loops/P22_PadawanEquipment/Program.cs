using System;

namespace P22_PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {

            double amountOfMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());
            int freeBelts = 0;
            double moreLightsabers = Math.Ceiling(0.1 * students);

            if (students >= 6)
            {
                    freeBelts = students / 6;
            }
            double totalPrice = (students + moreLightsabers) * lightsabersPrice  + students * robesPrice +
                (students - freeBelts) * beltsPrice;

            if (totalPrice <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else 
            {
                double neededMoney = totalPrice - amountOfMoney;
                Console.WriteLine($"John will need {neededMoney:f2}lv more.");
            }
        }
    }
}
