using System;

namespace CisloPozpatku_mat13
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Zadejte číslo");
            var cislo = Console.ReadLine();

            for (int i = cislo.Length - 1; i >= 0; i--)
            {
                Console.Write(cislo[i]);
            }
        }
    }
}