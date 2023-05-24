using System;

namespace P01._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;

            for (int cols = 1; cols <= n; cols++)
            {
                for (int rows = 1; rows <= cols; rows++)
                {
                    if (current > n)
                    {
                        break;
                    }
                    Console.Write($"{current} ");
                    current++;
                }
                Console.WriteLine();
                if (current > n)
                {
                    break;
                }
            }
        }
    }
}
