using System;

namespace CifernySoucetCisla_mat12
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Zadejte čislo k cifernému součtu.");
            var cislo = Console.ReadLine();
            var soucet = 0;

            foreach (var znak in cislo)
            {
                soucet = soucet + Convert.ToInt32(znak.ToString());
            }

            Console.WriteLine("Ciferný součet je: " + soucet);
        }
    }
}