using System;

namespace P02.EqualSumsEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());

            for (int i = start; i <= stop; i++)
            {
                string currentNum = i.ToString();
                int oddSum = 0;
                int evenSum = 0;

                for (int j = 0; j < currentNum.Length; j++)
                {   
                    int currentDigit = currentNum[j];

                    if (j % 2 == 0)
                    {
                        evenSum += currentDigit;
                    }
                    else 
                    {
                        oddSum += currentDigit;
                    }    

                }
                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }     
            }
        }
    }
}
