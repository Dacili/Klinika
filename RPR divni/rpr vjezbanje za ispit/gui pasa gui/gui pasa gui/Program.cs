using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace gui_pasa_gui
{
    class Program
    {
        static void dugme (object o, EventArgs e)
        {
            MessageBox.Show("izlazilm", "prozor", MessageBoxButtons.OKCancel);
            Application.Exit();
        }

        static void Main(string[] args)
        {
            Form m = new Form();
            m.Size = new Size(300, 300);
            m.Text = "haker";
            m.BackColor = Color.Red;

            Button dugmic = new Button();
            dugmic.Text = "Click here";
            dugmic.Location = new Point(100, 20);

            dugmic.Click += new EventHandler(dugme);

            m.Controls.Add(dugmic);


            Application.Run(m);

        }
    }
}
