using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak8_Rjesenje
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kreiranje instance fakulteta
            Fakultet f = new Fakultet("ETF");

            // Popunjavanje instance fakulteta sa podacima o studentima preko kreirane metode
            Student s1 = new Student("Haris", "Hasić", 1); f.registrujStudenta("16111", s1);
            Student s2 = new Student("Kerim", "Hodžić", 2); f.registrujStudenta("16222", s2);
            Student s3 = new Student("Denis", "Hasanbašić", 3); f.registrujStudenta("16333", s3);
            Student s4 = new Student("Haris", "Smajlagić", 4); f.registrujStudenta("16444", s4);
            Student s5 = new Student("Emir", "Cogo", 5); f.registrujStudenta("16555", s5);

            // Popunjavanje instance fakulteta sa podacima o profesorima preko kreirane metode
            Profesor p1 = new Profesor("Dženana", "Đonko", 20); f.registrujProfesora("Redovni profesor", "1111111111111", p1);
            Profesor p2 = new Profesor("Emir", "Buza", 21); f.registrujProfesora("Docent", "2222222222222", p2);
            Profesor p3 = new Profesor("Samir", "Ribić", 22); f.registrujProfesora("Vanredni profesor", "3333333333333", p3);
            Profesor p4 = new Profesor("Novica", "Nosović", 22); f.registrujProfesora("Docent", "444444444444", p4);
            Profesor p5 = new Profesor("Fahrudin", "Oručević", 23); f.registrujProfesora("Redovni profesor", "5555555555555", p5);

            // Popunjavanje klase sa podacima o predmetima preko kreirane metode
            Predmet pr1 = new Predmet("Razvoj programskih rješenja", 15); f.registrujPredmet(pr1);
            Predmet pr2 = new Predmet("Osnove baza podataka", 15); f.registrujPredmet(pr2);
            Predmet pr3 = new Predmet("Logički dizajn", 20); f.registrujPredmet(pr3);
            Predmet pr4 = new Predmet("Sistemsko programiranje", 20); f.registrujPredmet(pr4);
            Predmet pr5 = new Predmet("Vještačka inteligencija", 25); f.registrujPredmet(pr5);

            // Pretrazi studente po broju indeksa
            Console.WriteLine(f.pretraziStudentePoIndeksu("16222"));

            // Pretrazi broj profesora po tituli
            Console.WriteLine("Broj redovnih profesora: " + Convert.ToString(f.prebrojProfesore("Redovni profesor")));
            Console.WriteLine("Broj vanrednih profesora: " + Convert.ToString(f.prebrojProfesore("Vanredni profesor")));
            Console.WriteLine("Broj docenta: " + Convert.ToString(f.prebrojProfesore("Docent")));

            // Ispiši sve predmete sa 20 ECTS bodova, očekivani rezultat je LD i SP
            List<Predmet> rez = f.dajPredmeteNaOsnovuECTS(20);
            foreach (Predmet p in rez)
                Console.WriteLine(p.Naziv + " " + p.BrojECTS);

            Console.ReadLine();
        }
    }
}
