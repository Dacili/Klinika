using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeineDLL
{
    class Aparat
    {
        string ime { get; set; }
        bool radi_li { get; set; }
        int radi_neprestano_h { get; set; }

        public Aparat(string i = "aparat_17574_1", bool r = true, int n = 0)
        {
            ime = i; radi_li = r; radi_neprestano_h = 0;
        }


    }
}
