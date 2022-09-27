namespace P20_VendingMachine
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string product = string.Empty;
            double totalCoins = 0;
            double nuts = 2;
            double water = 0.7;
            double crisps = 1.5;
            double soda = 0.8;
            double coke = 1;
            double price = 0;

            while (command != "Start")
            {
                double coins = Convert.ToDouble(command);

                if (coins != 0.1 && coins != 0.2 && coins != 0.5 && coins != 1 && coins != 2)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                    command = Console.ReadLine();
                    continue;
                }
                totalCoins += coins;
                command = Console.ReadLine();
            }
            if (command == "Start")
            {
                product = Console.ReadLine();

                while (product != "End")
                {
                    if (product != "Nuts" && product != "Water" && product != "Crisps" && product != "Soda" &&
                            product != "Coke")
                    {
                        Console.WriteLine("Invalid product");
                        product = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        switch (product)
                        {
                            case "Nuts":
                                price = nuts;
                                break;
                            case "Water":
                                price = water;
                                break;
                            case "Crisps":
                                price = crisps;
                                break;
                            case "Soda":
                                price = soda;
                                break;
                            case "Coke":
                                price = coke;
                                break;
                        }
                        if (price <= totalCoins)
                        {
                            Console.WriteLine($"Purchased {product.ToLower()}");
                            totalCoins -= price;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }
                    product = Console.ReadLine();
                }
                Console.WriteLine($"Change: {totalCoins:f2}");
            }
        }
    }
}
