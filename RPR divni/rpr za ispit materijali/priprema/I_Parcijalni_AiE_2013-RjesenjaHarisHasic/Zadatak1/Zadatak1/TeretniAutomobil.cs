using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class TeretniAutomobil : Automobil
    {
        Boolean _prikolica;
        Double _nosivost;

        public TeretniAutomobil(string brA, string brSas, string tg, Boolean p, Double n)
            : base(brA, brSas, tg) 
        {
            this.Prikolica = p;
            this.Nosivost = n;
            this.CijenaIznajmljivanja = 6;

            if (this.Prikolica && this.Nosivost > 3)
                this.CijenaIznajmljivanja += this.CijenaIznajmljivanja * 0.2;
        }

        public Boolean Prikolica
        {
            get { return _prikolica; }
            set { _prikolica = value; }
        }
        public Double Nosivost
        {
            get { return _nosivost; }
            set { _nosivost = value; }
        }

        public override string ToString()
        {
            if(this.Prikolica)
                return "teretni automobil broj " + this.BrAutomobila + " ima nosivost od " + this.Nosivost + " tone, ima prikolicu, te košta : ";
            else
                return "teretni automobil broj " + this.BrAutomobila + " ima nosivost od " + this.Nosivost + " tone, nema prikolicu, te košta : ";
        }
    }
}
