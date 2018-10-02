using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vjezba3_Primjer2
{
    class Program
    {
        static void Main(string[] args)
        {
            Form forma = new Form();
            forma.BackColor = Color.White;
            forma.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            forma.Icon = new Icon("D:\\Documents\\Projects\\Visual Studio 2012\\Vjezba3_Primjer2\\Vjezba3_Primjer2\\ViewIcon.ico");
            forma.MaximizeBox = false;
            forma.MinimizeBox = false;
            forma.Size = new Size(320, 240);
            forma.StartPosition = FormStartPosition.CenterScreen;
            forma.Text = "Moja prva forma";
            // Kreiranje okvira teksta
            TextBox okvirTeksta = new TextBox();
            // Promjena fonta okvira teksta
            okvirTeksta.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            // Promjena lokacije okvira teksta
            okvirTeksta.Location = new Point(40, 60);
            // Promjena veličine okvira teksta
            okvirTeksta.Size = new Size(150, 25);
            // Promjena teksta okvira teksta
            okvirTeksta.Text = "Moj prvi okvir teksta";
            // Dodavanje okvira teksta na formu
            forma.Controls.Add(okvirTeksta);
            Application.Run(forma);
        }
    }
}
