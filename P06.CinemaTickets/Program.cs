using System;

namespace P06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string input2;
            int freeSpaces;
            int studentTicket = 0;
            int standartTicket = 0;
            int kidTicket = 0;
            int sumAllTicket = 0;
            int totalTicket = 0;
            bool stop = false;

            while ((input = Console.ReadLine()) != "Finish")
            {
                freeSpaces = int.Parse(Console.ReadLine());

                while ((input2 = Console.ReadLine()) != "End")
                {

                    if (input2 == "Finish")
                    {
                        stop= true;
                        break;
                    }
                    sumAllTicket++;
                    totalTicket++;
                    if (input2 == "student")
                    {
                        studentTicket++;
                    }
                    else if (input2 == "standard")
                    {
                        standartTicket++;
                    }
                    else if (input2 == "kid")
                    {
                        kidTicket++;
                    }

                    if (sumAllTicket >= freeSpaces)
                    {
                        break;
                    }
               
                }
                if (input2 == "End" || sumAllTicket >= freeSpaces)
                {
                    Console.WriteLine($"{input} - {(double)sumAllTicket / freeSpaces * 100:f2}% full.");
                    sumAllTicket = 0;

                }
                if (stop)
                {
                    break;
                }

            }
            Console.WriteLine($"Total tickets: {totalTicket}");
            Console.WriteLine($"{(double)studentTicket / totalTicket * 100:f2}% student tickets.");
            Console.WriteLine($"{(double)standartTicket / totalTicket * 100:f2}% standard tickets.");
            Console.WriteLine($"{(double)kidTicket / totalTicket * 100:f2}% kids tickets.");
        }
    }
}
