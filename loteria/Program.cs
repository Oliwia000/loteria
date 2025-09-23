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
                Console.WriteLine();
            }


                
        }


    }
}