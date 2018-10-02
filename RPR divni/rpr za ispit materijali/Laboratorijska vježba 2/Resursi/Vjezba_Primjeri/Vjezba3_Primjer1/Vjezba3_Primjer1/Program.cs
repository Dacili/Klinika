using System;
using System.Collections.Generic;
// Dodavanje System.Drawing direktive
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Dodavanje System.Widnows.Forms direktive
using System.Windows.Forms;

namespace Vjezba3_Primjer1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kreiranje forme
            Form forma = new Form();
            // Promjena boje pozadine forme
            forma.BackColor = Color.White;
            // Promjena fonta forme
            forma.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            // Promjena ikone forme
            forma.Icon = new Icon("D:\\Documents\\Projects\\Visual Studio 2012\\Vjezba3_Primjer1\\Vjezba3_Primjer1\\ViewIcon.ico");
            // Promjena mogućnosti povećavanja forme sa dugmetom "Maximize"
            forma.MaximizeBox = false;
            // Promjena mogućnosti smanjenja forme sa dugmetom "Minimize"
            forma.MinimizeBox = false;
            // Promjena veličine forme
            forma.Size = new Size(320, 240);
            // Promjena početne pozicije forme
            forma.StartPosition = FormStartPosition.CenterScreen;
            // Promjena teksta forme
            forma.Text = "Moja prva forma";
            // Pokretanje forme
            Application.Run(forma);
        }
    }
}
