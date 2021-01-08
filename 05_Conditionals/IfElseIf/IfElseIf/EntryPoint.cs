using System;

class EntryPoint
{
    static void Main()
    {
        //   Console.WriteLine("Please input your first number");
        //   int firstNumber = int.Parse(Console.ReadLine());
        //   Console.WriteLine("Please input your second number");
        //   int secondNumber = int.Parse(Console.ReadLine());
        //
        //   if (firstNumber < secondNumber)
        //   {
        //       Console.WriteLine("The number {0} is smaller than the number {1}", firstNumber, secondNumber);
        //   }
        //   else if (firstNumber == secondNumber)
        //   {
        //       Console.WriteLine("The numbers provided ({0}) are equal!", firstNumber);
        //   }
        //   else
        //   {
        //       Console.WriteLine("The number {1} is smaller than the number {0}", firstNumber, secondNumber);
        //   }

        Console.WriteLine("Please input a number between 0 and 9");
        int number = int.Parse(Console.ReadLine());

        if (number == 1)
        {
            Console.WriteLine("one");
        }
        else if (number == 2)
        {
            Console.WriteLine("two");
        }
        else if (number == 3)
        {
            Console.WriteLine("three");
        }
        else if (number == 4)
        {
            Console.WriteLine("four");
        }
        else if (number == 5)
        {
            Console.WriteLine("five");
        }
        else if (number == 6)
        {
            Console.WriteLine("six");
        }
        else if (number == 7)
        {
            Console.WriteLine("seven");
        }
        else if (number == 8)
        {
            Console.WriteLine("eight");
        }
        else if (number == 9)
        {
            Console.WriteLine("nine");
        }
        else if (number == 0)
        {
            Console.WriteLine("zero");
        }
        else
        {
            Console.WriteLine("Your number ({0}) was not between 0 and 9.", number);
        }
    }
}
