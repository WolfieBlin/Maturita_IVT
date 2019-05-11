using System;

namespace fronta22
{
    public class Fronta
    {
        public bool konec;

        private void NoveAuto(string[] pole)
        {
            Console.WriteLine("Zadejte nové auto");
            pole[Array.IndexOf(pole, null)] = Console.ReadLine();
        }

        private void PrycAuto(string[] pole)
        {
            Console.WriteLine("Auto k opravě: " + pole[0]);

            foreach (var s in pole)
            {
                if (Array.LastIndexOf(pole, s) == 9 || pole[Array.LastIndexOf(pole, s)] == null) continue;
                pole[Array.LastIndexOf(pole, s)] = pole[Array.LastIndexOf(pole, s) + 1];
            }

            pole[9] = null;
        }

        private void VypisAuta(string[] pole)
        {
            var pocitadlo = 1;
            foreach (var s in pole)
            {
                Console.WriteLine(pocitadlo + ". " + s);
                pocitadlo++;
            }
        }

        private void SrotAuta(string[] pole)
        {
            foreach (var s in pole) pole[Array.IndexOf(pole, s)] = null;
        }

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