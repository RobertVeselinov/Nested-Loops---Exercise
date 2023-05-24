using System;

namespace P03._1.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number;
            int primeNumbers = 0;
            int nonPrimeNumbers = 0;


            while (input != "stop")
            {
                number = int.Parse(input);
                bool nonPrime = true;
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    for (int i = 2; i < number; i++)
                    {
                        if (number % i == 0)
                        {
                            nonPrime = false;
                            break;
                        }
                    }
                }

                if (!nonPrime && number > 0)
                {
                    nonPrimeNumbers += number;
                }
                else if (nonPrime && number > 0)
                {
                    primeNumbers += number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeNumbers}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNumbers}");
        }
    }
}
