using System;

namespace prevodStupneRadian14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte stupně na převod");
            var stupne = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Stupně převedeny na radiány:\n" + PrevodStupneRadian(stupne) + " radiánů");
        }

        public static double PrevodStupneRadian(double stupne)
        {
            var radiany = stupne / 180 * Math.PI;

            return radiany;
        }
    }
}