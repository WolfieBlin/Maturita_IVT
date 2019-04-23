using System;

namespace KraceniZlomku_mat
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var kraceniZlomku = new KraceniZlomku();
            
            Console.WriteLine("Zadejte čitatele zlomku.");
            var a1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Zadejte jmenovatele zlomku.");
            var a2 = Convert.ToInt32(Console.ReadLine());
            
            kraceniZlomku.Vysledek(a1, a2);
        }
        
    }

    public class KraceniZlomku
    {
        public void Vysledek(int a1, int a2)
        {
            var vysledek = ZkracenyZlomek(a1, a2);

            if (vysledek.Item2 == 1)
            {
                Console.WriteLine("Zkrácený zlomek:");
                Console.WriteLine(vysledek.Item1);
            }else if (vysledek.Item2 == -1)
            {
                Console.WriteLine("Zkrácený zlomek:");
                Console.WriteLine(vysledek.Item1 * -1);
            }else if (vysledek.Item1 < 0 && vysledek.Item2 < 0)
            {
                Console.WriteLine("Zkrácený zlomek:");
                Console.WriteLine(vysledek.Item1 * -1);
                Console.WriteLine("---");
                Console.WriteLine(vysledek.Item2 * -1);
            }
            else
            {
                Console.WriteLine("Zkrácený zlomek:");
                Console.WriteLine(vysledek.Item1);
                Console.WriteLine("---");
                Console.WriteLine(vysledek.Item2);
            }
            

        }
        
        (int, int) ZkracenyZlomek(int a1, int a2)
        {
            var delitel = SpolDelitel(a1, a2);
            
            return (a1 / delitel, a2 / delitel);
        }
        
        private static int SpolDelitel(int a1, int a2)
        {
            if (a1 < 0 && a2 < 0)
            {
                a1 = a1 * -1;
                a2 = a2 * -1;
            }
            
            if (a1 < 0 || a2 < 0)
            {
                if (a1<0)
                {
                    a1 = a1 * -1;
                }
                else
                {
                    a2 = a2 * -1;
                }
            }
            
            while (a1 != 0 && a2 != 0)
            {
                if (a1 > a2)
                    a1 %= a2;
                else
                    a2 %= a1;
            }

            return a1 == 0 ? a2 : a1;
        }
    }
}