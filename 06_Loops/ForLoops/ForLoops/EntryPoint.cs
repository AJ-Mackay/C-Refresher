using System;

class EntryPoint
{
    static void Main()
    {
        for (int i = 10; i >= 1; i--)
        {
            if (i == 1)
            {
                Console.WriteLine("The for loop was executed {0} time!", i);
            }
            else
            {
                Console.WriteLine("The for loop was executed {0} times!", i);
            }
        }
    }
}
