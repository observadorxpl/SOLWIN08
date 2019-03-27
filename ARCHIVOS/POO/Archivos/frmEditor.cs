using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Limpiar el cuadro de texto
            txtEditor.Clear();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog cd = new SaveFileDialog();
            //Mostrar solo archivos de extension txt
            cd.Filter = "Archivos de texto(*.txt)|*.txt";
            //mostrar la ventana de dialogo Guardar como
            cd.ShowDialog();
            //Validar si se eligio un nombre de archivo
            if (cd.FileName != "")
            {
                //Crear un flujo para escritura
                StreamWriter sw = new StreamWriter(cd.FileName);
                //escribir en el flujo la informacion del txteditor
                sw.Write(txtEditor.Text);
                //Vaciar la informacion al archivo
                sw.Flush();
                //Cerrar el flujo
                sw.Close();
                MessageBox.Show("Archivo almacenado con exito" ,
                    "Exito" , MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ventana de dialogo para abrir
            OpenFileDialog cd = new OpenFileDialog();
            cd.Filter = "Archivos de texto(*.txt)|*.txt";
            cd.ShowDialog();
            if (cd.FileName!="")
            {
                //Crear un flujo de lectura 
                StreamReader sr = new StreamReader(cd.FileName);
                //Leer el archivo
                txtEditor.Text = sr.ReadToEnd();
                //Cerrar flujo
                sr.Close();
            }
        }
    }
}
            




