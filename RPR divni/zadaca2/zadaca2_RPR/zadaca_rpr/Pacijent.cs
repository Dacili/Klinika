using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca_rpr
{
   

        class Pacijent : Osoba

        {
            static string ukupno_pacijenata = Convert.ToString(0000);
            string dodatne_info, trenutne_bolesti, prijasnje_bolesti;
            Klinika klinika;
            string pacijent_id;
            List<Pregled> raspored_pregleda { get; set; }

            List<Pregled> svi_obavljeni_pregledi { get; set; }
            string datum_prijema { get; set; }
            string alergo_info { get; set; }
            // Karton karton;
            int broj_dolazaka_na_kliniku { get; set; }

            public void AnulirajStanje()
            {
                raspored_pregleda = new List<Pregled>();
                svi_obavljeni_pregledi = new List<Pregled>();
                datum_prijema = "";
            }

            public Pacijent(Klinika k, string i = "", string p = "", string d = "", string j = "", string a = "", bool da_l = true, string prijem = "", string ale = "", int br_dol = 0)
                : base(i, p, d, j, a, da_l)
            {
                klinika = k;
                raspored_pregleda = new List<Pregled>();



                if (ValidacijaDatuma(prijem) == true) datum_prijema = prijem;


                alergo_info = ale; broj_dolazaka_na_kliniku = br_dol;
                ukupno_pacijenata = Convert.ToString((Convert.ToInt32(ukupno_pacijenata) + 1));
                pacijent_id = "pacijent17574_" + ukupno_pacijenata;
            }

            public int DajBrojDolazakaNaKliniku()
            {
                return broj_dolazaka_na_kliniku;
            }

            public Klinika DajKliniku()
            {
                return klinika;
            }
            public void PovecajBrojDolazaka()
            {
                broj_dolazaka_na_kliniku++;
            }

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
            }

            public void DodajZavrsenPregled()
            {
                Console.WriteLine("Koji pregled je pacijent zavrsio (unesite odgovarajuci broj)?");
                Console.WriteLine("1 - ORTOPEDIJA\n2 - KARDIOLOGIJA\n3 - DERMATOLOGIJA");
                Console.WriteLine("4 - OTORINOLARINGOLOGIJA\n5 - OFTALMOLOGIJA\n6 - LABORATORIJA");
                Console.WriteLine("7 - STOMATOLOGIJA\n8 - HIRURGIJA");
                string zavrsen = Console.ReadLine();
                if (zavrsen == "1") zavrsen = "Ortopedija";
                else if (zavrsen == "2") zavrsen = "Kardiologija";
                else if (zavrsen == "3") zavrsen = "Dermatologija";
                else if (zavrsen == "4") zavrsen = "Otorinolaringologija";
                else if (zavrsen == "5") zavrsen = "Oftalmologija";
                else if (zavrsen == "6") zavrsen = "Laboratorija";
                else if (zavrsen == "7") zavrsen = "Stomatologija";
                else if (zavrsen == "8") zavrsen = "Hirurgija";
                else
                {
                    Console.WriteLine("Pogresan odabir opcije");
                    zavrsen = "-1";
                }

                if (zavrsen != "-1")
                {
                    string temp;
                    foreach (Pregled i in raspored_pregleda)
                    {
                        Console.WriteLine("usao");

                        temp = i.dajImePregleda();
                        if (temp == zavrsen)
                        {
                            svi_obavljeni_pregledi.Add(new Pregled(zavrsen));
                            raspored_pregleda.Remove(i);

                            break;

                        }
                    }
                    Console.WriteLine("Uspjesno ste dodali zavrseni pregled!\n");
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

            public void DodajPregledZaObaviti()
            {
                Console.WriteLine("Koje preglede pacijent zeli obaviti (unesite odgovarajuce brojeve, mozete razdvojiti razmakom)?");
                Console.WriteLine("1 - ORTOPEDIJA\n2 - KARDIOLOGIJA\n3 - DERMATOLOGIJA");
                Console.WriteLine("4 - OTORINOLARINGOLOGIJA\n5 - OFTALMOLOGIJA\n6 - LABORATORIJA");
                Console.WriteLine("7 - STOMATOLOGIJA\n8 - HIRURGIJA");
                string svi_pregledi = Console.ReadLine();

                int provjera;
                bool test = false;
                //int red_br=0;

                void FJA(string ime, ref bool testna)
                {

                    int red_br;
                    //int red_broj = -1;
                    testna = false;

                    klinika.NadjiOrdinaciju(ime, ref testna);
                    if (testna == true)
                    {
                        (klinika.NadjiOrdinaciju(ime, ref testna)).PovecajListuCekanja();
                        if (testna == true)
                        {
                            red_br = (klinika.NadjiOrdinaciju(ime, ref testna)).KolikoCekaPacijenata();
                            // Console.WriteLine("red br je " + red_broj);

                            Pregled temp = new Pregled(ime);
                            temp.PostaviRedniBroj(red_br);
                            // Console.WriteLine("usao");
                            raspored_pregleda.Add(temp);

                        }
                    }
                }





                for (int i = 0; i < svi_pregledi.Length; i++)
                {
                    provjera = Convert.ToInt32(svi_pregledi[i]) - '0';
                    if (provjera == 1)
                        FJA("Ortopedija", ref test);



                    else if (provjera == 2)
                        FJA("Kardiologija", ref test);
                    else if (provjera == 3)
                        FJA("Dermatologija", ref test);

                    else if (provjera == 4) FJA("Otorinolaringologija", ref test);

                    else if (provjera == 5) FJA("Oftalmologija", ref test);


                    else if (provjera == 6) FJA("Laboratorija", ref test);

                    else if (provjera == 7) FJA("Stomatologija", ref test);

                    else if (provjera == 8) FJA("Hirurgija", ref test);

                    else if (Convert.ToChar(svi_pregledi[i]) == ' ' || Convert.ToChar(svi_pregledi[i]) == ',') continue;
                    else continue;

                }
                //soritranje po red_br cekanja
                int k = raspored_pregleda.Count;
                // Console.WriteLine("k je " + k);

                for (int i = 0; i < k; i++)
                {
                    for (int j = i + 1; j < k; j++)
                    {
                        //Console.WriteLine("kapacitet liste je " + raspored_pregleda.Count + "i je " + i + " " + raspored_pregleda[i].dajRedniBroj());
                        //Console.WriteLine(" j je " + j + " " + raspored_pregleda[j].dajRedniBroj());


                        if (raspored_pregleda[i].dajRedniBroj() > raspored_pregleda[j].dajRedniBroj())
                        {
                            Pregled temp = raspored_pregleda[i];
                            raspored_pregleda[i] = raspored_pregleda[j];
                            raspored_pregleda[j] = temp;
                        }
                    }
                }
            }










            public void KreirajKarton()
            {
                svi_obavljeni_pregledi = new List<Pregled>();
                Console.WriteLine("Informacije o trenutnim bolestima pacijenta: ");
                trenutne_bolesti = Console.ReadLine();

                Console.WriteLine("Informacije o prijasnjim bolestima pacijenta: ");
                prijasnje_bolesti = Console.ReadLine();
                Console.WriteLine("Zdravstveno stanje clanova porodice:");
                dodatne_info = Console.ReadLine();
                Console.WriteLine("Karton je kreiran!\n");
            }
            public override void UnosOsobe()
            {
                base.UnosOsobe();
                string temp;
                Console.WriteLine("Unesite datum prijema: godina/mjesec/dan "); temp = Console.ReadLine();

                if (ValidacijaDatuma(temp))
                    datum_prijema = temp;
                else
                    while (true)
                    {
                        Console.WriteLine("Neispravan datum prijema\nIzvrsite unos ponovo!");
                        temp = Console.ReadLine();
                        if (ValidacijaDatuma(temp))
                        {
                            // Console.WriteLine("fja vraca true");
                            datum_prijema = temp; break;
                        }
                    }

                Console.WriteLine("Unesite alergo info "); temp = Console.ReadLine();
                alergo_info = temp;



                DodajPregledZaObaviti();
                Console.WriteLine("\nUspjesno unesen pacijent!\n");

            }



            public string DajID()
            {
                return pacijent_id;
            }



            public override string Ispisi()
            {
               string s= base.Ispisi();
                s+=("Pacijent ID: " + pacijent_id + "\nDatum prijema: " + datum_prijema + " \nAlergo info: " + alergo_info);
            return s;

            }

            public void RasporedPregledaPacijenta()
            {
                DajRasporedPregleda();
            }




        }
    }

