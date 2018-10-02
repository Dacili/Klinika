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
    public partial class KLINIKA_DOKTOR : Form
    {
        public KLINIKA_DOKTOR()
        {
            InitializeComponent();
            label8.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            }
            if (comboBox1.SelectedIndex == 1)
            {
                Graf nova = new Graf();
                nova.Show();
            }
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

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Pacijent i in Klinika.svi_pacijenti)
            {
                if (textBox2.Text == i.User_name || textBox2.Text == i.Ime + " " + i.Prezime)
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


                    Kreiraj_karton nova = new Kreiraj_karton(i.User_name, i.Dodatne_info, i.Alergo, i.Trenutne_bolesti, i.Prijasnje_bolesti, i.Terapija, c1, c2, c3, c4, c5, true, true, false);
                    nova.Show();

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        { label8.Text = "";
            try {
                bool uspio = false, nije_c=true;
                foreach (Pacijent i in Klinika.svi_pacijenti)
                {

                    if (textBox1.Text == i.User_name || textBox1.Text == i.Ime + " " + i.Prezime)
                    {
                        nije_c = false;

                        if (radioButton1.Checked == true)
                        {
                            i.DodajZavrsenPregled(radioButton1.Text); uspio = true;
                        }
                        else if (radioButton2.Checked == true)
                        {
                            i.DodajZavrsenPregled(radioButton2.Text); uspio = true;
                        }
                        else if (radioButton3.Checked==true)
                        {
                            i.DodajZavrsenPregled(radioButton3.Text); uspio = true;
                        }
                        else if (radioButton4.Checked==true)
                        {
                            i.DodajZavrsenPregled(radioButton4.Text); uspio = true;
                        }
                        else if (radioButton5.Checked==true)
                        {
                            i.DodajZavrsenPregled(radioButton5.Text); uspio = true;
                        }
                        else
                        {
                            label8.ForeColor = Color.Red;
                            label8.Text = "Morate selektovati završen pregled!";
                        }
                        if (uspio) MessageBox.Show("Uspješno dodan završen pregled!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                if(nije_c) 
                {
                    label8.ForeColor = Color.Red;
                    label8.Text = "Nije pronađen pacijent sa unesenim podacima!";
                   // label8.Text = "Morate selektovati završen pregled!";

                }
            }
            catch(Exception err)
            {
                label8.ForeColor = Color.Red;
                label8.Text = Convert.ToString(err);
            }
            }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
                treeView1.BeginUpdate();
                treeView1.Nodes.Add("Parent");
                treeView1.Nodes[0].Nodes.Add("Child 1");
                treeView1.Nodes[0].Nodes.Add("Child 2");
                treeView1.Nodes[0].Nodes[1].Nodes.Add("Grandchild");
                treeView1.Nodes[0].Nodes[1].Nodes[0].Nodes.Add("Great Grandchild");
                treeView1.EndUpdate();
            
        }
    }
}
