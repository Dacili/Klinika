using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaobracajnaLinija
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Linija> l = new List<Linija>();
            Komercijalna k1 = new Komercijalna("pon", "16:00", 10, 4);
            Komercijalna k2 = new Komercijalna("sub", "15:00", 20, 4);
            Luksuzna l1 = new Luksuzna("pon", "16:00", 30, "talgo", 1);
            Luksuzna l2 = new Luksuzna("pon", "10:00", 14, "talgo", 1);
            l.Add(k1);
            l.Add(k2);
            l.Add(l1);
            l.Add(l2);

            Console.WriteLine("Unesite dan polaska: ");
            string dan = Console.ReadLine();
            Console.WriteLine("Unesite vrijeme polaska: ");
            string vrijeme = Console.ReadLine();
            bool testna = false;
            foreach(Linija i in l)
            {
                if(i.Dan_polaska==dan && i.Vrijeme_polaska == vrijeme)
                {
                    Console.WriteLine(i.Ispisi());
                    Console.WriteLine("cijena: "+ i.Cijena());
                    
                    testna = true;

                }
            }
            if (testna == false) Console.WriteLine("Nije pronadjena linija");
            Console.ReadLine();
        }
    }
}
