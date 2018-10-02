using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Start_forma
{
    public partial class PACIJENT_2 : Form
    {
        public void fja(string s)
        {
            label2.Text = s;
        }

        public PACIJENT_2(string s = "")
        {
            InitializeComponent();
            fja(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PACIJENT_2_Load(object sender, EventArgs e)
        {

        }

        private void buttoninfo_Click(object sender, EventArgs e)
        {
            foreach (Pacijent k in Klinika.svi_pacijenti)
            {

                if (k.User_name == label2.Text)
                {
                    DODAJPACIJENTA nova = new DODAJPACIJENTA(k.Ime, k.Prezime, k.Datum_rodjenja, k.Jmbg, k.Da_li_je_vjencan, k.Datum_prijema, k.Adresa_stanovanja, k.Slika, false, false);

                    nova.Show();
                    //Spasi.Locked = true;

                }
            }



        }

        private void buttonkarton_Click(object sender, EventArgs e)
        {
            foreach (Pacijent i in Klinika.svi_pacijenti)
            {
                if (label2.Text == i.User_name)
                {
                    bool c1 = false, c2 = false, c3 = false, c4 = false, c5 = false;
                    foreach (Pregled k in i.Raspored_pregleda)
                    {
                        if (k.Ime_ordinacije == "Ortopedija") c1 = true;
                        else if (k.Ime_ordinacije == "Kardiologija") c2 = true;
                        else if (k.Ime_ordinacije == "Dermatologija") c3 = true;
                        else if (k.Ime_ordinacije == "Oftalmologija") c4 = true;
                        else if (k.Ime_ordinacije == "Laboratorija") c5 = true;


                    }


                    Kreiraj_karton nova = new Kreiraj_karton(i.User_name, i.Dodatne_info, i.Alergo, i.Trenutne_bolesti, i.Prijasnje_bolesti, i.Terapija, c1, c2, c3, c4, c5, false, false);
                    nova.Show();

                }
            }

        }

        private void buttonred_Click(object sender, EventArgs e)
        {
            foreach (Pacijent i in Klinika.svi_pacijenti)
            {
                if (label2.Text == i.User_name)
                {
                    Red_cekanja nova = new Red_cekanja(i.User_name);
                    nova.Show();
                    /*
                    bool c1 = false, c2 = false, c3 = false, c4 = false, c5 = false;
                    foreach (Pregled k in i.Raspored_pregleda)
                    {
                        if (k.Ime_ordinacije == "Ortopedija") c1 = true;
                        else if (k.Ime_ordinacije == "Kardiologija") c2 = true;
                        else if (k.Ime_ordinacije == "Dermatologija") c3 = true;
                        else if (k.Ime_ordinacije == "Oftalmologija") c4 = true;
                        else if (k.Ime_ordinacije == "Laboratorija") c5 = true;

    */
                }

            }
        }
    }
}
