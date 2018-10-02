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
    public partial class KLINIKA_OSOBLJE : Form
    {
        public KLINIKA_OSOBLJE()
        {
            InitializeComponent();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DODAJPACIJENTA nova = new DODAJPACIJENTA();
            nova.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BUTTONIZBRISI_Click(object sender, EventArgs e)
        {

            //Klinika.NadjiPacijenta()
        }

        private void KLINIKA_OSOBLJE_Load(object sender, EventArgs e)
        {

        }

        private void BUTTONPREGLED_REDOVA_CEKANJA_Click(object sender, EventArgs e)
        {

        }

        private void BUTTONANALIZA_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                bool tmp = true;
                Pacijent novi = Klinika.NadjiPacijenta(textBoxID.Text, ref tmp);
                if (tmp)
                {
                    Klinika.svi_pacijenti.Remove(novi);
                    MessageBox.Show("Pacijent uspješno obrisan!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Neispravni podaci", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


       

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            if (comboBox1.SelectedIndex == 0)
            {

                foreach (Pacijent i in Klinika.svi_pacijenti)
                {
                    richTextBox1.Text += i.Ispisi();
                    richTextBox1.Text += "\n";
                }

                //Klinika.IspisiSvePacijente();
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                Graf nova = new Graf();
                nova.Show();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            /*
                foreach (Pacijent k in Klinika.svi_pacijenti)
                {
                    if ((k.Ime + " " + k.Prezime).Contains(textBox1.Text) || k.Pacijent_id.Contains(textBox1.Text))
                    {
                        listBox1.Items.Add(k.Ime + " "+k.Prezime);
                    }*/

            foreach (Pacijent k in Klinika.svi_pacijenti)
            {
                listBox1.Items.Clear();
                if ((k.Ime + " " + k.Prezime).Contains(textBox1.Text) || k.User_name.Contains(textBox1.Text))
                {
                    //listBox1.Items.Add(k.Ispisi());
                    listBox1.Items.Add(k.Ime + " " + k.Prezime);
                    listBox1.Items.Add("Šifra: " + k.Sifra);
                    listBox1.Items.Add("Korisničko ime:\n" + k.User_name);

                }
            }
        }



        private void tabControlOsoblje_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


            foreach (Pacijent k in Klinika.svi_pacijenti)
            {
                if (k.Ime + " " + k.Prezime == textBox1.Text || k.User_name == textBox1.Text)
                {

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool nasao = false;
            listBox2.Items.Clear();

            Klinika.NadjiOrdinaciju(comboBox2.Text, ref nasao);
            if (nasao == true)
            {
                listBox2.Items.Clear();
                listBox2.Items.Add(Convert.ToString((Klinika.NadjiOrdinaciju(comboBox2.Text, ref nasao)).KolikoCekaPacijenata()));

            }




        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Kreiraj_karton nova = new Kreiraj_karton();
            nova.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (Pacijent i in Klinika.svi_pacijenti)
            {
                if (textBox2.Text == i.User_name || textBox2.Text== i.Ime+ " " + i.Prezime)
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


                    Kreiraj_karton nova = new Kreiraj_karton(i.User_name, i.Dodatne_info, i.Alergo, i.Trenutne_bolesti, i.Prijasnje_bolesti, i.Terapija, c1, c2, c3, c4, c5, true, true);
                    nova.Show();

                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
