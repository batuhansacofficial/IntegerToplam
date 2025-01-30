using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Aralarında bir boşluk olacak şekilde rakamlar giriniz: ");
        int[] rakamlar = Console.ReadLine()
                               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

        if (rakamlar.Length % 2 != 0)
        {
            Array.Resize(ref rakamlar, rakamlar.Length + 1);
        }

        Console.Write("ÇIKTI: ");
        for (int i = 0; i < rakamlar.Length; i += 2)
        {
            int rakam = rakamlar[i];
            int rakam2 = rakamlar[i + 1];

            if (rakam == rakam2)
                Console.Write((rakam + rakam2) * (rakam + rakam2) + " ");
            else
                Console.Write((rakam + rakam2) + " ");
        }

        Console.WriteLine();
    }
}