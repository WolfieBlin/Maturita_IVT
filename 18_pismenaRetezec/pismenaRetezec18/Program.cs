using System;

namespace pismenaRetezec18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte textový řetězec zakončený tečkou");
            var retezec = Console.ReadLine();

            if (kontrolaPismen(retezec))
            {
                Console.WriteLine("Textový řetěžec obsahuje po písmenech h, r písmeno i.");
            }
            else
            {
                Console.WriteLine("Textový řetěžec NEobsahuje po písmenech h, r písmeno i.");
            }
        }

        public static bool kontrolaPismen(string retezec)
        {
            var pismeno1 = 'h';
            var pismeno2 = 'r';

            var retezecNaSlova = retezec.Split();

            foreach (var slovo in retezecNaSlova)
            {
                for (int i = 0; i < slovo.Length; i++)
                {
                    if (slovo[i] == pismeno1 || slovo[i] == pismeno2)
                    {
                        if (slovo[i + 1] == 'i')
                        {
                            return true;
                        }
                    }  
                }
            }
            

            return false;
        }
    }
}