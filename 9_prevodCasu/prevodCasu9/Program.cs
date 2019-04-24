using System;
using System.Runtime.InteropServices;

namespace prevodCasu9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadjete časový údaj v sekundách");
            float cas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(PrevodCasu(cas));
        }

        public static string PrevodCasu(float cas)
        {
            var hodiny = Math.Floor(cas / 3600);
            var minuty = Math.Floor((cas - hodiny * 3600) / 60);
            var sekundy = cas - minuty * 60 - hodiny * 3600;
            var prevedenyCas = $"{hodiny} hodin {minuty} minut {sekundy} sekund";

            return prevedenyCas;
        }
    }
}