using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    public abstract class Automobil
    {
        string _brAutomobila;
        string _brSasije;
        string _tipGoriva;
        Double _cijenaIznajmljivanja;

        public Automobil(string brA, string brS, string tg)
        {
            this.BrAutomobila = brA;
            this.BrSasije = brS;
            this.TipGoriva = tg;
        }

        public string BrAutomobila
        {
            get { return _brAutomobila; }
            set { _brAutomobila = value; }
        }

        public string BrSasije
        {
            get { return _brSasije; }
            set { _brSasije = value; }
        }

        public string TipGoriva
        {
            get { return _tipGoriva; }
            set { _tipGoriva = value; }
        }

        public Double CijenaIznajmljivanja
        {
            get { return _cijenaIznajmljivanja; }
            set { _cijenaIznajmljivanja = value; }
        }

        public override string ToString()
        {
            return "";
        }
    }
}
