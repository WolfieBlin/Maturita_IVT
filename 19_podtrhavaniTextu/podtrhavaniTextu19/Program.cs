using System;

namespace podtrhavaniTextu19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte textový řetězec");
            var retezec = Console.ReadLine();

            Console.WriteLine("Zadejte počet znaků na podtrhávání");
            var pocet = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Zadejte postupně znaky na podtrhávání");
            
            char[] znaky = new char[pocet];
            
            for (int i = 0; i < pocet; i++)
            {
                znaky[i] = Convert.ToChar(Console.ReadLine());
            }
            
            PodtrhavaniTextu(retezec, znaky);
        }
        
        public static void PodtrhavaniTextu(string retezec, char[] znaky)
        {
            var prazdneMisto = " ";
            var podtrzeni = "-";
            
            foreach (var znak in retezec)
            {
                Console.Write("{0 , 2}", znak);
            }

            Console.WriteLine();
            
            foreach (var znak in retezec)
            {
                var obsahuje = false;
                
                foreach (var znakNaPodtrzeni in znaky)
                {
                    if (znak == znakNaPodtrzeni)
                    {
                        obsahuje = true;
                    }
                }
                
                if (obsahuje)
                {
                    Console.Write("{0 , 2}", podtrzeni);
                }else
                {
                    Console.Write("{0 , 2}", prazdneMisto);
                }

            }
        }
    }
}