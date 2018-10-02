using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrirpemaRPR
{
    public class DomacaGostujucaPredstava: Predstava
    {
        string nazivGostujucegPozorista;
        double udaljenost;

        public DomacaGostujucaPredstava(string naziv, int duzinaTrajanja, int brojGlumaca, string nazivGostujucegPozorista, double udaljenost): base(naziv, duzinaTrajanja, brojGlumaca)
        {
            NazivGostujucegPozorista = nazivGostujucegPozorista;
            Udaljenost = udaljenost;
        }

        public string NazivGostujucegPozorista
        {
            get
            {
                return nazivGostujucegPozorista;
            }

            set
            {
                nazivGostujucegPozorista = value;
            }
        }

        public double Udaljenost
        {
            get
            {
                return udaljenost;
            }

            set
            {
                udaljenost = value;
            }
        }

        public override Double kupiKarte(string nazivPozorista, int brojKarata)
        {
            if (brojKarata > dajMAX_BROJ_KARATA_PO_TRANSAKCIJI() || brojKarata > dajMAX_BROJ_KARATA())
                throw new Exception("Tranasakcija neuspjela.");
            else
            {
                postaviMAX_BROJ_KARATA(dajMAX_BROJ_KARATA() - brojKarata);
                return brojKarata*((dajOSNOVNU_CIJENU() + dajOSNOVNU_CIJENU_PO_MINUTI() * DuzinaTrajanja) * (1 + (Udaljenost*0.1)));
            }
        }
    }
}
