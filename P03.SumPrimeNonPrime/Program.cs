using System;

namespace P03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = string.Empty;
            int num = 0;
            int primeNumber = 0;
            int nonPrimeNumbers = 0;
            bool stop = false;

            while ((numbers = Console.ReadLine()) != "stop")
            {
                num = int.Parse(numbers);
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                }

                for (int i = 0; i < num; i++)
                {
                    if (num<0)
                    {
                        break;
                    }

                    for (int j = 0; j < num; j++)
                    {
                        if (i * j == num)
                        {
                            nonPrimeNumbers += num;
                            stop= true;
                            break;
                        }
                        else if (i == num - 1)
                        {
                            primeNumber += num;
                            stop = true;
                            break;
                        }
                    }
                    if (stop)
                    {
                        stop = false;
                        break;
                    }
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeNumber}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNumbers}");

        }
    }
}
