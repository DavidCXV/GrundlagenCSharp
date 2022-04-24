using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Check_In
{
    class Personen
    {
        #region Konstruktoren 
        public Personen() : this(0," "," ", 0, 0) { }
        public Personen(short rn):this(rn, " ", " ", 0, 0) { }
        public Personen(short rn, string fn):this(rn, fn, " ", 0, 0) { }
        public Personen(short rn, string fn, string sn):this(rn, fn, sn, 0, 0) { }
        public Personen(short rn, string fn, string sn, short sl):this(rn, fn, sn, sl, 0) { }
        public Personen(short rn, string fn, string sn, short sl, double am)
        {
            roomnumber = rn;
            firstname = fn;
            surname = sn;
            sleepovers = sl;
            invoiceamount = am; 
        }
        #endregion

        #region Eigenschaften der Instanz
        public short roomnumber { get; set; }
        public short sleepovers { get; set; }
        public double invoiceamount { get; set; }
        public string firstname { get; set; }
        public string surname { get; set; }
        #endregion
              
    }
}
