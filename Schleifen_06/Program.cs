using System;

namespace Schleifen_06
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            int choose;

            while (!exit)
            {

                Console.WriteLine("Wollen sie mit: (1) - PayPal bezahlen"
                    + "(2) - Mit Karte bezahlen"
                   + "(0) - um den Zahlungsvorgang zu beenden");
                choose = Convert.ToInt32(Console.ReadLine());


                switch (choose)
                {
                    case 1:
                        Console.WriteLine("PayPal");
                        break;
                    case 2:
                        Console.WriteLine("Karte");
                        break;
                    case 0:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("ungültige Eingabe");
                        break;
                }

            }
            Console.ReadKey();
        }
    }
}
