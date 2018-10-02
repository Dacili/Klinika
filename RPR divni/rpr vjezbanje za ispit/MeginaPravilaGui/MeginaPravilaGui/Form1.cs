using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeginaPravilaGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (checkBox1.Checked) s += " Spol: Z\n";
            else s += " Spol: M\n";

            if (radioButton1.Checked)
                s += " hiii muslimm";
            MessageBox.Show(s);
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vidimo se");

        }
    }
}
