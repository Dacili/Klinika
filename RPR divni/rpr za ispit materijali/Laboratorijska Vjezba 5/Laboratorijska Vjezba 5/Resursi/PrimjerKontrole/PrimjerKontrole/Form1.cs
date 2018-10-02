using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimjerKontrole
{
    public partial class Form1 : Form
    {
        List<Korisnik> korisnici;
        public Form1()
        {
            korisnici = new List<Korisnik>();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
            Boolean musko = true;

            if (radioButtonMusko.Checked)
                musko = true;
            else
                musko = false;
             
            Korisnik k = new Korisnik(textBoxIme.Text, textBoxPrezime.Text, musko, Convert.ToString(comboBoxGrad.SelectedItem), maskedTextBoxTelefon.Text, dateTimePickerRodjenje.Value, textBoxUsername.Text, textBoxPass.Text, pictureBoxSlika.Image, checkBoxAdmin.Checked, checkBoxModerator.Checked);

            if(!richTextBoxClanstvo.Text.Equals(""))
                k.Clanstvo = new List<String>(richTextBoxClanstvo.Text.Split(',')); 

            korisnici.Add(k);

            MessageBox.Show("Uspješno unesen korisnik.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            pocistiInformacijeOUnosu();
        }

        private void buttonUcitajSliku_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "jpg files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxSlika.Image = new Bitmap(dlg.FileName);
                }
            }
        }

        private void textBoxImePretraga_TextChanged(object sender, EventArgs e)
        {
            listBoxPretraga.Items.Clear();

            foreach(Korisnik k in korisnici)
            {
                if ((k.Ime + " " + k.Prezime).Contains(textBoxImePretraga.Text))
                {
                    listBoxPretraga.Items.Add(k);
                }
            }
        }

        public void pocistiInformacijeOUnosu()
        {
            textBoxIme.Text = "";
            textBoxPrezime.Text = "";
            radioButtonMusko.Checked = false;
            radioButtonZensko.Checked = false;
            comboBoxGrad.SelectedIndex = -1;
            maskedTextBoxTelefon.Text = "";
            dateTimePickerRodjenje.Value = DateTime.Now;
            textBoxUsername.Text = "";
            textBoxPass.Text = "";
            pictureBoxSlika.Image = null;
            checkBoxAdmin.Checked = false;
            richTextBoxClanstvo.Text = "";
        }

        private void buttonPonisti_Click(object sender, EventArgs e)
        {
            pocistiInformacijeOUnosu();
        }

        private void linkLabelStranica_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Dodatne informacije.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxClanstvo_TextChanged(object sender, EventArgs e)
        {
            var rezultati = korisnici.Where(item => item.Clanstvo.Contains(textBoxClanstvo.Text));
            listBoxClanstvo.DataSource = rezultati.ToList();
        }
    }
}
