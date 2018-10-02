using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automobili
{
   public  class teretni : automobil

    {
        bool prikolica;
        int nosivost;

        public teretni(string t, int br_sasije, string g, bool p, int n): base(t, br_sasije, g)
        {
            prikolica = p;
            if (n < 0) throw new Exception("Ne mere");
            nosivost = n;
        }

        public override int CijenaIznajmljivanja(int brDana)
        {
            if (nosivost > 3000 && prikolica) return (int)(brDana * 6 * 1.2);
            else return brDana * 6;
           
            
        }


        public override string ToString()
        {
            string s = base.ToString();

            s = s + "prikolica: ";
            if (prikolica) s += "ima";
            else s += "nema ";
            s += "nosivost: " + nosivost;
            return s;
        }

    }

  
}
