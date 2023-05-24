using System;

namespace P04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input;
            string name;
            double sumGrades = 0;
            double sumGrades2 = 0;
            int n2 = 0;

            while ((input = Console.ReadLine()) != "Finish")
            {
                name = input;
                for (int i = 1; i <= n; i++)
                {
                    double grades = double.Parse(Console.ReadLine());
                    sumGrades += grades;
                    sumGrades2 += grades;
                    n2++;
                    
                }
                Console.WriteLine($"{name} - {sumGrades / n:f2}.");
                sumGrades = 0;
            }
            Console.WriteLine($"Student's final assessment is {sumGrades2/n2:f2}.");
        }
    }
}
