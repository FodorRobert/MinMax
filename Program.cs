using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int szam = 10;
        int[] szamok = new int[szam];
        for (int i = 0; i < szam; i++)
        {
            szamok[i] = rand.Next(1, 101);
        }
        Console.WriteLine("A generált számok: ");
        foreach (int number in szamok)
        {
            Console.Write(number + ", ");
        }
        Console.WriteLine();
        int minimum = szamok[0];
        int maximum = szamok[0];
        for (int i = 1; i < szam; i++)
        {
            if (szamok[i] < minimum)
            {
                minimum = szamok[i];
            }
            if (szamok[i] > maximum)
            {
                maximum = szamok[i];
            }
        }
        Console.WriteLine("A legkisebb szám: " + minimum);
        Console.WriteLine("A legnagyobb szám: " + maximum);
    }
}
