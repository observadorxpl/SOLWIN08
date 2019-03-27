using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Compression;

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
            FolderBrowserDialog cd = new FolderBrowserDialog();
            cd.ShowDialog();
            if (cd.SelectedPath != "")
            {
                SaveFileDialog cd2 = new SaveFileDialog();
                cd2.Filter = "Archivos ZiP(*.zip)|*.zip";
                cd2.Title = "Elija la ruta destino del archivo comprimido";
                cd2.ShowDialog();
                if (cd2.FileName != "")
                {
                    ZipFile.CreateFromDirectory(cd.SelectedPath, cd2.FileName);
                    txtComprimir.Text = cd.SelectedPath;
                    txtDescomprimir.Text = cd2.FileName;
                }
            }
        }

        private void btnDescomprimir_Click(object sender, EventArgs e)
        {
            OpenFileDialog cd2 = new OpenFileDialog();
            cd2.Filter = "Archivos ZiP(*.zip)|*.zip";
            cd2.Title = "Seleccione el archivo comprimido";
            cd2.ShowDialog();

            if (cd2.FileName != "")
            {
                FolderBrowserDialog cd = new FolderBrowserDialog();
                cd.Description = "Seleccione la carpeta destino para descomprimir";
                cd.ShowDialog();
                if (cd.SelectedPath != "")
                {
                    //Descomprimir
                    try
                    { 
                    ZipFile.ExtractToDirectory(cd2.FileName, cd.SelectedPath);
                    txtDescomprimir.Text = cd.SelectedPath;
                        MessageBox.Show("Archivo descomprimido con exito", "Error", 
                            MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog cd = new FolderBrowserDialog();
            cd.ShowDialog();
            if (cd.SelectedPath != "")
            {
                SaveFileDialog cd2 = new SaveFileDialog();
                cd2.Filter = "Archivos ZiP(*.zip)|*.zip";
                cd2.Title = "Elija la ruta destino del archivo comprimido";
                cd2.ShowDialog();
                if (cd2.FileName != "")
                {
                    //Comprimir el archivo
                    ZipFile.CreateFromDirectory(cd.SelectedPath, cd2.FileName);
                    txtComprimir.Text = cd.SelectedPath;
                    txtDescomprimir.Text = cd2.FileName;
                    //Copiar el archivo comprimido al directorio de red compartido
                    string rutadestino = @"\\172.17.0.99\\compartido\\" +
                                                      System.IO.Path.GetFileName(cd2.FileName);
                    System.IO.File.Copy(cd2.FileName, rutadestino);
                }
            }
        }
    }
}



