using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PozoristeMega
{
    class maticno : Predstava
    {
        static int broj_karti = 80;


        string domacin;

        public maticno(string s, int v, int b, string n):
            base(s, v, b)
        {
            domacin = n;

        }

        public static int Broj_karti
        {
            get
            {
                return broj_karti;
            }
            set
            {
                broj_karti = value;
            }
        }

        public override double Cijena()
        {
            return Osnovna_cijena + 0.45 * Vrijeme_trajanja_min;
        }
        // public abstract int Cijena() { }
    }
}
