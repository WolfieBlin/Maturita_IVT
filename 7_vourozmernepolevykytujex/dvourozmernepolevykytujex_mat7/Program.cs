using System;

namespace DvourozmernePoleVykytujeX_mat7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var hledanyPrvek = "X";
            var obsahuje = false;
            
            Console.WriteLine("Zadejte kolika rozměrné má být pole. Zadejte počet řádků: ");
            var x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Zadejte počet sloupců:");
            var y = Convert.ToInt32(Console.ReadLine());
            
            var pole = new String[x,y];
            Console.WriteLine("Zadejte některé hodnoty do pole");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.WriteLine("Prvek: " + i+1 + " / " +  j+1);
                    pole[i, j] = Console.ReadLine();
                }
            }

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (pole[i,j] == hledanyPrvek)
                    {
                        obsahuje = true;
                    }
                }
            }

            if (obsahuje)
            {
                Console.WriteLine("Pole obsahuje: " + hledanyPrvek);
            }
            else
            {
                Console.WriteLine("Pole neobsahuje: " + hledanyPrvek);
            }
        }
    }
}