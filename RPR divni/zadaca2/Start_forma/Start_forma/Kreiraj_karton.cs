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
    public partial class Kreiraj_karton : Form
    {
        public void fja(string un="", string dod="", string al="", string tr = "", string pr = "", string terapija = "", bool c1=false, bool c2=false, bool c3=false, bool c4=false, bool c5=false, bool ok=true, bool ponisti=true, bool terapijaa = false)
        {
            textBoxun.Text = un;
            textBox1.Text = dod;
            textBox2.Text = al;
            textBox3.Text = tr;
            textBox4.Text = pr;
            textBox5.Text = terapija;
            checkBox1.Checked = c1;
            checkBox2.Checked = c2;
            checkBox3.Checked = c3;
            checkBox4.Checked = c4;
            checkBox5.Checked = c5;
            buttonOK.Enabled = ok;
            buttonPonisti.Enabled=ponisti;
            textBox5.ReadOnly = terapijaa;
        }


        public Kreiraj_karton(string un = "", string dod = "", string al = "", string tr = "", string pr = "", string terapija = "", bool c1 = false, bool c2 = false, bool c3 = false, bool c4 = false, bool c5 = false, bool ok=true, bool ponisti=true, bool terapijaa=true)
        {

            InitializeComponent();
            fja(un, dod, al, tr, pr, terapija, c1, c2, c3, c4, c5, ok, ponisti, terapijaa);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool imao_prije_karton = false;
            foreach(Pacijent i in Klinika.svi_pacijenti)
            {
               // try
                //{

                    if (i.User_name == textBoxun.Text)
                    {
                        i.Dodatne_info = textBox1.Text;
                        i.Alergo = textBox2.Text;
                        i.Trenutne_bolesti = textBox3.Text;
                        i.Prijasnje_bolesti = textBox4.Text;
                    if (i.Kreiran_karton) imao_prije_karton = true;
                    i.Kreiran_karton = true;

                        if (checkBox1.Checked) i.DodajPregledZaObaviti(checkBox1.Text);
                        if (checkBox2.Checked) i.DodajPregledZaObaviti(checkBox2.Text);
                        if (checkBox3.Checked) i.DodajPregledZaObaviti(checkBox3.Text);
                        if (checkBox4.Checked) i.DodajPregledZaObaviti(checkBox4.Text);
                        if (checkBox5.Checked) i.DodajPregledZaObaviti(checkBox5.Text);
                        
                        if(!imao_prije_karton)
                        MessageBox.Show("Karton je uspješno kreiran!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if(imao_prije_karton)
                        MessageBox.Show("Karton je uspješno ažuriran!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Visible = false;
                    }
                //}
                /*
                catch (Exception greskica) 
                {
                    labelStatusStrip2.ForeColor = Color.Red;
                    labelStatusStrip2.Text = Convert.ToString(greskica);
                }*/
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonPonisti_Click(object sender, EventArgs e)
        {
            Nuliraj();
        }

        private void Nuliraj ()
        {
            textBoxun.Text = "";
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
            checkBox1.Checked = checkBox2.Checked = checkBox3.Checked = checkBox4.Checked= checkBox5.Checked = false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (Pacijent i in Klinika.svi_pacijenti)
            {
                if (i.User_name == textBoxun.Text)
                {
                    textBox1.ReadOnly = textBox2.ReadOnly = textBox3.ReadOnly = textBox4.ReadOnly = false;
                    labelStatusStrip2.ForeColor = Color.Green;
                    labelStatusStrip2.Text = "Pacijent je pronađen!";
                }
                else
                {
                    labelStatusStrip2.ForeColor = Color.Red;
                    labelStatusStrip2.Text = "Pacijent nije pronađen!";
                }

            }
        }
    }
}
