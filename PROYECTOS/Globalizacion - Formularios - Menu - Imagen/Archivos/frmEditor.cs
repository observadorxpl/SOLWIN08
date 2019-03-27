using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace POO.Archivos
{
    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Limpiar el cuadro de texto
            txtEditor.Clear();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog cd = new SaveFileDialog();
            cd.Filter = "Archivos de texto(*.txt)|*.txt";
            cd.ShowDialog();
            if (cd.FileName!="")
            {
                StreamWriter sw = new StreamWriter(cd.FileName);
                sw.Write(txtEditor.Text);
                sw.Flush();
                sw.Close();
                MessageBox.Show("Archivo almacenado con exito",
                    "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog cd = new OpenFileDialog();
            cd.Filter = "Archivos de texto (*.txt)|*.txt";
            cd.ShowDialog();
            if (cd.FileName != "")
            {
                StreamReader sr = new StreamReader(cd.FileName);
                txtEditor.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
    }
}
