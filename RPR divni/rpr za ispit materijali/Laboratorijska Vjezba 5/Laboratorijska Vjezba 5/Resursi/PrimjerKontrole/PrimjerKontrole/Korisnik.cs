using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimjerKontrole
{
    public class Korisnik
    {
        string ime, prezime, grad, brTel, username, password;
        Boolean musko, admin, moderator;
        DateTime datumRodenja;
        Image slika;

        List<String> clanstvo;

        public Korisnik(string ime, string prezime, Boolean musko, string grad, string brTel, DateTime datumRodenja, string username, string password, Image sl, Boolean admin, Boolean moderator)
        {
            Ime = ime;
            Prezime = prezime;
            Grad = grad;
            BrTel = brTel;
            Username = username;
            Password = password;
            Musko = musko;
            DatumRodenja = datumRodenja;
            Slika = sl;
            Admin = admin;
            Moderator = moderator;

            clanstvo = new List<String>();
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

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }
        public string Grad
        {
            get
            {
                return grad;
            }

            set
            {
                grad = value;
            }
        }

        public string BrTel
        {
            get
            {
                return brTel;
            }

            set
            {
                brTel = value;
            }
        }
        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
        public Boolean Musko
        {
            get
            {
                return musko;
            }

            set
            {
                musko = value;
            }
        }

        public DateTime DatumRodenja
        {
            get
            {
                return datumRodenja;
            }

            set
            {
                datumRodenja = value;
            }
        }

        public Image Slika
        {
            get
            {
                return slika;
            }

            set
            {
                slika = value;
            }
        }

        public Boolean Admin
        {
            get
            {
                return admin;
            }

            set
            {
                admin = value;
            }
        }

        public Boolean Moderator
        {
            get
            {
                return moderator;
            }

            set
            {
                moderator = value;
            }
        }

        public List<string> Clanstvo
        {
            get
            {
                return clanstvo;
            }

            set
            {
                clanstvo = value;
            }
        }

        public void dodajClanstvo(String str)
        {
            Clanstvo.Add(str);
        }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
