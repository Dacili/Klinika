using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrirpemaRPR
{
    public class Predstava
    {
        static int MAX_BROJ_KARATA = 80;
        const int MAX_BROJ_KARATA_PO_TRANSAKCIJI = 10;
        const double OSNOVNA_CIJENA = 3;
        const double OSNOVNA_CIJENA_PO_MINUTI = 0.45;

        string naziv;
        Int32 duzinaTrajanja, brojGlumaca;
        DateTime datum;

        public Predstava(string naziv, int duzinaTrajanja, int brojGlumaca)
        {
            Naziv = naziv;
            DuzinaTrajanja = duzinaTrajanja;
            BrojGlumaca = brojGlumaca;
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

        public int DuzinaTrajanja
        {
            get
            {
                return duzinaTrajanja;
            }

            set
            {
                duzinaTrajanja = value;
            }
        }

        public int BrojGlumaca
        {
            get
            {
                return brojGlumaca;
            }

            set
            {
                brojGlumaca = value;
            }
        }

        public int dajMAX_BROJ_KARATA() { return MAX_BROJ_KARATA; }
        public void postaviMAX_BROJ_KARATA(int max) { MAX_BROJ_KARATA = max; }
        public int dajMAX_BROJ_KARATA_PO_TRANSAKCIJI() { return MAX_BROJ_KARATA_PO_TRANSAKCIJI; }
        public double dajOSNOVNU_CIJENU() { return OSNOVNA_CIJENA; }
        public double dajOSNOVNU_CIJENU_PO_MINUTI() { return OSNOVNA_CIJENA_PO_MINUTI; }

        public virtual Double kupiKarte(string nazivPozorista, int brojKarata)
        {
            if (brojKarata > MAX_BROJ_KARATA_PO_TRANSAKCIJI || brojKarata > MAX_BROJ_KARATA)
                throw new Exception("Tranasakcija neuspjela.");
            else
            {
                MAX_BROJ_KARATA = MAX_BROJ_KARATA - brojKarata;
                return brojKarata*(OSNOVNA_CIJENA + OSNOVNA_CIJENA_PO_MINUTI*DuzinaTrajanja);
            }
        }
    }
}
