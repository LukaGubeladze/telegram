using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Task 1: Number greater than 7
        Console.Write("Enter a number: ");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int number) && number > 7)
        {
            Console.WriteLine("Hello");
        }
        else
        {
            Console.WriteLine("Invalid number or not greater than 7.");
        }

        // Task 2: Name check
        Console.Write("Enter a name: ");
        string? name = Console.ReadLine();
        if (!string.IsNullOrEmpty(name) && name == "John")
        {
            Console.WriteLine("Hello, John");
        }
        else
        {
            Console.WriteLine("There is no such name");
        }

        // Task 3: Numeric array
        Console.Write("Enter numbers separated by spaces: ");
        string? numbersInput = Console.ReadLine();
        if (!string.IsNullOrEmpty(numbersInput))
        {
            int[] numbers = numbersInput
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(n => int.TryParse(n, out _)) // Filter only valid integers
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine("Multiples of 3:");
            foreach (int n in numbers.Where(n => n % 3 == 0&& n!=0))
            {
                Console.WriteLine(n);
            }
        }
        else
        {
            Console.WriteLine("No numbers provided.");
        }

        // Bonus: Bracket sequence question
        Console.WriteLine("\nBracket sequence analysis:");
        string sequence = "[((())()(())]]";
        Console.WriteLine($"Original sequence: {sequence}");
        Console.WriteLine("Correct sequence: [((())()(())])");
    }
}
