using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaIspita
{
    public class LuksuznaLinija: Linija
    {
        const Double OSNOVNA_CIJENA = 900;

        String tipVoza;
        Int32 tipUsluge;

        public LuksuznaLinija(DateTime datumPolaska, int brojSjedista, string tipVoza, int tipUsluge): base(datumPolaska, brojSjedista)
        {
            TipVoza = tipVoza;
            TipUsluge = tipUsluge;
        }

        public string TipVoza { get => tipVoza; set => tipVoza = value; }
        public int TipUsluge { get => tipUsluge; set => tipUsluge = value; }

        public override string ToString()
        {
            return "ID: " + Id + "\nDatum polaska: " + DatumPolaska.ToString() + "\nBroj sjedista: " + BrojSjedista + "\nTip voza: " + TipVoza + "\nTip usluge: " + TipUsluge;
        }

        public override Double ObracunajCijenu()
        {
            if (DatumPolaska.Hour > 13 && DatumPolaska.Hour < 18)
                return OSNOVNA_CIJENA + TipUsluge * 10;

            return OSNOVNA_CIJENA;
        }
    }
}
