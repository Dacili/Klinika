using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak8_Rjesenje
{
    public class Profesor : Osoba
    {
        int brojPublikacija;

        public Profesor(string i, string p, int bp): base(i, p)
        {
            BrojPublikacija = bp;
        }

        public int BrojPublikacija
        {
            get
            {
                return brojPublikacija;
            }

            set
            {
                brojPublikacija = value;
            }
        }
    }
}
