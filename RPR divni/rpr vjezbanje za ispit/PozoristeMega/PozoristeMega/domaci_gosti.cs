using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PozoristeMega
{
    class  domaci_gosti : Predstava
    {
        static int broj_karti = 80;
        string naziv_gosta;
        int udaljenost;


        public static int Broj_karti
        {
            get
            {
                return broj_karti;
            }
            set
            {
                broj_karti = value;
            }
        }

        public domaci_gosti (string s, int v, int b,  string n, int u):
            base(s, v, b)
        {
            Naziv_gosta = n;

        }
        

        
        public override double Cijena()
        {
            return (Osnovna_cijena+0.45*Vrijeme_trajanja_min)+ 0.1*udaljenost;
        }


        public string Naziv_gosta
        {
            get
            {
                return naziv_gosta;
            }
            set
            {
                naziv_gosta = value;
            }
        }

        public int Udaljenost
        {
            get
            {
                return udaljenost;
            }
            set
            {
                udaljenost = value;
            }
        }


    }
}
