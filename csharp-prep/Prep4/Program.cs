using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }

        } while (input != 0);

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers entered.");
            return;
        }

        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();
        int smallestPositive = numbers.Where(n => n > 0).Min();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        Console.WriteLine("The sorted list is:");
        List<int> sortedNumbers = numbers.OrderBy(n => n).ToList();
        foreach (int number in sortedNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
