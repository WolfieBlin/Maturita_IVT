using System;
using System.Collections.Generic;
using System.Text;

namespace zasobnik23
{
    class Zasobnik
    {
        public bool konec = false;


        string[] NoveAuto(string[] pole)
        {
            Console.WriteLine("Zadejte nové auto");
            for (int i = pole.Length - 1; i > 0; i--)
            {

                if (i == 0) continue;
                pole[i] = pole[i - 1];//sesype zásobník, poslední přepadne přes okraj a už ho nikdo nikdy neuvidí
            }
            pole[0] = Console.ReadLine();
            return pole;
        }
        //noveauto
        string[] PrycAuto(string[] pole)
        {
            Console.WriteLine("Auto k opravě: " + pole[0]);

            foreach (string s in pole)
            {
                if (Array.LastIndexOf(pole, s) == 9 || pole[Array.LastIndexOf(pole, s)] == null)
                {

                    continue;
                }
                pole[Array.LastIndexOf(pole, s)] = pole[Array.LastIndexOf(pole, s) + 1];
            }

            pole[9] = null;
            return pole;
        }
        //prycauto
        void VypisAuta(string[] pole)
        {
            int pocitadlo = 1;
            foreach (string s in pole)
            {
                Console.WriteLine(pocitadlo + ". " + s);
                pocitadlo++;
            }
        }
        //vypisauta
        void SrotAuta(string[] pole)
        {
            foreach (string s in pole)
            {
                pole[Array.IndexOf(pole, s)] = null;
            }



        }
        //srotauta
        public void Vyber(string[] pole)
        {



            Console.WriteLine("Auta ve frontě:");
            VypisAuta(pole);
            Console.WriteLine();
            Console.WriteLine("Výtejte v autoopravně, přejete si? ");
            Console.WriteLine("1:přidat auto");
            Console.WriteLine("2:opravit první auto ve frontě");
            Console.WriteLine("3: sešrotovat vše ve frontě");
            Console.WriteLine("4: ukočit program");
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        NoveAuto(pole);
                        Console.Clear();
                        break;
                    }
                case "2":
                    {
                        if (Array.IndexOf(pole, null) == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Nelze, fronta prázdná");
                            Console.WriteLine();
                            break;
                        }
                        PrycAuto(pole);
                        Console.Clear();
                        break;
                    }
                case "3":
                    {
                        SrotAuta(pole);
                        Console.Clear();
                        break;
                    }
                case "4":
                    {
                        konec = true;
                        break;
                    }

                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Špatně zadaná hodnota");
                        Console.WriteLine();
                        break;
                    }
            }
        }
    }
}
