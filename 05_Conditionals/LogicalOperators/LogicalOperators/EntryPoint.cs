using System;

class EntryPoint
{
    static void Main()
    {
        // Logical Operators:
        // AND - &&
        // OR - ||
        // XOR - ^
        // NOT - !

        bool theTrue = true;
        bool theFalse = false;

        Console.WriteLine(theTrue && theFalse);
        Console.WriteLine(theTrue || theFalse);
        Console.WriteLine(theTrue ^ theFalse);
        Console.WriteLine(!theTrue);
        Console.WriteLine();
        Console.WriteLine((theTrue || theFalse) && theFalse);
        Console.WriteLine((theTrue || theFalse) && (theFalse ^ theTrue));
    }
}
