using System;

namespace Tre_i_Rad
{
    class Program
    {
        static void Main(string[] args)
        {
            int treigaTal = 0;
            Console.WriteLine("N?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                if (i * (i + 1) * (i + 2) < n) 
                {
                    treigaTal++;
                }
            }
            Console.WriteLine(treigaTal);
        }
    }
}