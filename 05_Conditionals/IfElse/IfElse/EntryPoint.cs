using System;

class EntryPoint
{
    static void Main()
    {
        // if (4 < 5)
        // {
        //     Console.WriteLine("4 is smaller than 5");
        // }

        // Console.WriteLine("Please input your first number:");
        // int firstNumber = int.Parse(Console.ReadLine());
        // Console.WriteLine("Please input your second number:");
        // int secondNumber = int.Parse(Console.ReadLine());

        // if (firstNumber < secondNumber)
        // {
        //     Console.WriteLine("The number {0} is smaller than the number {1}", firstNumber, secondNumber);
        // }
        // else
        // {
        //     Console.WriteLine("The number {1} is smaller than the number {0}", firstNumber, secondNumber);
        // }

        Console.WriteLine("Please input a number:");
        int firstNumber = int.Parse(Console.ReadLine());

        if (firstNumber % 2 == 0 && firstNumber % 3 == 0 && firstNumber % 5 == 0)
        {
            Console.WriteLine("The number {0} is divisible by 2, 3 and 5 without a remainder.", firstNumber);
        }
        else
        {
            Console.WriteLine("The number {0} is NOT divisible by 2, 3 and 5 without a remainder.", firstNumber);
        }
    }
}