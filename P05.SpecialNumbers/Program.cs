using System;

namespace P05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string specialnumber = string.Empty;

            for (int f = 1; f <= 9; f++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int i = 1; i <= 9; i++)
                    {
                        for (int k = 1; k <= 9; k++)
                        {
                            if (n % f == 0 && n % j == 0 && n % i == 0 && n % k == 0)
                            {
                                Console.Write($"{f}{j}{i}{k} ");
                            }
                        }
                    }
                }
            }


        }
    }
}
