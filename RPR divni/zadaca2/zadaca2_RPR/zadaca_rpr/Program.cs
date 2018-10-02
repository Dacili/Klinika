using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca_rpr
{
    class Program
    {
        delegate bool MojDelegat(ref int par);


        static void Main(string[] args)
        {

            Klinika MalaKlinika = new Klinika();
            Doktor Medina = new Doktor("Medina", "Dacic", "16051996", "1605996175068");
            MalaKlinika.DodajDoktora("Medina", "Dacic", "16051996", "1605996175068");
            MalaKlinika.DodajDoktora("Neki", "Sandzo", "11111991", "11111991175068");
            MalaKlinika.DodajPacijenta("Bolesnik", "Prvi", "01051996", "0105996175068");
            MalaKlinika.DodajPacijenta("Bolesnik", "Drugi", "12071996", "1207996175068");

            MalaKlinika.DodajOrdinaciju("Ortopedija", 102, true, 0);
            MalaKlinika.DodajOrdinaciju("Kardiologija", 103, true, 0);
            MalaKlinika.DodajOrdinaciju("Dermatologija", 104, true, 0);
            MalaKlinika.DodajOrdinaciju("Otorinolaringologija", 105, true, 0);
            MalaKlinika.DodajOrdinaciju("Oftalmologija", 106, true, 0);
            MalaKlinika.DodajOrdinaciju("Laboratorija", 107, true, 0);
            MalaKlinika.DodajOrdinaciju("Stomatologija", 108, true, 0);
            MalaKlinika.DodajOrdinaciju("Hirurgija", 109, true, 0);

            bool ValidacijaUnosa(ref int n)
            {
                if (n == 1 || n == 2 || n == 3 || n == 4 || n == 5 || n == 6 || n == 7 || n == 8)
                    return true;

                return false;
            }


            MojDelegat delegatic;
            delegatic = new MojDelegat(ValidacijaUnosa);








            int unos;

            Pacijent test_fja(ref bool testna)
            {
                string id;

                Console.WriteLine("Unesite id pacijenta: ");
                id = Console.ReadLine();
                MalaKlinika.NadjiOsobu(id, ref testna);
                if (testna == true) return MalaKlinika.NadjiOsobu(id, ref testna);
                else throw new Exception();
            }



            do
            {
                Console.WriteLine("Dobro dosli!\nOdaberite neku od sljedecih opcija:\n");
                Console.WriteLine("1.Registruj/brisi pacijenta\n2.Prikazi raspored pregleda pacijenta\n3.Kreiranje kartona pacijenta\n4.Pretraga kartona pacijenta\n5.Registruj novi pregled\n6.Analiza sadrzaja\n7.Naplata\n8.Izlaz");
                int br = 0;
                do
                {
                    if (br == 1) Console.WriteLine("Neispravan odabir opcije!\nPonovite odabir opcije!");
                    try
                    {
                        unos = Convert.ToInt32(Console.ReadLine());
                        br = unos;
                    }
                    catch
                    {
                        Console.WriteLine("Pogresan odabir opcije!");
                        unos = -1;
                    }

                }
                while (!delegatic(ref unos));
                Pacijent p = new Pacijent(MalaKlinika);

                bool testna = true;
                switch (unos)
                {
                    case 1:
                        Console.WriteLine("1 - za registraciju pacijenta\n2 - za brisanje pacijenta ");
                        string broj = Console.ReadLine();

                        if (broj == "1")
                        {

                            p.UnosOsobe();
                            MalaKlinika.DodajPacijenta(p);
                        }
                        else if (broj == "2")
                        {
                            testna = false;
                            p = test_fja(ref testna);
                            p.BrisiPacijenta(p.DajID());
                        }
                        else Console.WriteLine("Neispravan odabir opcije");
                        //p.Ispisi();
                        break;

                    case 2:
                        //daje raspored pregleda
                        try
                        {
                            testna = false;
                            p = test_fja(ref testna);

                            if (testna == true) p.DajRasporedPregleda();
                        }
                        catch
                        {
                            Console.WriteLine("Neispravni podaci!\n");
                        }

                        break;
                    case 3:
                        //kreira karton
                        try
                        {
                            testna = false;
                            p = test_fja(ref testna);

                            if (testna == true) p.KreirajKarton();
                        }
                        catch
                        {
                            Console.WriteLine("Neispravni podaci!\n");
                        }

                        break;
                    case 4:
                        //pretraga kartona pacijenta
                        try
                        {
                            testna = false;
                            p = test_fja(ref testna);

                            if (testna == true)
                            {
                                p.DajObavljenePreglede();
                                p.DajRasporedPregleda();
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Neispravni podaci!\n");
                        }

                        break;
                    case 5:
                        //registruj pregled, znaci dodaj zavrseni pregled

                        try
                        {
                            testna = false;
                            p = test_fja(ref testna);

                            if (testna == true)
                            {


                                p.DodajZavrsenPregled();

                            }
                        }
                        catch
                        {
                            Console.WriteLine("Neispravni podaci!\n");
                        }



                        break;
                    case 6:
                        //analiza sadrzaja
                        Console.WriteLine("Za listing svih doktora pritisnite 1\n" +
                            "Za listing svih pacijenata pritisnite 2\n" +
                            "Za najzastupljenije dječije zarazne bolesti pritisnite 3\n" +
                            "Za odjel koji je najmanje posjećen ove godine pritisnite 4");
                        int opcija = Convert.ToInt32(Console.ReadLine());
                        if (opcija == 1) MalaKlinika.IspisiSveDoktore();
                        else if (opcija == 2) MalaKlinika.IspisiSvePacijente();
                        else if (opcija == 3)
                            Console.WriteLine("1.Vodene kozice(Varicele)\n2.Ospice\n3.Hripavac\n4.Rubeola");
                        else if (opcija == 4) Console.WriteLine("Otorinolaringologija");

                        else Console.WriteLine("Neispravan unos!");



                        break;
                    case 7:
                        //naplata
                        try
                        {
                            testna = false;
                            p = test_fja(ref testna);


                            int cijena = 15 * p.BrojObavljenihPregleda();
                            int temp = p.DajBrojDolazakaNaKliniku();
                            bool redovan = false;
                            if (temp > 3) redovan = true;

                            Console.WriteLine("Gotovina ili rate : g ili r");
                            string nacin_placanja = Console.ReadLine();
                            if (nacin_placanja == "g")
                            {
                                if (redovan == true) cijena = Convert.ToInt32((double)cijena * 0.9);
                                //p.DajObavljenePreglede();
                                Console.WriteLine("Za svaki navedeni pregled cijena je 15KM.\nUkupan iznos za naplatu je " + cijena);


                            }
                            else if (nacin_placanja == "r")
                            {
                                if (redovan == true) ;
                                else cijena = Convert.ToInt32((double)cijena * 1.15);
                                Console.WriteLine("Na koliko rata zelite placanje (najvise 4): ");
                                int br_rata = Convert.ToInt32(Console.ReadLine());
                                //p.DajObavljenePreglede();
                                Console.WriteLine("Za svaki obavljeni pregled cijena je 15KM.\nUkupan iznos naplate za prvu ratu  je " + cijena / br_rata);

                            }
                            p.PovecajBrojDolazaka();
                            p.AnulirajStanje();





                        }

                        catch
                        {
                            Console.WriteLine("Neispravni podaci!\n");
                        }





                        break;
                    case 8:
                        break;
                }
            } while (unos != 8);
            Console.WriteLine("\nSrdacan pozdrav!");
            Console.ReadKey();
        }
    }
}
