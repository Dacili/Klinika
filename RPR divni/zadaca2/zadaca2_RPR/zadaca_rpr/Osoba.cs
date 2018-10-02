using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca_rpr
{
    abstract class Osoba
    {
        static string ukupno_klinika = Convert.ToString(0000);

        string ime { get; set; }
        string prezime { get; set; }
        string datum_rodjenja { get; set; }
        protected string jmbg { get; set; }
        string adresa_stanovanja { get; set; }
        bool da_li_je_vjencan { get; set; }
        string user_name { get; set; }
        string sifra { get; set; }
       
        public Osoba(string i = "", string p = "", string d = "", string j = "", string a = "", bool da_l = true)

        {
            //validacija
            ukupno_klinika = Convert.ToString((Convert.ToInt32(ukupno_klinika) + 1));
            ime = "osoba17574_" + ukupno_klinika;
            //ime = i;
            prezime = p; datum_rodjenja = d; jmbg = j; adresa_stanovanja = a; da_li_je_vjencan = da_l;

        }

        public virtual void UnosOsobe()
        {
            string temp;
            Console.WriteLine("Unesite ime: "); temp = Console.ReadLine();
            ime = temp;
            Console.WriteLine("Unesite prezime: "); temp = Console.ReadLine();
            prezime = temp;
           


            Console.WriteLine("Unesite datum rodjenja: godina/mjesec/dan "); temp = Console.ReadLine();

            if (ValidacijaDatuma(temp))
                datum_rodjenja = temp;
            else
                while (true)
                {
                    Console.WriteLine("Neispravan datum rodjenja\nIzvrsite unos ponovo!");
                    temp = Console.ReadLine();
                    if (ValidacijaDatuma(temp))
                    {
                        //Console.WriteLine("fja vraca true");
                        datum_rodjenja = temp; break;
                    }
                }



            Console.WriteLine("Unesite JMBG: "); temp = Console.ReadLine();
            if (ValidacijaJMBG(temp, datum_rodjenja))
                jmbg = temp;


            else
                while (true)
                {
                    Console.WriteLine("Neispravan JMBG\nIzvrsite unos ponovo!");
                    temp = Console.ReadLine();
                    if (ValidacijaJMBG(temp, datum_rodjenja))
                    {
                        //Console.WriteLine("fja vraca true");
                        datum_rodjenja = temp; break;
                    }
                }


            Console.WriteLine("Unesite adresu stanovanja: "); temp = Console.ReadLine();
            adresa_stanovanja = temp;
            Console.WriteLine("Vjencani: da ili ne "); temp = Console.ReadLine();
            if (ValidacijaVjencan(ref temp))
            {
                if (Convert.ToBoolean(string.Compare(temp, "da"))) da_li_je_vjencan = true;
                else da_li_je_vjencan = false;
            }
            else
                while (true)
                {
                    Console.WriteLine("Neispravan unos\nIzvrsite unos ponovo!");
                    temp = Console.ReadLine();
                    if (ValidacijaVjencan(ref temp))
                    {
                        if (Convert.ToBoolean(string.Compare(temp, "da"))) da_li_je_vjencan = true;
                        else da_li_je_vjencan = false;

                        break;
                    }
                }




        }

        public virtual string Ispisi()
        {
            string s;
            s = (ime + " " + prezime + " \nDatum rodjenja: " + datum_rodjenja + " \nJMBG: " + jmbg + " \nAdresa: " + adresa_stanovanja + " \nVjencani: ");
            if (da_li_je_vjencan) s += "Da";
            else s += "Ne";
            return s;
        }


        static public bool ValidacijaJMBG(string maticni, string s)
        {
            //Console.WriteLine("maticni je " + maticni + "ima karaktera " + maticni.Length);
            string dan = s.Substring(8, 2);
            string mjesec = s.Substring(5, 2);
            string godina = s.Substring(1, 3);
            string novi = dan + mjesec + godina;
            //Console.WriteLine(novi);
            if (maticni.Length == 13 && maticni.Substring(0, 7) == novi)
            { //Console.WriteLine("vrij iz fje je true!!!"); 
                return true;
            }
            return false;
        }

        static public bool ValidacijaDatuma(string s)
        {


            try
            {

                if (s.Length > 11) return false;
                int dan = Convert.ToInt32(s.Substring(8, 2));
                int mjesec = Convert.ToInt32(s.Substring(5, 2));
                int godina = Convert.ToInt32(s.Substring(0, 4));
                // Console.WriteLine(dan + " " + mjesec + " " + godina+ "\n");
                DateTime datum = new DateTime(godina, mjesec, dan, 0, 0, 0);
                //Console.WriteLine(dan + " " + mjesec + " " + godina + "\n");
                return true;
            }
            catch
            {
                return false;
            }
        }
        static public bool ValidacijaVjencan(ref string s)
        {
            if (s == "da" || s == "DA" || s == "Da") { s = "da"; return true; }
            else if (s == "ne" || s == "NE" || s == "Ne") { s = "ne"; return true; }
            return false;
        }
    }
}




   



   

   