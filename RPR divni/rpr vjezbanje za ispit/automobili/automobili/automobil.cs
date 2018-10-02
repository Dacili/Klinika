using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automobili
{
   public  abstract class automobil
    {
        string tip;
        int brojSasije;
        string gorivo;

        public automobil (string t, int br, string g)
        {
            Tip = t; BrojSasije = br; Gorivo = g;
        }
        //sad poziva prvo getere i setere te oni postavljaju vrijednosti u konstruktoru

        public string Tip
        {
            get
            {
                return tip;
            }
            set
            {
                tip = value;
            }
        }

        public string Gorivo
        {
            get
            {
                return gorivo;
            }
            set
            {
                gorivo = value;
            }
        }

        public int BrojSasije {
            get { return brojSasije; }
            set  { if (value.Equals(0)) throw new Exception("ne mereee");
                else brojSasije = value; }
            }

        

        public abstract int CijenaIznajmljivanja(int brDana);
        public virtual  string ToString()
        {
            return "evo me";
            //return "tip vozila: " + tip + "gorivo: " + gorivo;
        }
    }
}
