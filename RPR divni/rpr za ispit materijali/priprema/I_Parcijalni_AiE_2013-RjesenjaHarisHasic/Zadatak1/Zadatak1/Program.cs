using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Automobil> vozniPark = new List<Automobil>();

            PutnickiAutomobil pa1 = new PutnickiAutomobil("123", "11111", "Benzin", 2, "Luksuzni"); // Luksuzni sa <2 sjedišta
            PutnickiAutomobil pa2 = new PutnickiAutomobil("456", "22222", "Dizel", 4, "Luksuzni"); // Luksuzni sa >2 sjedišta
            PutnickiAutomobil pa3 = new PutnickiAutomobil("789", "33333", "Benzin", 2, "Obicni"); // Obicni sa <2 sjedišta
            PutnickiAutomobil pa4 = new PutnickiAutomobil("010", "44444", "Dizel", 4, "Obicni"); // Obicni sa >2 sjedišta

            vozniPark.Add(pa1); vozniPark.Add(pa2); vozniPark.Add(pa3); vozniPark.Add(pa4);

            TeretniAutomobil ta1 = new TeretniAutomobil("321", "55555", "Benzin", false, 2); // Bez prikolice, <3 tone nosivost
            TeretniAutomobil ta2 = new TeretniAutomobil("654", "66666", "Dizel", true, 5); // Sa prikolicom, >3 tone nosivost
            TeretniAutomobil ta3 = new TeretniAutomobil("987", "77777", "Benzin", false, 5); // Bez prikolice, >3 tone nosivost
            TeretniAutomobil ta4 = new TeretniAutomobil("101", "88888", "Dizel", true, 1); // Sa prikolicom, <3 tone nosivost

            vozniPark.Add(ta1); vozniPark.Add(ta2); vozniPark.Add(ta3); vozniPark.Add(ta4);

            try {

                string auto;
                Int32 brDana;

                Boolean postoji = true;

                Console.Write("Molimo vas unesite broj automobila kojeg iznajmljujete : ");
                auto = Console.ReadLine();
                Console.Write("Molimo vas unesite broj dana na koliko iznajmljujete : ");
                brDana = Convert.ToInt32(Console.ReadLine());

                foreach (Automobil a in vozniPark)
                {
                    if (a.BrAutomobila.Equals(auto))
                    {
                        Console.WriteLine("Iznajmljen na " + brDana + " dana " + a.ToString() + a.CijenaIznajmljivanja * brDana + " KM.");
                        postoji = true;
                        break;
                    }
                    else
                        postoji = false;
                }

                if(!postoji)
                    Console.WriteLine("Unesen nepostojeći broj automobila.");

                }
                catch(Exception e) {
                    Console.WriteLine("Pogrešno uneseni podaci. Unesite sifru automobila npr. 111 i broj dana npr. 5. Hvala.");
                }

            Console.ReadLine();
        }
    }
}
