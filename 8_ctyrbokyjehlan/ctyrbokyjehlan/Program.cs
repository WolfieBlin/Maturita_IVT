using System;

namespace ctyrbokyjehlan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte stranu podstavy");
            var strana = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Zadejte výšku jehlanu");
            var vyska = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Vyberte si operaci:\n1 -- výpočet objemu\n2 -- výpočet povrchu");
            
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Objem pravidelného čtyřbokého jehlanu je: " + Objem(strana, vyska));
                    break;
                case "2":
                    Console.WriteLine("Povrch pravidelného čtyřbokého jehlanu je: " + Povrch(strana, vyska));
                    break;
                default:
                    Console.WriteLine("zadal jste špatně");
                    break;
            }
        }

        public static double Objem(double strana, double vyska)
        {
            var objem = strana * strana * vyska / 3;
            return objem;
        }

        public static double Povrch(double strana, double vyska)
        {
            var bocniStranaVyska = Math.Sqrt((strana / 2 ) * (strana / 2 ) + (vyska * vyska));
            var povrch = strana * strana + 4 * (bocniStranaVyska * strana / 2);

            return povrch;
        }
    }
}