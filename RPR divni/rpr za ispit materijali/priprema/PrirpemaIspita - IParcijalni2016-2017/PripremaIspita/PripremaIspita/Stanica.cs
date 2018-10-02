using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaIspita
{
    public class Stanica
    {
        delegate void MojDelegat();

        List<Linija> linije;

        public Stanica()
        {
            linije = new List<Linija>();
        }

        public List<Linija> PretragaLinija(DateTime dt)
        {
            return linije.FindAll(x => x.DatumPolaska.DayOfWeek.ToString().Equals(dt.DayOfWeek.ToString()) && x.DatumPolaska.Hour.Equals(dt.Hour));
        }

        public void KupiKartu(Int32 id)
        {
            linije.Single(x => x.Id.Equals(id)).BrojSjedista -= 1;
            //linije.Find(x => x.Id.Equals(id)).SmanjiBrojSjedista(1);
        }

        public void DodajLiniju(Linija l)
        {
            linije.Add(l);
        }

        public String IspisiIzvjestaj()
        {
            String rez = "";

            foreach (Linija x in linije.OrderByDescending(x => x.BrojSjedista))
                rez += x.ToString() + "\nTip: " + x.GetType().Name + "\n";

            return rez;
        }
    }
}
