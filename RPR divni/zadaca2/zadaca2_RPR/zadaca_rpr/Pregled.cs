using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca_rpr
{
    class Pregled
    {
        int redni_broj { get; set; }
        string ime_ordinacije;

        //Pacijent pacijent { get; set; }
        string anamneza { get; set; }

        public Pregled(string ime_ord, string misljenje = "nije obavljen pregled", int l = 0, bool sl = true)
        {
            if (ime_ord != "Hirurgija" || ime_ord != "Stomatologija" || ime_ord != "Oftalmologija" || ime_ord != "Ortopedija" ||
                ime_ord != "Laboratorija" || ime_ord != "Dermatologija" || ime_ord != "Otorinolaringologija" || ime_ord != "Kardiologija")
                ime_ordinacije = ime_ord;
            else throw new Exception("Nepostojeci odjel!");
            anamneza = misljenje;

        }

        /*public Pregled (Pregled p)
        {

        }*/
        public int dajRedniBroj()
        {
            return redni_broj;
        }

        public string dajImePregleda()
        {
            return ime_ordinacije;
        }
        public string Ispis()
        {
            return ("Pregled potrebno obaviti u ordinaciji " + ime_ordinacije + " Redni broj cekanja:" + redni_broj);
            // " Vrijeme pregleda " +vrijeme_pregleda);
        }

        public void PostaviRedniBroj(int n)
        {
            redni_broj = n;
        }

    }


}
