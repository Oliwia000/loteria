using System;
using System.Collections.Generic;

namespace loteria
{
    class Programn
    {
        static void Main()
        {
            Console.WriteLine("Podaj liczbę zestawów do wylosowania ");
            string nazwa = Console.ReadLine();
            int ilezestawow = int.Parse(Console.ReadLine());
            List<int[]> zestaw = new List<int[]>();

            for(int i =0; i<ilezestawow; i++)

            {
                int[] zestaw = losujzestaw();
                zestawy.Add(zestaw);
                Console.WriteLine("Losowanie"+ (i+1) +  ":");
              Console.WriteLine("Losowanie " + (i + 1) + ": ");
               Console.WriteLine(string.Join(" ", zestaw));
        }

        int[] wystapienia = policzwystapienia(zestawy);

        Console.WriteLine("\nWystąpienia liczb:");
        for (int i = 1; i <= 49; i++)
        {
            if (wystapienia[i] > 0)
                Console.WriteLine("Liczba {0}: {1}", i, wystapienia[i]);
        }

        Console.WriteLine("\nKoniec programu. Naciśnij Enter...");
        Console.ReadLine();
    }       
        static int[] losujzestaw()
        {
            Random rnd = new Random ();
            HashSet<int> liczby = new HashSet<int>();
            while (liczby.Count < 6)
            {
                 
            }

        }

        static int[] policzwystapienia()
        {

        }

     }
 }
