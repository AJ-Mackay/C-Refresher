using System;

class EntryPoint
{
    static void Main()
    {
        string iAmAnArray = "array";

        Console.WriteLine(iAmAnArray);
        Console.WriteLine(iAmAnArray[2]); // Arrays start at 0, this will print the 3rd character

        // iAmAnArray[3] = "f"; - Won't work. String are immutable

        string[] iAmAStringArray = new string[3];

        iAmAStringArray[0] = "First item";
        iAmAStringArray[2] = "Third item";
        iAmAStringArray[0] = "first"; // overwrites item 0

        string[] newStringArray = { "5", "4", "3", "2", "1", "Boom!" };
        Console.WriteLine(newStringArray[5]);
        Console.WriteLine(newStringArray.Length);

        int[] integerArray = new int[5];

        integerArray[3] = 123;
    }
}
