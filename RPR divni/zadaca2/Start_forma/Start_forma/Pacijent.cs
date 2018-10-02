using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Start_forma
{
   

        class Pacijent : Osoba

        {
            static string ukupno_pacijenata = Convert.ToString(0000);
            string dodatne_info, alergo, trenutne_bolesti, prijasnje_bolesti, terapija;
        bool kreiran_karton = false;

        public bool Kreiran_karton
        {
            get { return kreiran_karton; }
            set { kreiran_karton = value; }
        }

        public string Terapija
        {
            get { return terapija; }
            set { terapija = value; }
        }

        /* public string pacijent_id;
         public string Pacijent_id
     {
         get { return pacijent_id; }
         set { pacijent_id = value; }
     }*/
        List<Pregled> raspored_pregleda;
        List<int> redni_brojevi_cekanja;

        public List<int> Redni_brojevi_cekanja
        {
            get
            {
                return redni_brojevi_cekanja;
            }
            set
            {
                redni_brojevi_cekanja = value;
            }
        }

        public List<Pregled> Raspored_pregleda
        {
            get
            {
                return raspored_pregleda;
            }
            set
            {
                raspored_pregleda = value;
            }
        }

            List<Pregled> svi_obavljeni_pregledi { get; set; }
        string datum_prijema;
        public string Datum_prijema
        {
            get
            {
                return datum_prijema;
            }
            set { datum_prijema = value; }
        }

        // Karton karton;
        int broj_dolazaka_na_kliniku { get; set; }
        Image slika;

        public Image Slika
        {
            get { return slika; }
            set { slika = value; }
        }
        public string Dodatne_info { get => dodatne_info; set => dodatne_info = value; }
        public string Alergo { get => alergo; set => alergo = value; }
        public string Trenutne_bolesti { get => trenutne_bolesti; set => trenutne_bolesti = value; }
        public string Prijasnje_bolesti { get => prijasnje_bolesti; set => prijasnje_bolesti = value; }

        public void AnulirajStanje()
            {
                raspored_pregleda = new List<Pregled>();
                svi_obavljeni_pregledi = new List<Pregled>();
                datum_prijema = "";
            }

            public Pacijent( string i = "", string p = "", string d = "", string j = "", string a = "", bool da_l =true, string prijem="", Image slikica=null)
                : base(i, p, d, j, a, da_l)
            {
            broj_dolazaka_na_kliniku = 0;
               
                raspored_pregleda = new List<Pregled>();
            redni_brojevi_cekanja = new List<int>();

            Datum_prijema = prijem;
            string prvi = Sifra.Substring(0, Sifra.Length);
            Sifra = "";
            Sifra += "p.";
            Sifra += prvi;
            Sifra = MD5Hash(Sifra);
            //Sifra = Convert.ToString((Sifra).GetHashCode());




            //if (ValidacijaDatuma(prijem) == true) datum_prijema = prijem;



            slika = slikica;
                ukupno_pacijenata = Convert.ToString((Convert.ToInt32(ukupno_pacijenata) + 1));
               // pacijent_id = "pacijent17574_" + ukupno_pacijenata;
            }

            public int DajBrojDolazakaNaKliniku()
            {
                return broj_dolazaka_na_kliniku;
            }

           
            public void PovecajBrojDolazaka()
            {
                broj_dolazaka_na_kliniku++;
            }
        /*
            public string BrisiPacijenta(string id)
            {
                bool hehe = true;
                Pacijent neki = this.DajKliniku().NadjiOsobu(id, ref hehe);
                if (hehe == true)
                {
                    this.DajKliniku().svi_pacijenti.Remove(neki);
                    return "Pacijent uspjesno obrisan!";
                }
                else return ("Nije pronadjen pacijent sa unesenim ID-ijem!");
            }*/
            
            public void DodajZavrsenPregled(string s)
            {
            

                
                    
                    foreach (Pregled i in raspored_pregleda)
                    {
                        

                        s = i.dajImePregleda();
                        
                        {
                            svi_obavljeni_pregledi.Add(new Pregled(s));
                            raspored_pregleda.Remove(i);

                            break;

                        }
                    }
                    
                
            }

            



            public void DajObavljenePreglede()
            {
                foreach (Pregled i in svi_obavljeni_pregledi)
                    i.Ispis();
            }

            public int BrojObavljenihPregleda()
            {
                int brojac = 0;
                foreach (Pregled i in svi_obavljeni_pregledi)
                    brojac++;
                return brojac;
            }





            public void DajRasporedPregleda()
            {
                foreach (Pregled i in raspored_pregleda)
                    i.Ispis();
            }


        
            public void DodajPregledZaObaviti(string ime)
            {
              
                    int red_br;
                    //int red_broj = -1;
                   bool  testna = false;

                    Klinika.NadjiOrdinaciju(ime, ref testna);
                    if (testna == true)
                    {
                        (Klinika.NadjiOrdinaciju(ime, ref testna)).PovecajListuCekanja();
                        if (testna == true)
                        {
                            red_br = (Klinika.NadjiOrdinaciju(ime, ref testna)).KolikoCekaPacijenata();
                           

                            Pregled temp = new Pregled(ime);
                            temp.PostaviRedniBroj(red_br);
                            
                            raspored_pregleda.Add(temp);

                        }
                    }
                





               
                   
                //soritranje po red_br cekanja
                int k = raspored_pregleda.Count;
                

                for (int i = 0; i < k; i++)
                {
                    for (int j = i + 1; j < k; j++)
                    {
                       


                        if (raspored_pregleda[i].dajRedniBroj() > raspored_pregleda[j].dajRedniBroj())
                        {
                            Pregled temp = raspored_pregleda[i];
                            raspored_pregleda[i] = raspored_pregleda[j];
                            raspored_pregleda[j] = temp;
                        }
                    }
                }

                for(int i=0; i<k; i++)
            {
                redni_brojevi_cekanja.Add(raspored_pregleda[i].dajRedniBroj());
            }
            }










            public void KreirajKarton()
            {
           
            }

            public override void AzurirajOsobu(string i = "", string p = "", string d = "", string j = "", string a = "", bool da_l = true)
    
            {
                base.AzurirajOsobu();
                string temp;
              

            }



         



            public override string Ispisi()
            {
               string s= base.Ispisi();
                s+=("\nDatum prijema: " + datum_prijema + "\n"+"Korisničko ime:"+User_name +"\n");
            return s;

            }

            public void RasporedPregledaPacijenta()
            {
                DajRasporedPregleda();
            }




        }
    }

