using System;

namespace kvadranty15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte bod ležící v rovině\nHodnota X");
            var x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hodnota Y");
            var y = Convert.ToInt32(Console.ReadLine());

            Kvadrant(x, y);
        }

        public static void Kvadrant(int x, int y)
        {
            var kvadrant = 0;
            
            if (x == 0 || y == 0)
            {
                if (x == 0 && y == 0)
                {
                    Console.WriteLine("Bod se nachází ve středu soustavy souřadnic");
                }else if (x == 0)
                {
                    Console.WriteLine("Bod se nachází na ose y");
                }
                else
                {
                    Console.WriteLine("Bod se nachází na ose x");
                }
            }
            else if (x > 0)
            {
                if (y > 0)
                {
                    kvadrant = 1;
                }
                else
                {
                    kvadrant = 4;
                }
            }else 
            {
                if (y > 0)
                {
                    kvadrant = 2;
                }
                else
                {
                    kvadrant = 3;
                }
            }

            if (kvadrant != 0)
            {
                Console.WriteLine("Bod se nachází v {0} kvadrantu", kvadrant);
            }
        }
        
    }
}