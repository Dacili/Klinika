using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;



namespace MegaIzmisljaGui
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
            forma.Size = new Size(400, 440);
            forma.MaximumSize = forma.Size;
            forma.MinimumSize = forma.Size;
            forma.BackColor = Color.PeachPuff;
            forma.MaximizeBox = false;
            //forma.Icon = Properties.Resources.Digitron;
            forma.Text = "Digitron";
            forma.Padding = new Padding(10, 10, 10, 10);

            okvirTeksta = new TextBox();
            okvirTeksta.Size = new Size(250, 25);
            okvirTeksta.ReadOnly = true;
            okvirTeksta.TextAlign = HorizontalAlignment.Right;
            okvirTeksta.Location = new Point(10, 10);
            forma.Controls.Add(okvirTeksta);

            Label ime_polja = new Label();
            ime_polja.Text = "medi haker";

            ime_polja.Size = new Size(195, 25);
            ime_polja.Location = new Point(10, 25);



            int k=1, j=1;
            dugmad = new Button[BROJ_DUGMADI];
            List<Button> dugmici = new List<Button>();
            for(int i=0; i<4; i++)
            {
                Button novi = new Button();
                novi.Text = "mediii";
                novi.Size = new Size(20, 20);
                novi.BackColor = Color.Black;
                novi.Location = new Point(10 + k, 10 + j);
                k *= 10; j *= 10;
                dugmici.Add(novi);
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
