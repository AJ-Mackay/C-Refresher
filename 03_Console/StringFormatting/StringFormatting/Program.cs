using System;

class Program
{
    static void Main()
    {
        string freshJuice = "Lets make fresh juice from bananas";
        string strawberry = "Strawberries";
        int five = 500;
        float number = 500.54734523423F; // adding the "F" allows larger numbers to be used as a float

        Console.WriteLine("{0} and {1}.", freshJuice, strawberry);
        Console.WriteLine();
        Console.WriteLine("{0, 15}", strawberry);
        Console.WriteLine("{0, 10:C}", five); // ":C" displays the number as a currency
        Console.WriteLine("{0, 10:C0}", five); // adding "0" displays the number without pence
        Console.WriteLine("{0, 10:C0}", five); // different numbers show how many digits should be displayed after the decimal point
        Console.WriteLine("{0, 10:C5}", number); // the last digit is rounded
    }
}
