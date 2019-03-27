using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace POO.Hilos
{
    public partial class frmHilos : Form 
    {
        public frmHilos()
        {
            InitializeComponent();
        }



        void Tarea1(object parametros)
        {
            Parametros parametro = (Parametros)parametros;
           progressBar1.Minimum = parametro.inicio;
            progressBar1.Maximum= parametro.fin;
                for (int i = progressBar1.Minimum; i <= progressBar1.Maximum; i++)
                {
                    progressBar1.Value = i;
                }
 
        }
        void Tarea2(object parametros)
        {
            Parametros parametro = (Parametros)parametros;
            progressBar2.Minimum = parametro.inicio;
            progressBar2.Maximum = parametro.fin;

            for (int i = progressBar2.Minimum; i <= progressBar2.Maximum; i++)
            {
                progressBar2.Value = i;
            }
        }
        void Tarea3(object parametros)
        {
            Parametros parametro = (Parametros)parametros;
            progressBar3.Minimum = parametro.inicio;
            progressBar3.Maximum = parametro.fin;

            for (int i = progressBar3.Minimum; i <= progressBar3.Maximum; i++)
            {
                progressBar3.Value = i;
            }
        }
        
        Thread hilo1 = null;
        Thread hilo2 = null;
        Thread hilo3 = null;
        private void btnEjecutar_Click(object sender, EventArgs e) 
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Parametros param = new Parametros();
            param.inicio = 0;
            param.fin = 6000;
            
            hilo1 = new Thread(Tarea1);
            hilo2 = new Thread(Tarea2);
            hilo3 = new Thread(Tarea3);

            hilo1.Start(param);
            hilo2.Start(param);
            hilo3.Start(param);
    
        }

        private void frmHilos_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Parametros param = new Parametros();
            param.inicio = 0;
            param.fin = 600000;

            hilo1 = new Thread(Tarea1);
            hilo1.Start(param);

        }

        private void pausarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pausar el hilo
            hilo1.Suspend();
        }

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cancelar el hilo, (¡No se puede cancelar cuando esta pausado!)
            hilo1.Abort();
        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {//Continuar con la ejecucion del hilo
            hilo1.Resume();
        }
    }
}
public class Parametros {
    public int inicio {get; set;}
    public int fin { get; set;}
    public Parametros() {
    }
    
}