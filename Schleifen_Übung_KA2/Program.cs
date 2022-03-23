using System;

namespace Schleifen_Übung_KA2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            double K = 0; //Guthaben 
            double p = 0; //Zinssatz pro Jahr
            short n = 0; //Anlagedauer pro Jahr

            double Z = 0;
            double Kn = 0;
            double KZ = 0;
            double B = 0;

            Console.WriteLine("Geben sie ihr Kapital ein");
            K = Convert.ToDouble(Console.ReadLine());
            Kn = K;

            Console.WriteLine("Geben sie ihre Anlage Dauer in Jahren an");
            n = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Geben sie ihren Zinssatz pro Jahr an");
            p = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine($"{"Jahr",4} {"Guthaben",10} {"Zinsen",8} {"K.Zinsen",10} {"Bilanz",8}");

            for (int l = 1; l <= 43; l += 1)
            {

                Console.Write("-");

            }

            Console.WriteLine();

            for (int i = 1; i < n; i += 1)
            {
                Z = Kn * (p / 100);
                KZ = KZ + Z;
                B = B + Kn;
                Console.WriteLine($"{n,4} {999,10} {999,8} {"K.Zinsen",10} {K2,8}");

            }

            Console.ResetColor();
        }
    }
}
