using System;

namespace HomeWork1.Task1.DaysOfWeek.Var3
{
    internal class Program
    {
        //shortest one, with system.DayOfWeek enum and without switch and method
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter day number:");

            var userInput = Console.ReadLine();

            var isNumber = int.TryParse(userInput, out int numberOfDay);

            if (isNumber && (numberOfDay >= 1) && (numberOfDay <= 7))
            {
                Console.WriteLine((DayOfWeek) (--numberOfDay));
            }
            else if (isNumber)
            {
                Console.WriteLine($"There is no day #{numberOfDay} in the week");
            }
            else
            {
                Console.WriteLine("Not a number");
            }
        }
    }
}