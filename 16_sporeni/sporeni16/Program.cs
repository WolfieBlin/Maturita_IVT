using System;

namespace sporeni16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte počáteční kapitál");
            var pocKapital = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Zadejte zdaňovací koeficient");
            var dan = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Zadejte úrokovou míru");
            var urok = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Zadejte počet let");
            var pocetLet = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Po {pocetLet} letech budete mít {Uroceni(pocKapital, dan, urok, pocetLet)} korun");
        }

        public static double Uroceni(double pocKapital, double dan, double urok, double pocetLet)
        {
            double konecnaCastka = 0;
            
            if (dan != 0)
            {
                var zdanovaciKoeficient = 1 - dan;
                konecnaCastka = pocKapital * Math.Pow((1 + zdanovaciKoeficient * urok), pocetLet);
            }
            else
            {
                konecnaCastka = pocKapital * Math.Pow((1 + urok), pocetLet);
            }
            

            return Math.Round(konecnaCastka, 2);
        }
    }
}