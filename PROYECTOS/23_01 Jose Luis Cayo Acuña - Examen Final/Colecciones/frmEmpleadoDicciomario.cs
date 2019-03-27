using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO.Colecciones
{
    public partial class frmEmpleadoDicciomario : Form
    {
        public frmEmpleadoDicciomario()
        {
            InitializeComponent();
        }
        Dictionary<String, Clases.Empleado> diccionario = new Dictionary<String, Clases.Empleado>();
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Se ingresara un nuevo empleado, ¿Esta seguro?", "Ingresar Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Clases.Empleado emp = new Clases.Empleado();
                    emp.Nombre = txtNombre.Text;
                    emp.Apellidos = txtApellidos.Text;
                    emp.FechaContrato = Convert.ToDateTime(txtFechaContrato.Text);
                    emp.DNI = txtDNI.Text;
                    diccionario.Add(emp.DNI, emp);
                    mostrarDatos();
                }
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            Clases.Empleado emp = buscar(txtDNI.Text);
            
            if (MessageBox.Show("Se eliminara el empleado: " + emp.Nombre + " " + emp.Apellidos + " ." + "¿Esta seguro ?", "Eliminar Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                diccionario.Remove(emp.DNI);
            }
            mostrarDatos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Clases.Empleado emp =buscar(txtDNI.Text);
            if (emp == null)
            {
                MessageBox.Show("El empleado no se ha encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtNombre.Text = emp.Nombre;
                txtApellidos.Text = emp.Apellidos;
                txtFechaContrato.Text = Convert.ToString(emp.FechaContrato);
                txtDNI.Text = emp.DNI;
            }
        }
        Clases.Empleado buscar(String DNI)
        {
            if(diccionario.ContainsKey(DNI) == true)
            {
                return diccionario[DNI];
            }
            else
            {
                return null;
            }
        }
        void mostrarDatos() {
            DGVEmpleados.Rows.Clear();
            int contador = 0;
            foreach (KeyValuePair<String, Clases.Empleado> clave in diccionario)
            {

                DGVEmpleados.Rows.Add();
                DGVEmpleados.Rows[contador].Cells[0].Value = clave.Value.Nombre;
                DGVEmpleados.Rows[contador].Cells[1].Value = clave.Value.Apellidos;
                DGVEmpleados.Rows[contador].Cells[2].Value = clave.Value.FechaContrato;
                DGVEmpleados.Rows[contador].Cells[3].Value = clave.Value.DNI;

                contador++;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmEmpleadoDicciomario_Load(object sender, EventArgs e)
        {

        }
    }
}
