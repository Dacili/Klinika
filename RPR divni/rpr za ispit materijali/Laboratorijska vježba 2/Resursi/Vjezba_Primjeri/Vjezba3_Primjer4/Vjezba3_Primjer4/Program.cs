using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vjezba3_Primjer4
{
    class Program
    {
        static void Main(string[] args)
        {
            Form forma = new Form();
            forma.BackColor = Color.White;
            forma.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            forma.Icon = new Icon("D:\\Documents\\Projects\\Visual Studio 2012\\Vjezba3_Primjer4\\Vjezba3_Primjer4\\ViewIcon.ico");
            forma.MaximizeBox = false;
            forma.MinimizeBox = false;
            forma.Size = new Size(320, 240);
            forma.StartPosition = FormStartPosition.CenterScreen;
            forma.Text = "Moja prva forma";
            TextBox okvirTeksta = new TextBox();
            okvirTeksta.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            okvirTeksta.Location = new Point(40, 60);
            okvirTeksta.Size = new Size(150, 25);
            okvirTeksta.Text = "Moj prvi okvir teksta";
            forma.Controls.Add(okvirTeksta);
            Button dugme = new Button();
            dugme.BackColor = Color.LightGray;
            dugme.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            dugme.Location = new Point(160, 100);
            dugme.Size = new Size(100, 25);
            dugme.Text = "Moje prvo dugme";
            // Kreiranje događaja klika na dugme
            dugme.Click += new EventHandler(klikNaDugme);
            forma.Controls.Add(dugme);
            Application.Run(forma);
        }

        // Definiranje događaja klika na dugme
        static void klikNaDugme(object sender, EventArgs e)
        {
            MessageBox.Show("Čestitam! Kreirao si svoj prvi događaj.", "Moj prvi događaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
