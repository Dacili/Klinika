using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start_forma
{
    class Ordinacija
    {
        protected string naziv { get; set; }
        Doktor doktor { get; set; }
       // int lokacija { get; set; }//br_sobe
        bool slobodna { get; set; }
        int lista_cekanja { get; set; }
        List<Aparat> lista_aparata { get; set; }

        public Ordinacija(string ime,  bool da_l = true, int cekanje = 0)
        {
            naziv = ime;  slobodna = da_l; lista_cekanja = cekanje;
        }
        public void PovecajListuCekanja()
        {
            lista_cekanja++;

        }

        public void DodajAparat(string i, bool n, int h)
        {
            lista_aparata.Add(new Aparat(i, n, h));
        }
        public int KolikoCekaPacijenata()
        {
            return lista_cekanja;
        }

        public string DajNazivOrdinacije()
        {
            return naziv;
        }


    }
}
