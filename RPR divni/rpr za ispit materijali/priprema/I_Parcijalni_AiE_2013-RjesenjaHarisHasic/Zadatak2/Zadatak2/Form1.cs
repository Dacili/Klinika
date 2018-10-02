using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_godinaRodenja.Text = Convert.ToString(DateTime.Now.Year - Convert.ToInt32(numericUpDown_godine.Value));
            //MessageBox.Show(Convert.ToString(comboBox_StrucnaSprema.Text));
        }

        private void numericUpDown_godine_ValueChanged(object sender, EventArgs e)
        {
            checkBox_Ispravno.Visible = true;
        }

        private void checkBox_Ispravno_CheckedChanged(object sender, EventArgs e)
        {
            if(!checkBox_Ispravno.Checked)
                MessageBox.Show("Uneseni podaci nisu ispravni.");

            else
                MessageBox.Show("Uneseni podaci su ispravni.");
        }
    }
}
