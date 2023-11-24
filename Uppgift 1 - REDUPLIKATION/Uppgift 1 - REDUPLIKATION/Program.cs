using System;

namespace Reduplikation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ordet?");
            string ord = Console.ReadLine();

            Console.WriteLine("Antal upprepningar?");
            int upprepningar = int.Parse(Console.ReadLine());

            for (int i = 0; i < upprepningar; i++)
            {
                Console.Write(ord);
            }
        }
    }
}