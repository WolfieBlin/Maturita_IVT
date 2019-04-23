using System;

namespace faktorial_mat10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int faktorial = 1;

            Console.WriteLine("Zadejte číslo na faktoriál.");
            var cislo = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cislo - 1; i++)
            {
                faktorial = faktorial * (cislo - i);
            }

            Console.WriteLine(faktorial);

            faktorial = Faktorial(cislo, cislo);
            Console.WriteLine(faktorial);
        }

        public static int Faktorial(int cislo, int pocet)
        {
            if (pocet > 1)
            {
                cislo = Faktorial(cislo * (pocet - 1), pocet - 1);

            }
            return cislo;

        }
    }
}