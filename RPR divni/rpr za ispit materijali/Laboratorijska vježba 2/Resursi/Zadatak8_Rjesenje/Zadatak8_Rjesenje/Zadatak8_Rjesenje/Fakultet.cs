using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak8_Rjesenje
{
    public class Fakultet
    {
        string ime;
        Dictionary<string, Student> studenti;
        Dictionary<Tuple<string, string>, Profesor> profesori;
        List<Predmet> predmeti;
        public Fakultet(String i)
        {
            Ime = i;
            studenti = new Dictionary<string, Student>();
            profesori = new Dictionary<Tuple<string, string>, Profesor>();
            predmeti = new List<Predmet>();
        }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public Dictionary<string, Student> Studenti
        {
            get
            {
                return studenti;
            }

            set
            {
                studenti = value;
            }
        }

        public Dictionary<Tuple<string, string>, Profesor> Profesori
        {
            get
            {
                return profesori;
            }

            set
            {
                profesori = value;
            }
        }

        public List<Predmet> Predmeti
        {
            get
            {
                return predmeti;
            }

            set
            {
                predmeti = value;
            }
        }

        // Metode za studente
        public void registrujStudenta(string ind, Student s)
        {
            Studenti.Add(ind, s);
        }
        public string pretraziStudentePoIndeksu(string ind) // Vraća ime studenta na osnovu indeksa
        {
            Student s;

            if (Studenti.TryGetValue(ind, out s))
                return s.Ime + " " + s.Prezime;
            else
                return "Student sa unijetim brojem indeksa ne postoji.";
        }

        // Metode za profesore
        public void registrujProfesora(string titula, string jmb, Profesor p)
        {
            Tuple<string,string> k = Tuple.Create<string,string>(titula, jmb);
            Profesori.Add(k, p);
        }
        public int prebrojProfesore(string titula) // Vraća broj profesora po navedenoj tituli
        {
            int br = 0;

            foreach (Tuple<string, string> p in Profesori.Keys)
                if (p.Item1.Equals(titula))
                    br++;

            return br;
        }

        // Metode za predmete
        public void registrujPredmet(Predmet p)
        {
            Predmeti.Add(p);
        }

        public List<Predmet> dajPredmeteNaOsnovuECTS(int br) // Prikazuje predmete na osnovu unijetog broja ECTS bodova
        {
            List<Predmet> rez = new List<Predmet>();

            foreach (Predmet p in Predmeti)
                if (p.BrojECTS == br)
                    rez.Add(p);

            return rez;
        } 
    }
}
