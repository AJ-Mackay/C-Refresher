using System;

class EntryPoint
{
    static void Main()
    {
        string firstString = "C# Course";
        string secondString = "for beginners";
        string freeSpace = " ";

        Console.WriteLine(firstString);
        Console.WriteLine(secondString);

        Console.WriteLine("I am taking my first " + firstString + freeSpace + secondString + " and I am really happy with what I am learning."); // concatenation
        Console.WriteLine("I am taking my first {0}{1}{2} and I am really happy with what I am learning.", firstString, freeSpace, secondString);
    }
}
