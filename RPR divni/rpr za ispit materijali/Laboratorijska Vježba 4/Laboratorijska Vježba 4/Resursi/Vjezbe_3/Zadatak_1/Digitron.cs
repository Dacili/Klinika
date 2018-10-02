using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Zadatak_1
{
    public class Digitron
    {
        private const int BROJ_DUGMADI = 15;
        private readonly string[] ZNAKOVI_DUGMADI = { "1", "2", "3", "+", "4", "5", "6", "-", "7", "8", "9", "*", "0", "=", "/" };
        private Form forma;
        private TextBox okvirTeksta;
        private Button[] dugmad;

        public Digitron()
        {
            forma = new Form();
            forma.StartPosition = FormStartPosition.CenterScreen;
            forma.Size = new Size(285, 340);
            forma.MaximumSize = forma.Size;
            forma.MinimumSize = forma.Size;
            forma.MaximizeBox = false;
            forma.Icon = Properties.Resources.Digitron;
            forma.Text = "Digitron";
            forma.Padding = new Padding(10, 10, 10, 10);

            okvirTeksta = new TextBox();
            okvirTeksta.Size = new Size(250, 25);
            okvirTeksta.ReadOnly = true;
            okvirTeksta.TextAlign = HorizontalAlignment.Right;
            okvirTeksta.Location = new Point(10, 10);
            forma.Controls.Add(okvirTeksta);

            dugmad = new Button[BROJ_DUGMADI];
            int red = 0, kolona = 0;
            for (int i = 0; i < BROJ_DUGMADI; i++)
            {
                dugmad[i] = new Button();
                dugmad[i].Size = new Size(50, 50);
                if (i == 13)
                {
                    dugmad[i].Size = new Size(110, 50);
                }
                dugmad[i].Text = ZNAKOVI_DUGMADI[i];
                dugmad[i].Location = new Point(20 + kolona * 60, 50 + red * 60);
                if (i == 14)
                {
                    dugmad[i].Location = new Point(20 + (kolona + 1) * 60, 50 + red * 60);
                }
                dugmad[i].Click += new EventHandler(klikNaDugme);
                forma.Controls.Add(dugmad[i]);
                kolona++;
                if ((i + 1) % 4 == 0)
                {
                    red++;
                    kolona = 0;
                }
            }
            Application.Run(forma);
        }

        private void klikNaDugme(object sender, EventArgs e)
        {
            Button dugme = sender as Button;
            okvirTeksta.Text += dugme.Text;
            if (dugme.Text == "=")
            {
                string[] brojevi = okvirTeksta.Text.Split(new char[] { '+', '-', '*', '/', '=' });
                int prviBroj, drugiBroj;
                if (brojevi.Length != 3 || !validirajCijeliBroj(brojevi[0], out prviBroj) || !validirajCijeliBroj(brojevi[1], out drugiBroj) || (!okvirTeksta.Text.Contains("+") && !okvirTeksta.Text.Contains("-") && !okvirTeksta.Text.Contains("*") && !okvirTeksta.Text.Contains("/")))
                {
                    okvirTeksta.Text = "";
                    MessageBox.Show("Ulaz nije ispravan.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (okvirTeksta.Text.Contains("+"))
                {
                    okvirTeksta.Text = Convert.ToString(prviBroj + drugiBroj);
                }
                else if (okvirTeksta.Text.Contains("-"))
                {
                    okvirTeksta.Text = Convert.ToString(prviBroj - drugiBroj);
                }
                else if (okvirTeksta.Text.Contains("*"))
                {
                    okvirTeksta.Text = Convert.ToString(prviBroj * drugiBroj);
                }
                else
                {
                    if (prviBroj % drugiBroj != 0)
                    {
                        okvirTeksta.Text = "0";
                        MessageBox.Show("Rezultat nije cijeli broj.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    okvirTeksta.Text = Convert.ToString(prviBroj / drugiBroj);
                }
            }
        }

        private bool validirajCijeliBroj(string unos, out int cijeliBroj)
        {
            if (!Int32.TryParse(unos, out cijeliBroj))
            {
                MessageBox.Show("Operant mora biti cijeli broj.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
