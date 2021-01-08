using System;

class EntryPoint
{
    static void Main()
    {
        // Arithmetic Operators: + - * / % ++ --
        int firstNumber = 20;
        int secondNumber = 7;

        int addition = firstNumber + secondNumber;
        int subtraction = firstNumber - secondNumber;
        int multiplication = firstNumber * secondNumber;
        double division = (double)firstNumber / (double)secondNumber; // type casting

        Console.WriteLine("The first number is: {0}", firstNumber);
        Console.WriteLine("The second number is: {0}", secondNumber);
        Console.WriteLine();
        Console.WriteLine("The result of the addition is: {0}", addition);
        Console.WriteLine("The result of the subtraction is: {0}", subtraction);
        Console.WriteLine("The result of the multiplication is: {0}", multiplication);
        Console.WriteLine("The result of the division is: {0}", division);
        Console.WriteLine();

        firstNumber++;
        Console.WriteLine("The first number is being plus-plus-ed: {0}", firstNumber); // incrementation

        firstNumber--;
        firstNumber--;
        firstNumber--;
        firstNumber--;
        Console.WriteLine("The first number is now being minus-minus-ed four times: {0}", firstNumber);

        int divisionWithRemainder = firstNumber % secondNumber; // modulus
        Console.WriteLine(divisionWithRemainder);
    }
}
