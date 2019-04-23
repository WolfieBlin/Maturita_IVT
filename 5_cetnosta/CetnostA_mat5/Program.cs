using System;

namespace CetnostA_mat5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var hledanepismeno = 'A';
            var pocet = 0;
            
            Console.WriteLine("Zadejte řetězec");
            var retezec = Console.ReadLine();

            foreach (var pismeno in retezec)
            {
                if (pismeno == hledanepismeno)
                {
                    pocet++;
                }
            }

            Console.WriteLine("V zadaném řetězci se vyskytuje {0} písmen {1}", pocet, hledanepismeno);
        }
    }
}