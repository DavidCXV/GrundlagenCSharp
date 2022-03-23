using System;

namespace Methoden_01
{
    class Program
    {
        static void Main(string[] args)
        {

            int amount = 0;
            amount = outputoftextTimesX();

            Console.WriteLine("\nAnzahl der Buchstaben: {0}", amount);

        }

        static int outputoftextTimesX() 
        {
            string word;
            int x;

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
            
            }

            for (int i=0; i < x; i++) 
            {

                Console.WriteLine(word);
                            
            }

            int letters = word.Length * x;

            return letters;
            
        }
        
    
    }
}
