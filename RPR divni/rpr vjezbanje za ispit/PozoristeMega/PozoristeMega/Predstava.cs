using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PozoristeMega
{
    abstract class Predstava
    {
        string naziv;
        int  vrijeme_trajanja_min;
        int br_glumaca;
        DateTime datum_odrzavanja;
        
        int osnovna_cijena = 3;
        //konstruktor

            public int Osnovna_cijena
        {
            get
            {
                return osnovna_cijena;
            }
        }
        public Predstava(string s, int v, int b)
        {
            Naziv = s;
            Vrijeme_trajanja_min = v;
            Br_glumaca = b;
        }


        //napravilo smo propretye, getere i setere
        public string Naziv {
            get
            {
                return naziv;
            }
            set
            {
                naziv = value;
            }
        }
        public int Vrijeme_trajanja_min {
            get
            {
                return vrijeme_trajanja_min;
            }
            set
            {
                
                vrijeme_trajanja_min = ProvjeriVrijeme(value);
            }
        }

        public int ProvjeriVrijeme (int n)
        {
            if (n < 0 || n > 120) throw new Exception();
            return n;
        } 

        public int Br_glumaca {
            get
            {
                return br_glumaca;
            }

            set
            {
                br_glumaca = ProvjeraGlumaca(value);
            }
        }

        public int ProvjeraGlumaca (int n)
        {
            if (n < 0 || n > 20) throw new Exception();
            return n;
        }
        public DateTime Datum_odrzavanja {
            get
            {
                return datum_odrzavanja;
            }
            set
            {
                datum_odrzavanja = value;
            }
        }

        public abstract double Cijena();
    }
}
