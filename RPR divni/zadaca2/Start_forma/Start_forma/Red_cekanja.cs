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
    public partial class Red_cekanja : Form
    {
        public Red_cekanja(string un = "")
        {
            InitializeComponent();


            foreach (Pacijent i in Klinika.svi_pacijenti)
            {
                if (i.User_name == un)
                {
                    int brojac = 0;
                    foreach (Pregled k in i.Raspored_pregleda)
                    {
                        if (k.Ime_ordinacije == "Ortopedija")
                        {
                            checkBox1.Checked = true;
                            textBox1.Text = Convert.ToString(i.Redni_brojevi_cekanja[brojac]);
                        }
                        else if (k.Ime_ordinacije == "Kardiologija")
                        {
                            checkBox2.Checked = true;
                            textBox2.Text = Convert.ToString(i.Redni_brojevi_cekanja[brojac]);
                        }
                        else if (k.Ime_ordinacije == "Dermatologija")
                        {
                            checkBox3.Checked = true;
                            textBox3.Text = Convert.ToString(i.Redni_brojevi_cekanja[brojac]);
                        }
                        else if (k.Ime_ordinacije == "Oftalmologija")
                        {
                            checkBox4.Checked = true;
                            textBox4.Text = Convert.ToString(i.Redni_brojevi_cekanja[brojac]);
                        }
                        else if (k.Ime_ordinacije == "Laboratorija")
                        {
                            checkBox5.Checked = true;
                            textBox5.Text = Convert.ToString(i.Redni_brojevi_cekanja[brojac]);
                        }
                        brojac++;
                    }


                }
            }
        }
    }
}
