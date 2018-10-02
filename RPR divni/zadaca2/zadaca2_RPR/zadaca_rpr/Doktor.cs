using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca_rpr
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
        }

        public override void UnosOsobe()
        {
            base.UnosOsobe();
            string temp = "";
            Console.WriteLine("Unesite ordinaciju: "); temp = Console.ReadLine();
            radi_u_ordinaciji = temp;
            Console.WriteLine("Da li je u kancelariji: "); temp = Console.ReadLine();
            da_li_je_u_kancelariji = Convert.ToBoolean(temp);
            Console.WriteLine("Da li ima pacijenta: "); temp = Console.ReadLine();
            da_li_ima_pacijenta = Convert.ToBoolean(temp);
            Console.WriteLine("\nUspjesno unesen doktor!\n");



        }

        public override string Ispisi()
        {
            string s = base.Ispisi();
            s += ("\nOrdinacija: " + radi_u_ordinaciji + " \nDa li je u kancelariji: " + Convert.ToString(da_li_je_u_kancelariji));
            return s;

        }
    }
}


