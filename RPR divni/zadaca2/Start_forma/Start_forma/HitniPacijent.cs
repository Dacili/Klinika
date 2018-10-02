using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start_forma
{
    sealed class HitniPacijent : Pacijent
    {
        string prva_pomoc { get; set; }
        bool smrt { get; set; }
        string uzrok_smrti { get; set; }
        string vrijeme_smrti { get; set; }
        string vrijeme_obdukcije { get; set; }

        public HitniPacijent(string p = "", bool d = false, string u = "", string v = "", string vo = "") : base()
        {
            prva_pomoc = p;
            smrt = d; uzrok_smrti = u; vrijeme_smrti = v; vrijeme_obdukcije = vo;
        }

        public override string Ispisi()
        {
            string s = base.Ispisi();
            s += ("Prva pomoc: " + prva_pomoc);
            if (smrt == true) s += ("Uzrok i vrijeme smrti: " + uzrok_smrti + " " + vrijeme_smrti);
            
            return s;

        }
    }
}
