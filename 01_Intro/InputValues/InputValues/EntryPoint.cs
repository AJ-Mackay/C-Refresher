using System;
using System.Threading;

class EntryPoint
{
    static void Main()
    {
        // Console.WriteLine("What is your name?");
        // string firstName = Console.ReadLine();
        //
        // Console.WriteLine(firstName);

        // Console.WriteLine("How old are you?");
        // int age = int.Parse(Console.ReadLine());
        //
        // Console.WriteLine(age);

        int age = 0;

        while (true)
        {
            Console.WriteLine("How old are you?");
            age = int.Parse(Console.ReadLine());

            if (age <= 10 && age >= 1)
            {
                break;
            }

            Console.WriteLine("Please input an age between 1 and 10");
            Thread.Sleep(2000);
        }

        Console.WriteLine(age);
    }
}
