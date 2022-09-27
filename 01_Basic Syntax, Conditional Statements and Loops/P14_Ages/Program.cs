using System;

namespace P14_Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	0 - 2 – baby
            //•	3 - 13 – child
            //•	14 - 19 – teenager
            //•	20 - 65 – adult
            //•	>= 66 – elder
            int age = int.Parse(Console.ReadLine());
            string typePerson = string.Empty;

            if (age >= 0 && age <= 2)
            {
                typePerson = "baby";
            }
            else if (age >= 3 && age <= 13)
            {
                typePerson = "child";
            }
            else if (age >= 14 && age <= 19)
            {
                typePerson = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                typePerson = "adult";
            }
            else if (age >= 66)
            {
                typePerson = "elder";
            }

            Console.WriteLine(typePerson);
        }
    }
}
