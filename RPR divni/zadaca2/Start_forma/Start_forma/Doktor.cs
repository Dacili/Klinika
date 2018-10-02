using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Start_forma
{
    class Doktor : Osoba
    {

        string radi_u_ordinaciji { get; set; } //je l ovo visak
        bool da_li_je_u_kancelariji { get; set; }
        bool da_li_ima_pacijenta { get; set; }

        //konstruktor
        public Doktor(string i = "", string p = "", string d = "", string j = "", string a = "", bool da_l = true, string radi_u_ordinacijaa = "", bool da_li_je_u_kancelarijii = true, bool ima_l = false)
                : base(i, p, d, j, a, da_l)
        {

            radi_u_ordinaciji = radi_u_ordinacijaa; da_li_ima_pacijenta = ima_l;
            da_li_je_u_kancelariji = da_li_je_u_kancelarijii;
            string prvi = Sifra.Substring(0, Sifra.Length);
            Sifra = "";
            Sifra += "d.";
            Sifra += prvi;
            //Sifra = Convert.ToString((Sifra).GetHashCode());
            Sifra = MD5Hash(Sifra);
        }

       

        public override void AzurirajOsobu(string i = "", string p = "", string d = "", string j = "", string a = "", bool da_l = true)
        
        {
            base.AzurirajOsobu();
            string temp = "";
           
            radi_u_ordinaciji = temp;
          



        }

        public override string Ispisi()
        {
            string s = base.Ispisi();
            s += ("Korisničko ime:"+User_name+ "\nOrdinacija: " + radi_u_ordinaciji + " \nDa li je u kancelariji: " + Convert.ToString(da_li_je_u_kancelariji));
            return s;

        }
    }
}


