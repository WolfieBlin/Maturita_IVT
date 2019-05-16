using System;

namespace MinMaxCisla_mat2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Zadejte počet zadávaných čísel.");
            
            var pocet = Convert.ToInt32(Console.ReadLine());
            var cisla = new int[pocet];
            

            Console.WriteLine("Postupně zadejte {0} čísel", pocet);
            
            for (int i = 0; i < pocet; i++)
            {
                cisla[i] = Convert.ToInt32(Console.ReadLine());
            }

            var min = cisla[0];
            var max = cisla[0];

            foreach (var cislo in cisla)
            {
                if (cislo > max)
                {
                    max = cislo;
                }

                if (cislo < min)
                {
                    min = cislo;
                }
            }

            Console.WriteLine("Nejmenší číslo je " + min);
            Console.WriteLine("Největší číslo je " + max);
        }
    }
}