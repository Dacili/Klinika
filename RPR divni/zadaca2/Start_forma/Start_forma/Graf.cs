using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Start_forma
{
    public partial class Graf : Form
    {
        public Graf()
        {
            InitializeComponent();
            fja();
            chart1.Series["Series1"].Points.AddXY("Zutica", 200);
            chart1.Series["Series1"].Points.AddXY("Prehlada", 1000);
            chart1.Series["Series1"].Points.AddXY("Gripa", 800);
            chart1.Series["Series1"].Points.AddXY("Alergija", 650);

        }
        public void fja()
        {
           /*
                //AddXY value in chart1 in series named as Salary  
                chart1.Series["2"].Points.AddXY("Ajay", "10000");
                chart1.Series["3"].Points.AddXY("Ramesh", "8000");
                chart1.Series["4"].Points.AddXY("Ankit", "7000");
                chart1.Series["5"].Points.AddXY("Gurmeet", "10000");
                chart1.Series["6"].Points.AddXY("Suresh", "8500");
            chart1.Series["7"].Points.AddXY("Suresh", "8500");
            //chart title  
            chart1.Titles.Add("Salary Chart");*/
            
        }
       

     
    }
}
