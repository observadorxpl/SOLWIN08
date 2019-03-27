using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO.Globalizacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colecciones.frmListas frm = new Colecciones.frmListas();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }
    }
}
