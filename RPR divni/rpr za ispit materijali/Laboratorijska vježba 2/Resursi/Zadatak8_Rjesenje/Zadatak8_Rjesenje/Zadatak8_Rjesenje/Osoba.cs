using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak8_Rjesenje
{
    public abstract class Osoba
    {
        string ime, prezime;

        public Osoba(string i, string p)
        {
            Ime = i;
            Prezime = p;   
        }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }
    }
}
