using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography; //za ovu fju md5Hash sto smo napravili

namespace Start_forma
{
    public partial class PACIJENT_F : Form
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

        public PACIJENT_F()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (ValidateChildren(ValidationConstraints.Enabled))
            //{
                bool nasao = false;
                try
                {
                    label4.Text = "";
                    foreach (Pacijent i in Klinika.svi_pacijenti)
                    {
                        if (textBox1.Text == i.User_name && MD5Hash(textBox2.Text) == i.Sifra)
                        {
                            PACIJENT_2 nova = new PACIJENT_2(i.User_name);
                            nova.Show();
                            Visible = false;
                            nasao = true;
                        }


                    }
                    if (nasao == false)
                    {
                        label4.ForeColor = Color.Red;
                        label4.Text = Convert.ToString("Neispravni podaci");
                    }
                }
                catch (Exception err)
                {
                    label4.ForeColor = Color.Red;
                    label4.Text = Convert.ToString(err);
                }


            }
       // }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
               // e.Cancel = true;
                textBox2.Focus();
                errorProvider1.SetError(textBox2, "Polje ne smije biti prazno!");
            }
            else
            {
                //e.Cancel = true;
                errorProvider1.SetError(textBox2, null);
            }
        }
    }
    
}
