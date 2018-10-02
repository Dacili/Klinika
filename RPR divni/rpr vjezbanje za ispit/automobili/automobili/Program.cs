using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automobili
{



    class Program
    {
        static void Main(string[] args)


        {
            putnicki p1= new putnicki ("mecka", 1234, "dizel", 3, "Obicni");
            putnicki p2 = new putnicki("golf", 1234, "benzin", 2, "Luksuzni");
            putnicki p3 = new putnicki("meckaaa", 1111, "dizel34", 2, "Luksuzni");

           teretni t1 = new teretni("mercedes brate", 12222, "dizel", true, 3000);
            teretni t2 = new teretni("golf", 1234, "benzin", false, 2000);
            teretni t3 = new teretni("meckaaa", 1111, "dizel34", true, 3000);

            List<automobil> listica = new List<automobil>();
            listica.Add(p1);
            listica.Add(p2);
            listica.Add(p3);
            listica.Add(t1);
            listica.Add(t2);
            listica.Add(t3);


            Console.WriteLine("Koliko zelite dana iznajmiti vozilo?");
            int dani = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unesite ime vozila");
            string ime = Console.ReadLine();
            bool nasao = false;
            foreach (automobil  i in listica)
            {
                //Console.WriteLine(i.Tip);
                //Console.WriteLine(i.Gorivo);

                if (i.Tip==ime)
                {
                    Console.WriteLine(i.ToString());
                    Console.WriteLine("a cijena iznajmljivanja je : " + i.CijenaIznajmljivanja(dani));
                    nasao = true;
                    break;
                }
            }
            if (!nasao) Console.WriteLine("nema tog vozila");
          //It workssss,   Elhamdulillah my Lorddd


            Console.ReadLine();


        }
    }
}
