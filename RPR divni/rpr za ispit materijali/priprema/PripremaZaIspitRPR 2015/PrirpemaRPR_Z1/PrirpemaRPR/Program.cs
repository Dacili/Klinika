using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrirpemaRPR
{
    class Program
    {
        static void Main(string[] args)
        {
            Predstava p = new Predstava("Hamlet", 100, 10);

            DomacaGostujucaPredstava dgp = new DomacaGostujucaPredstava("Kralj Lir", 100, 10, "Pozoriste Zenica", 100);

            InostranaGostujucaPredstava igp = new InostranaGostujucaPredstava("Romeo i Julija", 100, 10, "Berlin Theater", 100, "Njemacki");
            InostranaGostujucaPredstava igp1 = new InostranaGostujucaPredstava("Romeo i Julija", 100, 10, "London Theater", 100, "Engleski");
            InostranaGostujucaPredstava igp2 = new InostranaGostujucaPredstava("Romeo i Julija", 100, 10, "Peru Theater", 100, "Spanski");

            try
            {
                //p.kupiKarte("POZ", 15);

                Console.WriteLine(p.kupiKarte("POZ", 1));
                Console.WriteLine(dgp.kupiKarte("POZ", 1));
                Console.WriteLine(igp.kupiKarte("POZ", 1));
                Console.WriteLine(igp1.kupiKarte("POZ", 1));
                Console.WriteLine(igp2.kupiKarte("POZ", 1));

                p.kupiKarte("POZ", 10);
                p.kupiKarte("POZ", 10);
                p.kupiKarte("POZ", 10);
                p.kupiKarte("POZ", 10);
                p.kupiKarte("POZ", 10);
                p.kupiKarte("POZ", 10);
                p.kupiKarte("POZ", 10);
                p.kupiKarte("POZ", 10);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
