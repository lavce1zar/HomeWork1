using System;

namespace HomeWork1.Task2.MultiplicationTable.Var2
{
    internal class Program
    {
        // with a given from user number of iterations
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a number:");

            var userInput = Console.ReadLine();

            var isNumber = int.TryParse(userInput, out int number);

            Console.WriteLine("Please, enter a number of iterations:");

            var userInput2 = Console.ReadLine();

            var isNumber2 = int.TryParse(userInput2, out int numberOfIterations);

            if (isNumber && isNumber2)
            {
                PrintTable(number, numberOfIterations);
            }
            else
            {
                Console.WriteLine("Not a number, or number is greater (lower) than int.Max(Min)Value");
            }
        }

        static void PrintTable(int number, int numberOfIterations)
        {
            // using long because there may be cases, when number is around int.MaxValue
            for (int i = 1; i <= numberOfIterations; i++)
            {
                Console.WriteLine($"{number} * {i} = {(long)number * i}");
            }
        }
    }
}