using System;

namespace Narozeniny_mat6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var dnesniDen = DateTime.Now;
            var datumNarozenin = new DateTime();
            double pocetDnu = 0;

            Console.WriteLine("Zadejte den vašeho narození.");
            var den = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Zadejte číslicí měsíc vašeho narození.");
            var mesic = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Zadejte rok vašeho narození.");
            var rok = Convert.ToInt32(Console.ReadLine());
            
            
            var datumNarozeniDateTime = new DateTime(rok, mesic, den);

            if (datumNarozeniDateTime.AddYears(dnesniDen.Year) < dnesniDen)
            {
                datumNarozenin = new DateTime(DateTime.Now.Year + 1, mesic, den);
            }
            else
            {
                datumNarozenin = new DateTime(DateTime.Now.Year, mesic, den);
            }

            pocetDnu = (datumNarozenin - dnesniDen).TotalDays;
            
            if (rok > dnesniDen.Year)
            {
                Console.WriteLine("Zada jste špatně");
            }else if (dnesniDen.Day == datumNarozenin.Day && dnesniDen.Month == datumNarozenin.Month)
            {
                Console.WriteLine("Dnes máte narozeniny");
            }
            else
            {
                Console.WriteLine(Math.Floor(pocetDnu));
            }
        }
    }
}