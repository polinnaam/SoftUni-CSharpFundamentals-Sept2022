using System;

namespace P18_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string enteredPassword = Console.ReadLine();
            string password = string.Empty;
            int totalWrongTries = 0;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                char symbol = username[i];
                password += symbol;
            }
            while (password != enteredPassword)
            { 
                totalWrongTries++;
                if (totalWrongTries >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                enteredPassword = Console.ReadLine();
            }
            Console.WriteLine($"User {username} logged in.");            
        }
    }
}
