using System;

namespace _21_TrizeniBubbleQuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var cisla = new int[]{5, 0, 9, 4, 7, 3};

            foreach (var i in cisla)
            {
                Console.WriteLine(i);
            }

            BubbleSort(cisla);
            Console.WriteLine();

            foreach (var i in cisla)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            var cisla2 = new int[] {5, 0, 9, 4, 7, 3};

            foreach (var i in cisla2)
            {
                Console.WriteLine(i);
            }

            QuickSort(cisla2, 0, cisla2.Length);
            Console.WriteLine();

            foreach (var i in cisla2)
            {
                Console.WriteLine(i);
            }
        }

        static void BubbleSort(int[] pole)
        {
            for (int i = 0; i < pole.Length - 1; i++)
            {
                for (int j = 0; j < pole.Length - i - 1; j++)
                {
                    if (pole[j + 1] < pole[j])
                    {
                        int hodnota = pole[j + 1];
                        pole[j + 1] = pole[j];
                        pole[j] = hodnota;
                    }
                }
            }
        }

        public static void QuickSort(int[] pole, int left, int right)
        {
            if (left < right)
            {
                int mez = left;
                for (int i = left + 1; i < right; i++)
                {
                    if (pole[i] < pole[left])
                    {
                        Swap(pole, i, ++mez);
                    }
                }
                Swap(pole, left, mez);
                QuickSort(pole, left, mez);
                QuickSort(pole, mez + 1, right);
            }
        }

        private static void Swap(int[] pole, int left, int right)
        {
            int hodnota = pole[right];
            pole[right] = pole[left];
            pole[left] = hodnota;
        }
    }
}
