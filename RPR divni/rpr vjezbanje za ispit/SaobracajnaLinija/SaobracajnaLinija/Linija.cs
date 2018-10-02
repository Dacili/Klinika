using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaobracajnaLinija
{
   public abstract class Linija
    {
        static int ID_voznje=0;
        string dan_polaska;
        string vrijeme_polaska;
        int broj_mjesta;





       public  int Daj_ID_voznje()
        {
            return ID_voznje;
        }


        public Linija(string d, string v, int br) {
            Dan_polaska = d; Vrijeme_polaska = v;
            Broj_mjesta = br;
            ID_voznje++;
        }

        public int Broj_mjesta
        {
            get
            {
                return broj_mjesta;
            }
            set
            {
                broj_mjesta = value;
            }
        }
        public string Dan_polaska
        {
            get
            {
                return dan_polaska;
            }
            set
            {
                dan_polaska = value;
            }
        }

        public string Vrijeme_polaska
        {
            get
            {
                return vrijeme_polaska;
            }
            set
            {
                
                vrijeme_polaska = ProvjeriVrijeme(value);
            }
        }

        public string ProvjeriVrijeme(string vr)
        {
            if (Convert.ToInt64(vr.Substring(0, 2)) < 3 || Convert.ToInt32(vr.Substring(0, 2) )> 24)
                throw new Exception();
            return vr;
        }

        public abstract float Cijena();
        public virtual string Ispisi()
        {
            return "Dan polaska je " + dan_polaska + "Vrijeme polaska: " + vrijeme_polaska + "Broj mjesta: " + broj_mjesta;
        }
    }
}
