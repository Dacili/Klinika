using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaobracajnaLinija
{
    class Luksuzna  : Linija
    {
        const int Fiksna_cijena_L = 900;
        string tip_voza;
        int tip_usluge;

        public Luksuzna(string d, string vr, int br, string t, int usluga) : base(d, vr, br){
            tip_voza = t;
            Tip_usluge = usluga;
        }

        public int Tip_usluge
        {
            get
            {
                return tip_usluge;
            }
            set
            {
                if (value.Equals(1) || value.Equals(2))
                    tip_usluge = value;
                else throw new Exception();
            }
        }

        public string Tip_voza
        {
            get
            {
                return tip_voza;

            }
            set
            {
                tip_voza = value;
            }
        }

        public override float Cijena()
        {
            if (Convert.ToInt32(Vrijeme_polaska.Substring(0, 2)) >= 13 && Convert.ToInt32(Vrijeme_polaska.Substring(0, 2)) <= 18)
                    return Fiksna_cijena_L + tip_usluge * 10;
            else return Fiksna_cijena_L;

        }
        public override string Ispisi()
        {
            return base.Ispisi() + " Tip voza: " + tip_voza + "Tip usluge: " + tip_usluge;
        }
    }
}
