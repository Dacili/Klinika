using System;
using System.Collections.Generic;



using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace zadaca_rpr
{
     partial class Klinika
    {
        static string ukupno_klinika = Convert.ToString(0000);
        string ime;
        public List<Doktor> svi_doktori { get; set; }
        public List<Ordinacija> sve_ordinacije { get; set; }
        public List<Pacijent> svi_pacijenti { get; set; }


        public Klinika(string a = "MalaKlinika")
        {
            ukupno_klinika = Convert.ToString((Convert.ToInt32(ukupno_klinika) + 1));
            ime = "klinika17574_" + ukupno_klinika;

            svi_doktori = new List<Doktor>();
            sve_ordinacije = new List<Ordinacija>();
            svi_pacijenti = new List<Pacijent>();
        }



        public void DodajDoktora(string i = "", string p = "", string d = "", string j = "", string a = "", bool da_l = true, string radi_u_ordinacijaa = "", bool da_li_je_u_kancelarijii = true, bool ima_l = false)
        {
            svi_doktori.Add(new Doktor(i, p, d, j, a, da_l, radi_u_ordinacijaa, da_li_je_u_kancelarijii, ima_l));
        }

        public void IspisiDoktore(List<Doktor> lista)
        {
            foreach (Doktor i in lista)
                i.Ispisi();

        }

        public void DodajOrdinaciju(string ime, int n, bool da_l = true, int cekanje = 0)
        {
            sve_ordinacije.Add(new Ordinacija(ime, n, da_l, cekanje));
        }

        public void DodajPacijenta(string i = "", string p = "", string d = "", string j = "", string a = "", bool da_l = true, string prijem = "", string ale = "", int br_dol = 0)
        {

            svi_pacijenti.Add(new Pacijent(this, i, p, d, j, a, da_l, prijem, ale, br_dol));
        }
        public void DodajPacijenta(Pacijent n)
        {
            svi_pacijenti.Add(n);
        }



        public List<Pacijent> DajSvePacijente()
        {
            return svi_pacijenti;
        }

        public void IspisiSvePacijente()
        {
            foreach (Pacijent i in svi_pacijenti)
                i.Ispisi();
            /*
            for (int i = 0; i < svi_pacijenti.Capacity; i++)
                svi_pacijenti[i].Ispisi();

            */
        }


        public void IspisiSveDoktore()
        {
            foreach (Doktor i in svi_doktori)
                i.Ispisi();

        }





        public Pacijent NadjiOsobu(string id, ref bool testna)
        {
            for (int i = 0; i < svi_pacijenti.Capacity; i++)
            {


                if (svi_pacijenti[i].DajID() == id)
                {
                    testna = true;
                    return svi_pacijenti[i];
                    //zasto nije moglo .jmbg neg morma pisati fju, sto nece geter da radi??
                }
            }
            testna = false;
            //Console.WriteLine("Pacijent sa unesenim ID-jem nije pronadjen!");
            return new Pacijent(this);
            //return p;
        }

        public Ordinacija NadjiOrdinaciju(string id, ref bool testna)
        {
            for (int i = 0; i < sve_ordinacije.Capacity; i++)
            {


                if (sve_ordinacije[i].DajNazivOrdinacije() == id)
                {
                    testna = true;
                    return sve_ordinacije[i];
                    //zasto nije moglo .jmbg neg morma pisati fju, sto nece geter da radi??
                }
            }
            testna = false;
            //Console.WriteLine("Pacijent sa unesenim ID-jem nije pronadjen!");
            return new Ordinacija("");
            //return p;
        }


    }
}
