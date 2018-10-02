using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start_forma
{
    class Osoblje: Osoba
    {

        public Osoblje(string i, string p, string dr, string j, string a, bool d):base(i,p, dr, j, a, d)
        {
            string prvi = Sifra.Substring(0, Sifra.Length);
            Sifra = "";
            Sifra += "o.";
            Sifra += prvi;
            //Sifra = Convert.ToString((Sifra).GetHashCode());
            Sifra = MD5Hash(Sifra);
        }

        public override string Ispisi()
        {
            string s = base.Ispisi();
            s += ("Korisničko ime:" + User_name + "\n");
            return s;

        }
    }
}
