namespace fronta22
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var seznam = new string[10];
            var fronta = new Fronta();

            while (!fronta.konec) fronta.Vyber(seznam);
        }
    }
}