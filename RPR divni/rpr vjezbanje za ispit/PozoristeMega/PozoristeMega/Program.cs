using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PozoristeMega
{
    class Program
    {
        static void Main(string[] args)
        {
            domaci_gosti d1 = new domaci_gosti("sarajevo", 90, 10, "tuzlaci", 350);
            domaci_gosti d2 = new domaci_gosti("sarajevo", 60, 5, "zenica", 100);
            domaci_gosti d3 = new domaci_gosti("sarajevo", 120, 7, "sandze", 250);

            List<Predstava> lista = new List<Predstava>();
            lista.Add(d1);
            lista.Add(d2);
            lista.Add(d3);

            Console.WriteLine("Naziv predstave koju zelite gledati?");
            string naz = Console.ReadLine();
            Console.WriteLine("Koliko zelite karti kupiti?");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 11)
                foreach (domaci_gosti i in lista)
                {
                    if (i.Naziv == naz)
                    {
                        int k = i.Broj_karti;
                       

                        Console.WriteLine("cijena za " + n + "karti je " + i.Cijena());
                    }
            }
            else Console.WriteLine("max broj karti koje mozete kupiti je 10");


        }
    }
}
