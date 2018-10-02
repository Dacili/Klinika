using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaobracajnaLinija
{
    class Komercijalna : Linija
    {
        const int Fiksna_Cijena_K = 800;
        int broj_zaustavljanja;

        public Komercijalna(string d, string vr, int br, int br_zaust) : base(d, vr, br){
            broj_zaustavljanja = br_zaust;
        }

        public override float Cijena()
        {
            if (Dan_polaska == "ned" || Dan_polaska == "sub")
                return (float)(Fiksna_Cijena_K * 0.85);
            else return Fiksna_Cijena_K;
        }

        public override string Ispisi()
        {
            return base.Ispisi() + "Broj zaustavljanja: " + broj_zaustavljanja;
        }
    }
}
