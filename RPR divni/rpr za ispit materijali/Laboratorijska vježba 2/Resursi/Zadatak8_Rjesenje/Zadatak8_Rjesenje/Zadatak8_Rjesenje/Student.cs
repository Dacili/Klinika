using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak8_Rjesenje
{
    public class Student : Osoba
    {
        int godinaStudija;

        public Student(string i, string p, int gs): base(i,p)
        {
            GodinaStudija = gs;
        }

        public int GodinaStudija
        {
            get
            {
                return godinaStudija;
            }

            set
            {
                godinaStudija = value;
            }
        }
    }
}
