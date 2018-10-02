using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;




using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Start_forma
{
     static class Klinika
    {
        static string ukupno_klinika = Convert.ToString(0000);
        static string ime;
        static public List<Doktor> svi_doktori = new List<Doktor>();
        static public List<Ordinacija> sve_ordinacije = new List<Ordinacija>();
        static public List<Pacijent> svi_pacijenti = new List<Pacijent>();
        static public List<Osoblje> svo_osoblje = new List<Osoblje>();

      

/*
public Klinika(string a = "MalaKlinika")
{
    ukupno_klinika = Convert.ToString((Convert.ToInt32(ukupno_klinika) + 1));
    ime = "klinika17574_" + ukupno_klinika;

    svi_doktori = new List<Doktor>();
    sve_ordinacije = new List<Ordinacija>();
    svi_pacijenti = new List<Pacijent>();
}
*/


static public void DodajDoktora(string i = "", string p = "", string d = "", string j = "", string a = "", bool da_l = true, string radi_u_ordinacijaa = "", bool da_li_je_u_kancelarijii = true, bool ima_l = false)
        {
            svi_doktori.Add(new Doktor(i, p, d, j, a, da_l, radi_u_ordinacijaa, da_li_je_u_kancelarijii, ima_l));
        }

        static public void DodajOsoblje(string i = "", string p = "", string d = "", string j = "", string a = "", bool da_l = true)
        {
            svo_osoblje.Add(new Osoblje(i, p, d, j, a, da_l));
        }

        static public void IspisiDoktore(List<Doktor> lista)
        {
            foreach (Doktor i in lista)
                i.Ispisi();

        }

        static public void DodajOrdinaciju(string ime,  bool da_l = true, int cekanje = 0)
        {
            sve_ordinacije.Add(new Ordinacija(ime, da_l, cekanje));
        }

        static public void DodajPacijenta(string i = "", string p = "", string d = "", string j = "", string a = "", bool da_l = true, string prijem = "",  Image slikica=null)
        {

            svi_pacijenti.Add(new Pacijent( i, p, d, j, a, da_l, prijem, slikica ));
        }
        static public void DodajPacijenta(Pacijent n)
        {
            svi_pacijenti.Add(n);
        }



        static public List<Pacijent> DajSvePacijente()
        {
            return svi_pacijenti;
        }

        static public void IspisiSvePacijente()
        {
            foreach (Pacijent i in svi_pacijenti)
                i.Ispisi();
            /*
            for (int i = 0; i < svi_pacijenti.Capacity; i++)
                svi_pacijenti[i].Ispisi();

            */
        }


       static public void IspisiSveDoktore()
        {
            foreach (Doktor i in svi_doktori)
                i.Ispisi();

        }





        static public Pacijent NadjiPacijenta(string user, ref bool testna)
        {
            for (int i = 0; i < svi_pacijenti.Count; i++)
            {


                if (svi_pacijenti[i].User_name == user)
                {
                    testna = true;
                    return svi_pacijenti[i];
                    //zasto nije moglo .jmbg neg morma pisati fju, sto nece geter da radi??
                    //samo stavi public ispred atributa i pasa proradit ce ;)
                }
            }
            testna = false;
           
            return new Pacijent();
            //return p;
        }

        static public Ordinacija NadjiOrdinaciju(string id, ref bool testna)
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
            
            return new Ordinacija("");
            //return p;
        }


    }
}
