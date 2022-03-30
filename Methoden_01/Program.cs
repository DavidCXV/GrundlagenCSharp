using System;

namespace Methoden_01
{
    class Program
    {
        static void Main(string[] args)
        {

            int amount = 0;
            amount = outputoftextTimesX();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nAnzahl der Buchstaben: {0}", amount);
            Console.ResetColor();
        }

        static int outputoftextTimesX() 
        {
            string word = null;
            int x = 0;
            bool repeat = false;  

            Console.ForegroundColor = ConsoleColor.Red;

            do
            {
                try
                {
                    Console.WriteLine("Bitte geben sie ein beliebiges Wort ein");
                    word = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("Bestimmen sie nun die Anzahl der ausgegebenen Wörtern");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
                catch (Exception)
                {
                    Console.WriteLine("ungültige Eingabe -> versuchen sie es erneut");
                    Console.Clear();
                    repeat = true;
                }
            } while (repeat);


            for (int i=0; i < x; i++) 
            {

                Console.WriteLine(word);
                            
            }

            Console.ResetColor();

            int letters = word.Length * x;

            return letters;
            
        }
        
        

    }
}
