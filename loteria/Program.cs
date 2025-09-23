using System;
using System.Collections.Generic;

namespace loteria
{
    class Program
    {
        /// <summary>
        /// Program do losowania losowych zestawów w przedziale od 1 do 49 i liczy ich wyswietlen.
        /// </summary>
        static void Main()
        {
            Console.Write("Podaj liczbę zestawów do wygenerowania losowań: ");
            int ileZestawow = int.Parse(Console.ReadLine());
            List<int[]> zestawy = new List<int[]>();
            for (int i = 0; i < ileZestawow; i++)
            {
                int[] zestaw = LosujZestaw();
                zestawy.Add(zestaw);

                Console.Write("Losowanie " + (i + 1) + ": ");
                Console.WriteLine(string.Join(" ", zestaw));
            }
            int[] wystapienia = PoliczWystapienia(zestawy);

            Console.WriteLine("\nWystąpienia liczb:");
            for (int i = 1; i <= 49; i++)
            {
                if (wystapienia[i] > 0)
                    Console.WriteLine("Liczba {0}: {1}", i, wystapienia[i]);
            }
            Console.WriteLine("\nKoniec programu. Naciśnij Enter...");
            Console.ReadLine();
        }
        /// <summary>
        /// funkcja losuje jeden zestaw 6 losowych liczb w przedziale 1-49.
        /// </summary>
        /// <returns>tablica 6 licz całkowitych posortowanych. </returns>
        static int[] LosujZestaw()
        {
            Random rnd = new Random();
            HashSet<int> liczby = new HashSet<int>();

            while (liczby.Count < 6)
            {
                int liczba = rnd.Next(1, 49);
                liczby.Add(liczba);
            }

            int[] wynik = new int[6];
            liczby.CopyTo(wynik);
            Array.Sort(wynik);
            return wynik;
        }
        /// <summary>
        /// fukcja liczy ile razy wyświetla się dana  liczba w zestawie.
        /// </summary>
        /// <param name="zestawy">lista zestawów liczb. </param>
        /// <returns> tablica zlicza wystąpienia liczb w przedziale 1-49.</returns>
        static int[] PoliczWystapienia(List<int[]> zestawy)
        {
            int[] wystapienia = new int[49]; 
            foreach (var zestaw in zestawy)
            {
                foreach (var liczba in zestaw)
                {
                    wystapienia[liczba]++;
                }
            }
            return wystapienia;
        }
    }
}