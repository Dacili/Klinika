using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class PutnickiAutomobil : Automobil
    {
        Int32 _brSjedista;
        string _kategorija;

        public PutnickiAutomobil(string brA, string brSas, string tg, Int32 brSje, string k) : base(brA, brSas, tg) 
        {
            this.BrSjedista = brSje;
            this.Kategorija = k;

            if (this.Kategorija.Equals("Obicni"))
                this.CijenaIznajmljivanja = 3;
            else
                this.CijenaIznajmljivanja = 5;

            if(this.BrSjedista > 2)
                this.CijenaIznajmljivanja += this.CijenaIznajmljivanja*0.1;
        }

        public Int32 BrSjedista
        {
            get { return _brSjedista; }
            set { _brSjedista = value; }
        }

        public string Kategorija
        {
            get { return _kategorija; }
            set {
                if (value.Equals("Obicni") || value.Equals("Luksuzni"))
                    _kategorija = value;
                else
                    throw new Exception("Pogrešna kategorija automobila !");
            }
        }

        public override string ToString()
        {
            return "putnički automobil broj " + this.BrAutomobila + " ima " + this.BrSjedista + " sjedišta, te košta : ";
        }
    }
}
