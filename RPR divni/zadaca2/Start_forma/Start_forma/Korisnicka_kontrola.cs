using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Start_forma
{
    class Korisnicka_kontrola: UserControl
    {
       


            private List<Object> _SelectedItems;
            public List<Object> SelectedItems
            {
                get { return _SelectedItems; }
            }

            private List<Object> _Items;

            //[Browsable(true)]
            //[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            /*
            public List<Object> Items
            {
                get { return _Items; }
                set
                {
                    _Items = value;
                    _SelectedItems = new List<object>();

                    this.lista.Controls.Clear();
                    this.select.Controls.Clear();

                    if (value != null)
                        foreach (Object o in _Items)
                        {
                            CheckBox chb = new CheckBox();
                            chb.Appearance = Appearance.Button;
                            chb.FlatStyle = FlatStyle.Flat;
                            chb.FlatAppearance.BorderSize = 0;
                            chb.FlatAppearance.CheckedBackColor = Color.CornflowerBlue;
                            chb.Margin = new System.Windows.Forms.Padding(0);
                            chb.Width = this.lista.Width - 20;
                            chb.Text = o.ToString();
                            chb.Tag = o;
                            chb.CheckedChanged += new EventHandler(this.listaSelectChanged);
                            this.lista.Controls.Add(chb);
                        }
                }
            }

            public MultiSelectBox()
            {
                InitializeComponent();
                lista.Size = new Size(this.Width, 0);
            }

            public MultiSelectBox(List<object> items) : this()
            {
                Items = items;
            }

            private void listaSelectChanged(object sender, EventArgs e)
            {
                CheckBox chb = (CheckBox)sender;
                if (chb.Checked)
                {
                    _SelectedItems.Add(chb.Tag);
                    Button button = new Button();
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
                    button.Text = chb.Tag.ToString();
                    button.BackColor = Color.CornflowerBlue;
                    button.ForeColor = Color.White;
                    button.Tag = chb.Tag;
                    this.select.Controls.Add(button);
                    lista.Location = new Point(lista.Location.X, select.Location.Y + select.Height);
                }
                else
                {
                    _SelectedItems.Remove(chb.Tag);
                    Button button = this.select.Controls.Cast<Button>().FirstOrDefault(o => o.Tag == chb.Tag);
                    if (button != null)
                    {
                        this.select.Controls.Remove(button);
                        lista.Location = new Point(lista.Location.X, select.Location.Y + select.Height);
                    }
                }

            }

            private void button1_Click(object sender, EventArgs e)
            {
                if (lista.Height == 0)
                {
                    lista.Size = new Size(lista.Width, 100);
                    lista.Location = new Point(lista.Location.X, select.Location.Y + select.Height);
                }
                else
                {
                    lista.Size = new Size(lista.Width, 0);
                }
            }*/
        }
    }


