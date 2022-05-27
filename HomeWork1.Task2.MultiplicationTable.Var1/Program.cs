using System;

namespace HomeWork1.Task2.MultiplicationTable.Var1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a number:");

            var userInput = Console.ReadLine();

            var isNumber = int.TryParse(userInput, out int number);

            if (isNumber)
            {
                PrintTable(number);
            }
            else
            {
                Console.WriteLine("Not a number, or number is greater (lower) than int.Max(Min)Value");
            }
        }

        static void PrintTable(int number)
        {
            // using long because there may be cases, when number is around int.MaxValue
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{number} * {i} = {(long)number * i}");
            }
        }
    }
}