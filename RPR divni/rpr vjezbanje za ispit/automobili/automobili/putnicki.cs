using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automobili
{
    public class putnicki : automobil
    {
        int brojSjedista;
        string kategorija;


        public putnicki(string t, int br_sasije, string g, int br, string kat): base(t, br_sasije, g)
        {
            if (br < 1) throw new Exception("Kud si poso");
            else BrojSjedista = br;

            Kategorija = kat;
        }

        public string Kategorija
        {
            get
            {
                return kategorija;
            }
            set
            {
                if (value.Equals("Luksuzni") || value.Equals("Obicni"))
                    kategorija = value;
                else throw new Exception("no emotions no relationship");
            }

        }



        public int BrojSjedista
        {
            get
            {
                return brojSjedista;
            }
            set
            {
               
                brojSjedista = postavi(value);
            }

        }

            public int postavi (int n)
        {
            if (n < 0) throw new Exception("ne moze <0 sjedista");
            return n;
        }


        public override int CijenaIznajmljivanja(int brDana)
        {
            if (Kategorija == "Obicni")
            {
                if (BrojSjedista <= 2) return 3 * brDana;
                else if (BrojSjedista > 2) return (int) (3 * brDana * 1.1);

            }
            else if (Kategorija == "Luksuzna")
            {

                if (BrojSjedista <= 2) return 5 * brDana;
                else if (BrojSjedista > 2) return (int)(5 * brDana * 1.1);

            }
            return -1;
        }

        public override string ToString()
        {

            
            Console.WriteLine("usaoooo");
            
                return base.ToString() + "broj sjedista: " +  "kategorija: " + kategorija;
            
        }

    }
}
