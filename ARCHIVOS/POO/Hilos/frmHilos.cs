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

        Thread hilo1 = null;
        Thread hilo2 = null;
        Thread hilo3 = null;
        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            //Permitir que un hilo pueda acceder a recursos de otro hilo
            Control.CheckForIllegalCrossThreadCalls = false;
            Parametros param= new Parametros();
            param.Inicio = 0;
            param.Fin = 600000;          
            //Inicializar los hilos
            hilo1 = new Thread(Tarea1);
            hilo2 = new Thread(Tarea2);
            hilo3 = new Thread(Tarea3);
            //Ejecutar los hilos y pasar los parametros
            hilo1.Start(param);
            hilo2.Start(param);
            hilo3.Start(param);
        }
        void Tarea1(object parametros)
        {
            Parametros parametro = (Parametros)parametros;
            progressBar1.Minimum = parametro.Inicio;
            progressBar1.Maximum = parametro.Fin;
            for (int i=progressBar1.Minimum; i<= progressBar1.Maximum; i++)
            {
                progressBar1.Value = i;
            }
        }
        void Tarea2(object parametros)
        {
            Parametros parametro = (Parametros)parametros;
            progressBar2.Minimum = parametro.Inicio;
            progressBar2.Maximum = parametro.Fin;
            for (int i = progressBar2.Minimum; i <= progressBar2.Maximum; i++)
            {
                progressBar2.Value = i;
            }
        }
        void Tarea3(object parametros)
        {
            Parametros parametro = (Parametros)parametros;
            progressBar3.Minimum = parametro.Inicio;
            progressBar3.Maximum = parametro.Fin;
            for (int i = progressBar3.Minimum; i <= progressBar3.Maximum; i++)
            {
                progressBar3.Value = i;
            }
        }

        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Parametros param = new Parametros();
            param.Inicio = 0;
            param.Fin = 600000;
            //Inicializar los hilos
            hilo1 = new Thread(Tarea1);            
            //Ejecutar los hilos y pasar los parametros
            hilo1.Start(param);            
        }

        private void pausarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hilo1.Suspend();
        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hilo1.Resume();
        }

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hilo1.Abort();
        }
    }
}
public class Parametros
{
    public int Inicio { get; set; }
    public int Fin { get; set; }   
}






