using System;

namespace Schleifen_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int hight = 7;

            for (int i = 0; i < hight; i++)
            {
                for (int k = 0; k < hight - 1 - i; k++)
                {
                    Console.Write(" ");
                }
                //Stern ausgeben              
                for (int j = 0; j < i * 2 + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
