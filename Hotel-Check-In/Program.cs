using System;

namespace Hotel_Check_In
{
    class Program
    {
        static void Main(string[] args)
        {
            Personen gast1 = new Personen();

            gast1.roomnumber = 45;
            gast1.firstname = "John";
            gast1.surname = "Lennon";
            gast1.sleepovers = 1;
            gast1.invoiceamount = 82.46;

            Personen gast2 = new Personen();

            gast2.roomnumber = 45;
            gast2.firstname = "Paul";
            gast2.surname = "McCartney";
            gast2.sleepovers = 4;
            gast2.invoiceamount = 329.84;

            Personen gast3 = new Personen();

            gast3.roomnumber = 45;
            gast3.firstname = "George";
            gast3.surname = "Harrison";
            gast3.sleepovers = 12;
            gast3.invoiceamount = 989.52;

            Personen gast4 = new Personen();

            gast4.roomnumber = 45;
            gast4.firstname = "Ringo";
            gast4.surname = "Starr";
            gast4.sleepovers = 3;
            gast4.invoiceamount = 247.38;

            //Personen[] gaeste = 
        }
    }
}
