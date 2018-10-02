using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaIspita
{
    public class KomercijalnaLinija: Linija
    {
        const Double OSNOVNA_CIJENA = 800;

        Int32 brojZaustavljanja;

        public KomercijalnaLinija(DateTime datumPolaska, int brojSjedista, int brojZaustavljanja): base(datumPolaska, brojSjedista)
        {
            BrojZaustavljanja = brojZaustavljanja;
        }

        public int BrojZaustavljanja { get => brojZaustavljanja; set => brojZaustavljanja = value; }

        public override string ToString()
        {
            return "ID: " + Id + "\nDatum polaska: " + DatumPolaska.ToString() + "\nBroj sjedista: " + BrojSjedista + "\nBroj zaustavljanja: " + BrojZaustavljanja;
        }

        public override Double ObracunajCijenu()
        {
            if (DatumPolaska.DayOfWeek.ToString().Equals("Saturday") || DatumPolaska.DayOfWeek.ToString().Equals("Sunday"))
                return OSNOVNA_CIJENA * 0.75;

            return OSNOVNA_CIJENA;
        }
    }
}
