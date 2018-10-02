using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace digitron
{
    class Program
    {
        public static string s = "";

        static void klikNaDugmejednako(object sender, EventArgs e)
        {
            //Console.WriteLine(s);
            bool nasao = false;
            char znak = '0';
            foreach (char i in s)
            {
                if ((i == '+' || i == '-' || i == '*' || i == '/') && nasao == false)
                {
                    nasao = true;
                    znak = i;
                    // continue;
                }
                else if ((i == '+' || i == '-' || i == '*' || i == '/') && nasao == true)
                {
                    Console.WriteLine("GRESKA");
                    return;
                }
            }
            string[] niz = s.Split(znak);
            if (znak == '+') Console.WriteLine(Convert.ToString(Convert.ToInt32(niz[0]) + Convert.ToInt32(niz[1])));
            if (znak == '-') Console.WriteLine(Convert.ToString(Convert.ToInt32(niz[0]) - Convert.ToInt32(niz[1])));
            if (znak == '*') Console.WriteLine(Convert.ToString(Convert.ToInt32(niz[0]) * Convert.ToInt32(niz[1])));
            if (znak == '/') Console.WriteLine(Convert.ToString(Convert.ToInt32(niz[0]) / Convert.ToInt32(niz[1])));
            s = "";
        }
        static void klikNaDugme1(object sender, EventArgs e)
        {
            s += "1";
        }
        static void klikNaDugme2(object sender, EventArgs e)
        {
            s += "2";
        }
        static void klikNaDugme3(object sender, EventArgs e)
        {
            s += "3";
        }
        static void klikNaDugme4(object sender, EventArgs e)
        {
            s += "4";
        }
        static void klikNaDugme5(object sender, EventArgs e)
        {
            s += "5";
        }
        static void klikNaDugme6(object sender, EventArgs e)
        {
            s += "6";
        }
        static void klikNaDugme7(object sender, EventArgs e)
        {
            s += "7";
        }
        static void klikNaDugme8(object sender, EventArgs e)
        {
            s += "8";
        }
        static void klikNaDugme9(object sender, EventArgs e)
        {
            s += "9";
        }
        static void klikNaDugme0(object sender, EventArgs e)
        {
            s += "0";
        }
        static void klikNaDugmeplus(object sender, EventArgs e)
        {
            s += "+";
        }
        static void klikNaDugmeminus(object sender, EventArgs e)
        {
            s += "-";
        }
        static void klikNaDugmeputa(object sender, EventArgs e)
        {
            s += "*";
        }
        static void klikNaDugmepodijeljeno(object sender, EventArgs e)
        {
            s += "/";
        }

        static void Main(string[] args)
        {
            Form digitron = new Form();
            digitron.Size = new Size(350, 400);
            digitron.MaximumSize = digitron.Size;
            digitron.MinimumSize = digitron.Size;
            digitron.StartPosition = FormStartPosition.CenterScreen;
            digitron.Text = "Digitron";
            digitron.BackColor = Color.Pink;
            digitron.ForeColor = Color.Black;
            digitron.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);
            digitron.Padding = new Padding(5, 5, 5, 5);

            GroupBox groupBox = new GroupBox();
            groupBox.Dock = DockStyle.Fill;
            groupBox.Text = "";
            digitron.Controls.Add(groupBox);

            TextBox textBox1 = new TextBox();
            textBox1.Size = new Size(195, 25);
            textBox1.Location = new Point(60, 10);
            groupBox.Controls.Add(textBox1);

            List<string> l = new List<string> { "1", "2", "3", "+", "4", "5", "6", "-", "7", "8", "9", "*", "0", "=", "/" };
            List<Button> b = new List<Button>(15);


            int pomocni = 0, pomocni2 = 0;

            for (int i = 0; i < 15; i++)
            {
                b.Add(new Button());
                //Button b[i] = new Button();
                if (i % 4 == 0 && i != 0) { pomocni++; pomocni2 = 0; }
                if (l[i] != "=")
                {
                    b[i].Size = new Size(60, 60);
                    b[i].Location = new Point(10 + pomocni2 * 70, 40 + pomocni * 70);
                }
                else
                {
                    b[i].Size = new Size(130, 60);
                    b[i].Location = new Point(10 + pomocni2 * 70, 40 + pomocni * 70);
                    pomocni2++;
                }
                pomocni2++;
                b[i].Text = l[i];
                b[i].BackColor = Color.LightGray;
                groupBox.Controls.Add(b[i]);

            }
            b[13].Click += new EventHandler(klikNaDugmejednako);
            b[0].Click += new EventHandler(klikNaDugme1);
            b[1].Click += new EventHandler(klikNaDugme2);
            b[2].Click += new EventHandler(klikNaDugme3);
            b[3].Click += new EventHandler(klikNaDugmeplus);
            b[4].Click += new EventHandler(klikNaDugme4);
            b[5].Click += new EventHandler(klikNaDugme5);
            b[6].Click += new EventHandler(klikNaDugme6);
            b[7].Click += new EventHandler(klikNaDugmeminus);
            b[8].Click += new EventHandler(klikNaDugme7);
            b[9].Click += new EventHandler(klikNaDugme8);
            b[10].Click += new EventHandler(klikNaDugme9);
            b[11].Click += new EventHandler(klikNaDugmeputa);
            b[12].Click += new EventHandler(klikNaDugme0);

            b[14].Click += new EventHandler(klikNaDugmepodijeljeno);
            Application.Run(digitron);



        }
    }
}