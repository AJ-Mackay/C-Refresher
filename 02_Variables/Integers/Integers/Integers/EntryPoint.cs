using System;

class EntryPoint
{
    static void Main()
    {
        int someInteger = 5; // int holds 32bit numbers

        Console.WriteLine(int.MinValue);
        Console.WriteLine(someInteger);
        Console.WriteLine(int.MaxValue);

        uint someUInteger = 1; // unsigned int

        Console.WriteLine(uint.MinValue);
        Console.WriteLine(someUInteger);
        Console.WriteLine(uint.MaxValue);

        // Console.WriteLine(Math.Pow(2, 32));

        byte someByte = 255; // from 0 to 255)

        Console.WriteLine(byte.MinValue);
        Console.WriteLine(someByte);
        Console.WriteLine(byte.MaxValue);

        sbyte negativeByte = -1; // signed byte -128 to 127

        Console.WriteLine(sbyte.MinValue);
        Console.WriteLine(negativeByte);
        Console.WriteLine(sbyte.MaxValue);

        long someVeryLongNumber = 34556758675455;

        Console.WriteLine(long.MinValue);
        Console.WriteLine(someVeryLongNumber);
        Console.WriteLine(long.MaxValue);

        ulong noNegativeLongNumbers = 0;

        Console.WriteLine(ulong.MinValue);
        Console.WriteLine(noNegativeLongNumbers);
        Console.WriteLine(ulong.MaxValue);
    }
}
