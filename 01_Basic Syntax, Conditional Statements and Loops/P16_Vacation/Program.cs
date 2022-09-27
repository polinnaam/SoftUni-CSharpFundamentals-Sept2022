namespace P16_Vacation
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int totalPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;
            int students = 0;
            int business = 0;
            int regular = 0;

            if (dayOfWeek == "Friday")
            {
                if (typeOfGroup == "Students")
                {
                    price = 8.45;
                    students += totalPeople;
                }
                else if (typeOfGroup == "Business")
                {
                    price = 10.90;
                    business += totalPeople;
                }
                else if (typeOfGroup == "Regular")
                {
                    price = 15;
                    regular += totalPeople;
                }
            }
            else if (dayOfWeek == "Saturday")
            {
                switch (typeOfGroup)
                {
                    case "Students":
                        price = 9.8;
                        students += totalPeople;
                        break;
                    case "Business":
                        price = 15.6;
                        business += totalPeople;
                        break;
                    case "Regular":
                        price = 20;
                        regular += totalPeople;
                        break;
                }
            }
            else if (dayOfWeek == "Sunday")
            {
                switch (typeOfGroup)
                {
                    case "Students":
                        price = 10.46;
                        students += totalPeople;
                        break;
                    case "Business":
                        price = 16;
                        business += totalPeople;
                        break;
                    case "Regular":
                        price = 22.5;
                        regular += totalPeople;
                        break;
                }
            }
            double totalPrice = price * students + price * business + price * regular;
            if (students >= 30)
            {
                totalPrice -= (0.15 * totalPrice);
            }
            else if (business >= 100)
            {
                totalPrice -= (price * 10);
            }
            else if (regular >= 10 && regular <= 20)
            {
                totalPrice -= (0.05 * totalPrice);
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
