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
     partial class DODAJPACIJENTA : Form
    {

       public void Moja_Fja(string s1="", string s2="", string dat1 = "", string s3 = "", bool vjencan=true, string dat2 = "", string s4 = "",  Image slika=null, bool spasi = true, bool ponisti = true)
        {
            textBoxIme.Text = s1;
            textBoxPrezime.Text = s2;
            dateTimePicker1.Text = dat1;
            textBoxJMBG.Text = s3;
            
            if (vjencan) radioButtonDa.Checked = true;
            else radioButtonNe.Checked = true;
            dateTimePicker2.Text = dat2;
            textBoxAdresa.Text = s4;
            pictureBoxSlika.Image = slika;
            buttonSpasi.Enabled = spasi;
            buttonPonisti.Enabled = ponisti;

        }
        
        public DODAJPACIJENTA(string s1 = "", string s2 = "", string dat1 = "", string s3 = "",   bool vjencan = true, string dat2 = "", string s4 = "",  Image slika = null, bool spasi=true, bool ponisti=true)
        {
            InitializeComponent();
            Moja_Fja(s1 ,s2,  dat1,s3 ,  vjencan ,  dat2 ,s4,slika, spasi, ponisti);
        }

        private void textBoxIme_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBoxIme.Text == "") errorProvider1.SetError(textBoxIme, "Polje ne smije biti prazno");
        }
        private void textBoxIme_Validate(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBoxIme.Text == "") errorProvider1.SetError(textBoxIme, "");
        }


        private void button1_Click(object sender, EventArgs e)
        {
          
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.Title = "Pronađite sliku";
                    dlg.Filter = "jpg files (*.jpg)|*.jpg";
                    ;


                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        pictureBoxSlika.Image = new Bitmap(dlg.FileName);
                    }
                }
            
        }

        private void buttonSpasi_Click(object sender, EventArgs e)
        {
          try {
                
                bool s=true;
            if (radioButtonDa.Checked) s = true;
            else if (radioButtonNe.Checked) s = false;
                if (textBoxIme.Text == "" || textBoxPrezime.Text == "" || textBoxJMBG.Text=="" || textBoxAdresa.Text == "") throw new Exception("Sva polja moraju biti popunjena!");
                if (pictureBoxSlika.Image == null) throw new Exception("Niste učitali sliku!");
            Klinika.DodajPacijenta(new Pacijent(textBoxIme.Text, textBoxPrezime.Text, dateTimePicker1.Text, textBoxJMBG.Text, textBoxAdresa.Text,s , dateTimePicker2.Text, pictureBoxSlika.Image));
                MessageBox.Show("Pacijent uspješno unesen!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                NulirajStanje();
                Close();
              }

           
           catch(Exception err)
            {
                labelStatusStrip.ForeColor =Color.Red ;
                  labelStatusStrip.Text =err.Message;
              //  labelStatusStrip.Text = Convert.ToString(textBoxJMBG.Text);
            }
        }

        private void NulirajStanje()
        {
            textBoxIme.Text= textBoxPrezime.Text=  textBoxAdresa.Text = "";
            textBoxJMBG.Text = "";
            dateTimePicker1 = new DateTimePicker(); //mere ovdje i .value= new DateTime
            dateTimePicker2 = new DateTimePicker(); 
            pictureBoxSlika.Image = null;
            labelStatusStrip.Text = "";
        }

        private void buttonPonisti_Click(object sender, EventArgs e)
        {
            NulirajStanje();
        }
    }
}
