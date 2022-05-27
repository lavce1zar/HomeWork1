using System;

namespace HomeWork1.Task1.DaysOfWeek.Var1
{
    internal class Program
    {
        //with switch and custom enum

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

        static void PrintDay (int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                    Console.WriteLine((WeekDays) dayNumber);
                    break;
                default:
                    Console.WriteLine($"There is no day #{dayNumber} in the week");
                    break;
            }
        }
    }
}