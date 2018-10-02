using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaIspita
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Stanica s = new Stanica();

                KomercijalnaLinija kl = new KomercijalnaLinija(DateTime.Now, 55, 5);
                KomercijalnaLinija kl1 = new KomercijalnaLinija(DateTime.Now, 65, 5);
                LuksuznaLinija ll = new LuksuznaLinija(new DateTime(2017, 11, 19, 04, 0, 0), 100, "Talgo", 2);

                s.DodajLiniju(ll);
                s.DodajLiniju(kl);
                s.DodajLiniju(kl1);


                s.KupiKartu(1);

                //Console.WriteLine(kl.ToString());
                //Console.WriteLine(ll.ToString());

                Console.WriteLine(s.IspisiIzvjestaj());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
