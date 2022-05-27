using System;

namespace HomeWork1.Task1.DaysOfWeek.Var2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter day number:");

            var userInput = Console.ReadLine();

            var isNumber = int.TryParse(userInput, out int numberOfDay);

            if (isNumber)
            {
                PrintDay(numberOfDay);
            }
            else
            {
                Console.WriteLine("Not a number");
            }
        }

        static void PrintDay(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine($"There is no day #{dayNumber} in the week");
                    break;
            }
        }
    }
}
