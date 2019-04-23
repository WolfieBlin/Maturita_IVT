using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;

namespace MinMaxposloupnost_mat
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Zadejte počet řetězců.");
            
            var pocet = Convert.ToInt32(Console.ReadLine());
            var slova = new string[pocet];
            
            Console.WriteLine("Zadejte postupně řetězce.");
            for (int i = 0; i < pocet; i++)
            {
                slova[i] = Console.ReadLine();
            }

            var nejmensi = slova[0];
            var nejvetsi = slova[0];
            
            foreach (var slovo in slova)
            {
                if (slovo.Length < nejmensi.Length)
                {
                    nejmensi = slovo;
                }

                if (slovo.Length > nejvetsi.Length)
                {
                    nejvetsi = slovo;
                }
            }

            Console.WriteLine("Nejdejš řetězec: " + nejvetsi);
            Console.WriteLine("Nejkratší řetězec: " + nejmensi);
        }
    }
}