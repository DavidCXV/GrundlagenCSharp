using System;

namespace Schleifen_03
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                double Quadrierung = 2;
                double Ergebnis = Math.Pow(i, Quadrierung);
                Console.WriteLine("Die Zahl: {0} | Das Quadrat der Zahl ist: {1}", i, Ergebnis);
            }

            Console.ReadKey();
        }
    }
}
