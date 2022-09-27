using System;

namespace P23_RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            //            Every second lost game, Petar trashes his headset.
            //Every third lost game, Petar trashes his mouse.
            //When Petar trashes both his mouse and headset in the same lost game, he also trashes his keyboard.
            //Every second time, when he trashes his keyboard, he also trashes his display.

            int trashedHeadset = lostGames / 2;
            int trashedMouse = lostGames / 3;
            int trashedKeyboard = lostGames / 6;
            int trashedDisplay = lostGames / 12;

            double totalPrice = trashedHeadset * headsetPrice + trashedMouse * mousePrice +
                trashedKeyboard * keyboardPrice + trashedDisplay * displayPrice;
            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
        }
    }
}
