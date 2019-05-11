using System;

namespace zasobnik23
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] seznam = new string[10];

            Zasobnik zasobnik = new Zasobnik();

            
            while (!zasobnik.konec)
            {
                zasobnik.Vyber(seznam);

            }
        }
    }
}
