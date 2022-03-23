using System;

namespace Schleifen_04
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i >= 10; i -= 10)
            {
                Console.Write(i);
            }
            Console.ReadKey();
            //mit dieser Schleife können sie die Zahlen 100 - 10 in Zehnerschritten nebeneinander ausgeben.
        }
    }
}
