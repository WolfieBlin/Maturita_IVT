using System;

namespace DvaNejvetsi_mat4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Zadejte kolik čísel budete zadávat");
            
            var pocet = Convert.ToInt32(Console.ReadLine());
            var cisla = new int[pocet];

            Console.WriteLine("Zadejte postupně {0} čísel",pocet);

            for (int i = 0; i < pocet; i++)
            {
                cisla[i] = Convert.ToInt32(Console.ReadLine());
            }

            var nejvetsi1 = cisla[0];
            var nejvetsi2 = cisla[0];

            foreach (var cislo in cisla)
            {
                if (cislo > nejvetsi1)
                {
                    nejvetsi1 = cislo;
                }
            }

            foreach (var cislo in cisla)
            {
                if (cislo > nejvetsi2 && cislo != nejvetsi1)
                {
                    nejvetsi2 = cislo;
                }
   
            }

            Console.WriteLine("Dva největší čísla jsou {0} a {1}", nejvetsi1, nejvetsi2);
        }
    }
}