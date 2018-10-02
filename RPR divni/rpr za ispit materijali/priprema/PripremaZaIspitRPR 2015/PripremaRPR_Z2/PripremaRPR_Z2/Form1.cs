using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PripremaRPR_Z2
{
    public partial class Form1 : Form
    {
        private TextBox mojTextBox;
        public Form1()
        {
            mojTextBox = new TextBox();
            mojTextBox.Size = new Size(169, 20);
            mojTextBox.Location = new Point(75, 166);

            InitializeComponent();
            labelRezultat.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxMnozenje_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMnozenje.Checked && !checkBoxDijeljenje.Checked)
                generisiTextBox();
            else
                obrisiTextBox();

        }

        private void Dijeljenje_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDijeljenje.Checked && !checkBoxMnozenje.Checked)
                generisiTextBox();
            else
                obrisiTextBox();
        }

        public void generisiTextBox()
        {
            this.Controls.Add(mojTextBox);
        }

        public void obrisiTextBox()
        {
            this.Controls.Remove(mojTextBox);
        }

        private void buttonRezultat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Provjera rezultata je u toku...", "Informacija", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (checkBoxMnozenje.Checked)
            {
                if (dr == DialogResult.OK)
                {
                    if (Convert.ToInt32(mojTextBox.Text) != Convert.ToInt32(textBoxBroj1.Text) * Convert.ToInt32(textBoxBroj2.Text))
                    {
                        labelRezultat.Visible = true;
                        labelRezultat.Text = Convert.ToString(Convert.ToInt32(textBoxBroj1.Text) * Convert.ToInt32(textBoxBroj2.Text));
                    }
                    else
                    {
                        mojTextBox.Font = new Font("Arial", 16);
                        mojTextBox.ForeColor = Color.Green;
                    }
                }
            }
            else if(checkBoxDijeljenje.Checked)
            {
                if (dr == DialogResult.OK)
                {
                    if (Convert.ToDouble(mojTextBox.Text) != Convert.ToDouble(textBoxBroj1.Text) / Convert.ToDouble(textBoxBroj2.Text))
                    {
                        labelRezultat.Visible = true;
                        labelRezultat.Text = Convert.ToString(Convert.ToDouble(textBoxBroj1.Text) / Convert.ToDouble(textBoxBroj2.Text));
                    }
                    else
                    {
                        mojTextBox.Font = new Font("Arial", 16);
                        mojTextBox.ForeColor = Color.Green;
                    }
                }
            }
        }
    }
}
