using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak8_Rjesenje
{
    public class Predmet
    {
        string naziv;
        int brojECTS;

        public Predmet(string n, int br)
        {
            Naziv = n;
            BrojECTS = br;
        }

        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                naziv = value;
            }
        }

        public int BrojECTS
        {
            get
            {
                return brojECTS;
            }

            set
            {
                brojECTS = value;
            }
        }
    }
}
