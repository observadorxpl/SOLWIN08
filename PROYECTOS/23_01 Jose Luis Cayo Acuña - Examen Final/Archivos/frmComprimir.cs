using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;

namespace POO.Archivos
{
    public partial class frmComprimir : Form
    {
        public frmComprimir()
        {
            InitializeComponent();
        }

        private void btnComprimir_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog cd = new FolderBrowserDialog();
                cd.ShowDialog();
                if (cd.SelectedPath!= "")
                {
                    SaveFileDialog cd2 = new SaveFileDialog();
                    cd2.Filter = "Archivos Zip(*zip)|*.zip";
                    cd2.Title = "Elija la ruta de destino del archivo comprimido";
                    cd2.ShowDialog();
                    if (cd2.FileName != "")
                    {
                        ZipFile.CreateFromDirectory(cd.SelectedPath, cd2.FileName);
                        txtComprimir.Text = cd.SelectedPath;
                        txtDescomprimir.Text = cd2.FileName;
                        MessageBox.Show("Archivo comprimido con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDescomprimir_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Archivos Zip(*zip)|*.zip";
            op.Title = "Eliga el archivo a descomprimir";
            op.ShowDialog();
            if (op.FileName != "")
            {
                FolderBrowserDialog cd = new FolderBrowserDialog();
                cd.ShowDialog();
                if(cd.SelectedPath!="")
                {
                    DirectoryInfo di = new DirectoryInfo(op.FileName+ System.IO.Path.GetFileName(op.FileName));
                    ZipFile.ExtractToDirectory(op.FileName, cd.SelectedPath);
                    txtComprimir.Text = op.FileName;
                    txtDescomprimir.Text = cd.SelectedPath;
                    MessageBox.Show("Archivo descomprimido con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog cd = new FolderBrowserDialog();
                cd.ShowDialog();
                if (cd.SelectedPath != "")
                {
                    SaveFileDialog cd2 = new SaveFileDialog();
                    cd2.Filter = "Archivos Zip(*zip)|*.zip";
                    cd2.Title = "Elija la ruta de destino del archivo comprimido";
                    cd2.ShowDialog();
                    if (cd2.FileName != "")
                    {
                        ZipFile.CreateFromDirectory(cd.SelectedPath, cd2.FileName);
                        txtComprimir.Text = cd.SelectedPath;
                        txtDescomprimir.Text = cd2.FileName;

                        string rutadestino = @"\\172.17.0.99\\compartido\\" +
                                              System.IO.Path.GetFileName(cd2.FileName);
                        System.IO.File.Copy(cd2.FileName, rutadestino);
                        MessageBox.Show("Archivo comprimido con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
