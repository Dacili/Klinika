using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PozoristeMega
{
    class inostrani_gosti : Predstava
    {
        string jezik;
        static int broj_karti = 80;

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

        public inostrani_gosti(string s, int v, int b, string n):
            base(s, v, b)
        {
            Jezik = n;

        }

        public string Jezik
        {
            get
            {
                return jezik;
            }
            set
            {
                if (value.Equals("engleski") || value.Equals("njemacki"))
                    jezik = value;
                else throw new Exception("pogresan jezk");
            }
        }

        public override double Cijena()
        { double s=0;
            if (jezik == "engleski") s = 1.02;
            else if (jezik == "njemacki") s = 1.06;
            else throw new Exception("ne postoji taj jezik rodjoo");
            return (Osnovna_cijena + 0.45 * Vrijeme_trajanja_min) *s;
        }
    }
}
