using System;

class Program
{
    static int Add(int a, int b) => a + b;

    static void Main()
    {
        if (Add(2, 3) != 5)
        {
            throw new Exception("Test fehlgeschlagen: Add(2, 3) sollte 5 ergeben.");
        }

        Console.WriteLine("Test bestanden. Ergebnis: " + Add(2, 3));
    }
}

