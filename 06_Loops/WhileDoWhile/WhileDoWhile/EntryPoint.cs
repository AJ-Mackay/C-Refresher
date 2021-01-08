using System;

class EntryPoint
{
    static void Main()
    {
        Console.WriteLine("0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15...");
        Console.WriteLine();

        Console.WriteLine("Please enter your first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter your second number:");
        int endNumber = int.Parse(Console.ReadLine());
        Console.WriteLine();

        while (firstNumber <= endNumber)
        {
            Console.WriteLine(firstNumber);
            firstNumber++;
        }
    }
}
