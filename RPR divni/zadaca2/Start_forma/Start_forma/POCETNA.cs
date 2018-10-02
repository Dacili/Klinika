using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace Start_forma
{
    partial class POCETNA : Form
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






        public POCETNA()
        {

            InitializeComponent();
            
            Klinika.DodajDoktora("Medi", "Doktorica", "12/24/1990", "2412990111000", "Nadira K. br 4", true, "Hiurgija", true, false);
            Klinika.DodajDoktora("Doktor", "Doktorcic", "12/24/1992", "2412992777777", "Nadira K. br 4", true, "Dermatologija", true, false);
            Klinika.DodajDoktora("Mladi", "Doktor", "12/24/1994", "2412994555555", "Nadira K. br 4", false, "Ortopedija", true, false);
            Klinika.DodajDoktora("Crazy", "Doktorica", "12/25/1992", "2512992777777", "Nadira K. br 4", false, "Laboratorija", true, false);

            Klinika.DodajOrdinaciju("Ortopedija", true, 0);
            Klinika.DodajOrdinaciju("Kardiologija", true, 0);
            Klinika.DodajOrdinaciju("Oftalmologija", true, 0);
            Klinika.DodajOrdinaciju("Laboratorija", true, 0);
            Klinika.DodajOrdinaciju("Dermatologija", true, 0);
            Klinika.DodajOsoblje("Fina", "Teta", "06/06/1980", "0606980999999", "Nebitno", false);
            Klinika.DodajPacijenta("mali", "decak", "12/24/2009", "2412009000999", "bb", false);
            Klinika.DodajPacijenta("Medi", "Daci", "12/24/2009", "2412009088888", "bb", false);

        }



       
    


    private void button2_Click(object sender, EventArgs e)
        {
            PACIJENT_F nova = new PACIJENT_F();
            nova.Show();
           // Visible = false;

        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log_in NOVA = new log_in();
            NOVA.Show();
            //Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PACIJENT_F nova = new PACIJENT_F();
            nova.Show();
        }

        private void medicinskiRadnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            log_in NOVA = new log_in();
            NOVA.Show();
        }

        private void informacijeOAplikacijiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program je namijenjen za medicinske klinike ", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void iToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ova aplikacija je kreirana od strane Medine Dacić Hakerke. \nZa sve informacije možete je kontaktirati na email neki_lijevi@mail.com.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void kakoKoristitiAplikacijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Za pacijenta možete koristiti:\n username: user_7\npw: p.ae_7\n\nZa doktora:\nun:user_2\npw:d.oo_2\n\nZa osoblje:\nun:user_5\npw:o.ei_5", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void izlazToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void medicinskiRadnikToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            log_in NOVA = new log_in();
            NOVA.Show();
        }

        private void izlazToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PACIJENT_F nova = new PACIJENT_F();
            nova.Show();
        }

        private void POCETNA_Paint_1(object sender, PaintEventArgs e)
        {
           
                Pen mojPen = new Pen(Color.Black, 2);
                Rectangle r = new Rectangle(50, 50, 20, 20);

                Rectangle rl1 = new Rectangle(10, 50, 20, 20);
            Rectangle rl2 = new Rectangle(90, 50, 20, 20);
            
            //Rectangle rl2 = new Rectangle(150, 287, 200, 200);

            //Rectangle rl3 = new Rectangle(150, 113, 200, 200);
            //Rectangle rl4 = new Rectangle(250, 287, 200, 200);

            //Rectangle rl5 = new Rectangle(100, 200, 200, 200);
            //Rectangle rl6 = new Rectangle(300, 200, 200, 200);
            Graphics g = e.Graphics;

            
            g.DrawString("Mala Klinika",
                new Font("Mistral", 12), System.Drawing.Brushes.Red, new Point(25, 30));
            // Draw a line in the PictureBox.
            //g.DrawLine(System.Drawing.Pens.Red, pictureBox1.Left, pictureBox1.Top,
              //  pictureBox1.Right, pictureBox1.Bottom);


            e.Graphics.DrawEllipse(new Pen(Color.Pink, 10), r);
            g.DrawLine(new Pen(Color.Red, 10), 10, 45, 50, 50);
            g.DrawLine(new Pen(Color.Red, 10), 80, 50, 120, 40);
            g.DrawLine(new Pen(Color.Red, 10), 50, 50, 80, 50);

            e.Graphics.DrawEllipse(new Pen(Color.Pink, 10), rl1);
            e.Graphics.DrawEllipse(new Pen(Color.Pink, 10), rl2);
            g.DrawString("------------------------",
                new Font("Arial", 10), System.Drawing.Brushes.DarkRed, new Point(10, 50));
            g.DrawString("<>o<>o<>o<>",
                new Font("Arial", 10), System.Drawing.Brushes.DarkRed, new Point(10, 45));
            g.DrawString("------------------------",
               new Font("Arial", 10), System.Drawing.Brushes.DarkRed, new Point(10, 55));
            g.DrawString("<>o<>o<>o<>",
               new Font("Arial", 10), System.Drawing.Brushes.DarkRed, new Point(10, 60));

            e.Graphics.DrawEllipse(mojPen, r);
           // e.Graphics.DrawCurve(mojPen, new Point(10, 50));
            e.Graphics.DrawArc(mojPen, r, 2, 2);
            g.FillRectangle(Brushes.Red, 10, 10, 15, 25);
            //e.Graphics.FillRectangle(Brushes.Red, 10, 10, 15, 150);
            /*e.Graphics.DrawArc(mojPen, rl2, 20, -160);
                e.Graphics.DrawArc(mojPen, rl3, -20, 160);
                e.Graphics.DrawArc(mojPen, rl4, -40, -160);
                e.Graphics.DrawArc(mojPen, rl5, -90, 180);
                e.Graphics.DrawArc(mojPen, rl6, 90, 180);
            
    */
        }

        private void POCETNA_Load(object sender, EventArgs e)
        {

        }

        private void hijerarhijaProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeView n = new TreeView();
            n.Show();
        }
    }
}
