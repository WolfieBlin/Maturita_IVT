using System;

namespace vzdalenostDvouBodu20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte první bod\nX");
            var x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Y");
            var y1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Zadejte druhý bod\nX");
            var x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Y");
            var y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Vzdálenost mezi těmihle body je " + Math.Round(VzdalenostDvouBodu(x1, y1, x2, y2), 2));
        }

        public static double VzdalenostDvouBodu(double x1, double y1, double x2, double y2)
        {
            var vzdalenostX = Math.Abs(x2 - x1);
            var vzdalenostY = Math.Abs(y2 - y1);

            var vzdalenost = Math.Sqrt(vzdalenostX * vzdalenostX + vzdalenostY * vzdalenostY);

            return vzdalenost;
        }
    }
}