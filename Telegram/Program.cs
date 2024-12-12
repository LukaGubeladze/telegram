using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Task 1: Number greater than 7
        Console.Write("Enter a number: ");
        if (int.TryParse(Console.ReadLine(), out int number) && number > 7)
        {
            Console.WriteLine("Hello");
        }

        // Task 2: Name check
        Console.Write("Enter a name: ");
        string name = Console.ReadLine();
        if (name == "John")
        {
            Console.WriteLine("Hello, John");
        }
        else
        {
            Console.WriteLine("There is no such name");
        }

        // Task 3: Numeric array
        Console.Write("Enter numbers separated by spaces: ");
        int[] numbers = Console.ReadLine()?.Split(' ').Select(int.Parse).ToArray() ?? Array.Empty<int>();
        Console.WriteLine("Multiples of 3:");
        foreach (int n in numbers.Where(n => n % 3 == 0))
        {
            Console.WriteLine(n);
        }

        // Bonus: Bracket sequence question
        Console.WriteLine("\nBracket sequence analysis:");
        string sequence = "[((())()(())]]";
        Console.WriteLine($"Original sequence: {sequence}");
        Console.WriteLine("Correct sequence: [((())()(())])");
    }
}
