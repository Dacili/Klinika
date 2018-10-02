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
    public partial class TreeView : Form
    {
        public TreeView()
        {
            InitializeComponent();

            TreeNode korijen = new TreeNode("Klinika");
            TreeNode pacijent = new TreeNode("Pacijent");
            TreeNode doktor = new TreeNode("Doktor");
            TreeNode osoblje = new TreeNode("Osoblje");
            treeView1.Nodes.Add(korijen);
            korijen.Nodes.AddRange(new TreeNode[] { pacijent, doktor, osoblje });
            korijen.Expand(); //ako hocemo da odmah prikaze sta se nalazi u cvoru imamo - opciju
            //bez ove gore linije vidimo samo root, i imamo opciju +

        }

       
    }
}
