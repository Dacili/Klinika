using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Start_forma
{
    abstract class Osoba
    {
        static string ukupno_osoba = Convert.ToString(0000);

        string ime;
        string prezime;
        string datum_rodjenja;
        string jmbg;
        string adresa_stanovanja;
        bool da_li_je_vjencan;
        string user_name;
        string sifra;

        
        public string Ime
        {
            get {
                return ime;
            }
            set
            {
                ime = value;
            }
        }

       public string Datum_rodjenja
        {
            get
            {
                return datum_rodjenja;
            }
            set
            {
                datum_rodjenja =ValidacijaDatuma(value);
            }
        }

        
         public string Jmbg {
            get { return jmbg; }
            set { jmbg = ValidacijaJMBG(value); }
        }
        public string Adresa_stanovanja { get => adresa_stanovanja; set => adresa_stanovanja = value; }
        public bool Da_li_je_vjencan { get => da_li_je_vjencan; set => da_li_je_vjencan = value; }
        public string User_name { get => user_name; set => user_name = value; }
        public string Sifra { get { return sifra; } set { sifra = value; } }
        public string Prezime { get => prezime; set => prezime = value; }

        public Osoba(string i = "", string p = "", string d = "", string j = "", string a = "", bool da_l = true)

        {
            
            ukupno_osoba = Convert.ToString((Convert.ToInt32(ukupno_osoba) + 1));
            // ime = "osoba17574_" + ukupno_klinika;
            Ime = i;
           
            Prezime = p;
            Datum_rodjenja = d;
            Jmbg = j;
            Adresa_stanovanja = a; Da_li_je_vjencan = da_l;
            User_name = "user_" + ukupno_osoba;
            Sifra = Prezime.Substring(1, 1) + Ime.Substring(1, 1)  + "_" + ukupno_osoba;

        }
      
        public virtual void AzurirajOsobu(string i = "", string p = "", string d = "", string j = "", string a = "", bool da_l = true)
        {
            Ime = i;

            Prezime = p; Datum_rodjenja = d; Jmbg = j; Adresa_stanovanja = a; Da_li_je_vjencan = da_l;
        }

        public virtual string Ispisi()
        {
            string s;
            s = (ime + " " + Prezime + " \nDatum rodjenja: " + datum_rodjenja + " \nJMBG: " + Jmbg + " \nAdresa: " + Adresa_stanovanja + " \nVjencani: ");
            if (Da_li_je_vjencan) s += "Da";
            else s += "Ne";
            return s;
        }

        public  static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
           
            return hash.ToString();
        }


        public string ValidacijaJMBG(string maticni)
        {
            
            string s = Datum_rodjenja;
           
            string dan = s.Substring(3, 2);
            string mjesec = s.Substring(0, 2);
            string godina = s.Substring(7, 3);
            string novi = dan + mjesec + godina;
           
            if (maticni.Length == 13 && maticni.Substring(0, 7) == novi)
            { 
                return maticni;
            }
            
            throw new Exception("Neispravan JMBG");
        }
        
        static public string ValidacijaDatuma(string s)
        {
            
            try
            {

                if (s.Length > 10) throw new Exception();
                int dan = Convert.ToInt32(s.Substring(3,2));
                int mjesec = Convert.ToInt32(s.Substring(0, 2));
                int godina = Convert.ToInt32(s.Substring(s.Length-4, 4));
               
                DateTime datum = new DateTime(godina, mjesec, dan, 0, 0, 0);
               
                return s;
            }
            catch(Exception )
            {
                throw new Exception("Neispravan datum");
            }
           
           
        }
        
       
        
    }
}




   



   

   