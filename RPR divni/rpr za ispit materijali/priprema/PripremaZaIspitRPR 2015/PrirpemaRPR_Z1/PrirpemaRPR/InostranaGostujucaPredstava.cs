using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrirpemaRPR
{
    public class InostranaGostujucaPredstava: DomacaGostujucaPredstava
    {
        string jezik;

        public InostranaGostujucaPredstava(string naziv, int duzinaTrajanja, int brojGlumaca, string nazivGostujucegPozorista, double udaljenost, string jezik) : base(naziv, duzinaTrajanja, brojGlumaca, nazivGostujucegPozorista, udaljenost)
        {
            Jezik = jezik;
        }

        public string Jezik
        {
            get
            {
                return jezik;
            }

            set
            {
                jezik = value;
            }
        }

        public override Double kupiKarte(string nazivPozorista, int brojKarata)
        {
            if (brojKarata > dajMAX_BROJ_KARATA_PO_TRANSAKCIJI() || brojKarata > dajMAX_BROJ_KARATA())
                throw new Exception("Tranasakcija neuspjela.");
            else
            {
                postaviMAX_BROJ_KARATA(dajMAX_BROJ_KARATA() - brojKarata);

                if(Jezik.Equals("Njemacki"))
                    return brojKarata*(((dajOSNOVNU_CIJENU() + dajOSNOVNU_CIJENU_PO_MINUTI() * DuzinaTrajanja) * (1 + (Udaljenost * 0.1)))) * 1.06;
                else if(Jezik.Equals("Engleski"))
                    return brojKarata * (((dajOSNOVNU_CIJENU() + dajOSNOVNU_CIJENU_PO_MINUTI() * DuzinaTrajanja) * (1 + (Udaljenost * 0.1)))) * 1.02;
                else
                    return brojKarata * ((dajOSNOVNU_CIJENU() + dajOSNOVNU_CIJENU_PO_MINUTI() * DuzinaTrajanja) * (1 + (Udaljenost * 0.1)));
            }
        }
    }
}
