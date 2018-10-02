using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vjezba3_Primjer3
{
    class Program
    {
        static void Main(string[] args)
        {
            Form forma = new Form();
            forma.BackColor = Color.White;
            forma.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            forma.Icon = new Icon("D:\\Documents\\Projects\\Visual Studio 2012\\Vjezba3_Primjer3\\Vjezba3_Primjer3\\ViewIcon.ico");
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
            // Kreiranje dugmeta
            Button dugme = new Button();
            // Promjena boje pozadine dugmeta
            dugme.BackColor = Color.LightGray;
            // Promjena fonta dugmeta
            dugme.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            // Promjena lokacije dugmeta
            dugme.Location = new Point(160, 100);
            // Promjena veličine dugmeta
            dugme.Size = new Size(100, 25);
            // Promjena teksta dugmeta
            dugme.Text = "Moje prvo dugme";
            // Dodavanje dugmeta na formu
            forma.Controls.Add(dugme);
            Application.Run(forma);
        }
    }
}
