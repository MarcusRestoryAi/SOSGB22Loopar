using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello, World!");
                Console.WriteLine("Person 2 is better than 1");
            }

            Console.WriteLine("Mitten av programmet!");

            int x = 5;
            if (x==5)
                Console.WriteLine("Hej");
            else
                Console.WriteLine("Hej då");

            

            Console.WriteLine("Slutet av programmet!");

            Console.ReadKey();
        }
    }
}