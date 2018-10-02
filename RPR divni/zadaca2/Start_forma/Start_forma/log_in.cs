using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Start_forma
{
    public partial class log_in : Form
    {
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }

            return hash.ToString();
        }


        public log_in()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "";
            errorProvider1.BlinkRate = 1000;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled)) 
                //bez ovoga ispise na error stripu gresku samo kad kliknemo na polja un i pw, a ovako odmah ispise
             {
            bool nasao = false;
            
            
                if (radioButtonDoktor.Checked)
                {
                    foreach (Doktor i in Klinika.svi_doktori)
                    {
                    //if (i.User_name == textBox1.Text && i.Sifra == textBox2.Text)
                    if (i.User_name == textBox1.Text && i.Sifra == MD5Hash(textBox2.Text))
                        
                    {
                            KLINIKA_DOKTOR nova = new KLINIKA_DOKTOR();
                            nova.Show();
                            Visible = false;
                        nasao = true;
                        }
                    }
                    if(!nasao)
                {
                    toolStripStatusLabel1.ForeColor = Color.Red;
                    toolStripStatusLabel1.Text = "Nije pronađen doktor sa unesenim podacima";
                }


                }
                else if (radioButtonOsoblje.Checked)
                {
                    foreach (Osoblje i in Klinika.svo_osoblje)
                    {
                        if (i.User_name == textBox1.Text && i.Sifra == MD5Hash(textBox2.Text))
                        {

                            KLINIKA_OSOBLJE nova = new KLINIKA_OSOBLJE();
                            nova.Show();
                            Visible = false;

                        }
                    }
                }
                else if (radioButtonOsoblje.Checked = false && radioButtonDoktor.Checked == false)
                {
                    toolStripStatusLabel1.ForeColor = Color.Red;
                    toolStripStatusLabel1.Text = "Odaberite zanimanje, doktor ili osoblje!";
                }
                else
                {
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Text = "Neispravni podaci";
                }
            }
       }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                //e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Polje ne smije biti prazno!");
            }
            else
            {
                //e.Cancel = true;
                errorProvider1.SetError(textBox1, null);
            }
            if (textBox2.Text == "")
            {
                //e.Cancel = true;
                textBox2.Focus();
                errorProvider1.SetError(textBox2, "Polje ne smije biti prazno!");
            }
          /*  else
            {
                //e.Cancel = true;
                errorProvider1.SetError(textBox2, null);
            }*/
        }

       
    }
}
