using System;

namespace n_taMocnina_mat11
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Zadejte číslo k umocnění.");
            var umocCislo = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Zadejte mocninu.");
            var mocnina = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Mocnina(umocCislo,mocnina));
        }

        public static int Mocnina(int umocCislo, int mocnina)
        {
            var vysledek = 1;
            for (int i = 0; i < mocnina; i++)
            {
                vysledek = vysledek * umocCislo;
            }

            return vysledek;
        }
    }
}