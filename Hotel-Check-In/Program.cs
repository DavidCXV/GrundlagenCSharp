using System;
using System.Collections.Generic;

namespace Hotel_Check_In
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Personen gast1 = new Personen(45, "John", "Lennon", 1,82.46);
                        

            Personen gast2 = new Personen(23, "Paul", "McCartney", 4, 329.84);
                        

            Personen gast3 = new Personen(3, "George", "Harrison", 12, 989.52);

            
            Personen gast4 = new Personen(32, "Ringo", "Starr", 3, 247.38);

            
            Personen[] gaeste = { gast1, gast2, gast3, gast4 };

            
                                    
        }

        static (bool,Personen) GetData(int diff, Personen[] gaesteliste)
        {
            bool erfolg = false;
            string failed = "Kein Eintrag unter dieser Zimmernummer";
            Console.ForegroundColor = ConsoleColor.Green;           
            Console.WriteLine("\t - Warte auf Eingabe der Zimmernummer: ");
            Console.ResetColor();
            diff = Convert.ToInt32(Console.ReadLine());

            
                switch (diff)
                {
                    case 45:
                        erfolg = true;
                        break;
                    case 23:
                        erfolg = true;
                        break;
                    case 3:
                        erfolg = true;
                        break;
                    case 32:
                        erfolg = true;
                    break;

                }
            
            

            if (erfolg==true)
            {

                return;
            }
            else
            {
                return ;
            }
            
            

        }

        
    }
}
