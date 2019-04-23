using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Prvocisla_mat
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Zadejte do kterého čísla mám vypočítat prvočísla");
            var pocetCisel = Convert.ToInt32(Console.ReadLine());
            var pole = new bool[pocetCisel];
            
            for (int i = 2; i < pole.Length; i++)
            {
                    for (int j = i + 1; j < pole.Length; j++)
                    {
                        if (j % i == 0)
                        {
                            pole[j] = true;
                        }
                    }
                    if (!pole[i])
                    {
                        Console.WriteLine(i);
                    }
            }
        }
    }
}