using System;
class demo_while1
{
    static void Main()
    {
        Console.Clear();
        int i;
        i = 1; //nilai awal, preparation
        while (i <= 5) // nilai akhir, decision
        {
            Console.WriteLine(i + " ");
            i = i + 1;//counter, proses
        }
    }
}