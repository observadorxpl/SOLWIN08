using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colecciones.frmListas frm = new Colecciones.frmListas();
            frm.MdiParent = this;
            frm.StartPosition=FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void btnColeciones_Click(object sender, EventArgs e)
        {
            listasToolStripMenuItem_Click(null, null);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
