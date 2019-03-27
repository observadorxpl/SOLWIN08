using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Para trabajar con discos, carpetas y archivos
using System.IO;
namespace POO.Colecciones
{
    public partial class frmExplorador : Form
    {
        public frmExplorador()
        {

            InitializeComponent();
        }

        private void cboDisco_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Obetener informacion del disco
                DriveInfo di = new DriveInfo(cboDisco.Text);
                lblTamaño.Text = Convert.ToString(di.TotalSize);
                lblDisponible.Text = Convert.ToString(di.TotalFreeSpace);

                //Listar las carpetas del disco seleccionado
                lstCarpetas.DataSource = Directory.GetDirectories(cboDisco.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmExplorador_Load(object sender, EventArgs e)
        {
            CargarDiscos();
        }
        void CargarDiscos()
        {
            cboDisco.DataSource = DriveInfo.GetDrives();
        }

        private void lstCarpetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lstArchivos.DataSource = Directory.GetFiles(lstCarpetas.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void lstArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(lstArchivos.Text);
            if (fi.Extension == ".gif" || fi.Extension == ".jpg" || fi.Extension == ".png")
            {
                pctImagen.Image = Image.FromFile(lstArchivos.Text);
                
            }
        }

        private void lstArchivos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(lstArchivos.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
