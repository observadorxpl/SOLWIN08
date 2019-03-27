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
    public partial class frmVentas : Form
    {
        Dictionary<int, Clases.Venta> ventas = new Dictionary<int, Clases.Venta>();
        public frmVentas()
        {
            InitializeComponent();
            txtTotalSubTotal.Text = "0";
            txtTotalDescuento.Text = "0";
            txtTotalTotal.Text = "0";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Util.Globales.Limpiar(this);
        }
        void cargarDatos() {
            int contador = 0;

            decimal subtotal = 0;
            decimal descuento = 0;
            decimal total = 0;

            DGVventas.Rows.Clear();
            foreach (KeyValuePair<int, Clases.Venta> clave in ventas)
            {
                DGVventas.Rows.Add();
                DGVventas.Rows[contador].Cells[0].Value = clave.Value.codigo;
                DGVventas.Rows[contador].Cells[1].Value = clave.Value.fecha;
                DGVventas.Rows[contador].Cells[2].Value = clave.Value.cantidad;
                DGVventas.Rows[contador].Cells[3].Value = clave.Value.precioUnidad;
                DGVventas.Rows[contador].Cells[4].Value = clave.Value.subTotal;
                DGVventas.Rows[contador].Cells[5].Value = clave.Value.descuento;
                DGVventas.Rows[contador].Cells[6].Value = clave.Value.total;

                subtotal = subtotal + clave.Value.subTotal;
                descuento = descuento + clave.Value.descuento;
                total = total + clave.Value.total;
                txtTotalSubTotal.Text = Convert.ToString(subtotal);
                txtTotalDescuento.Text = Convert.ToString(descuento);
                txtTotalTotal.Text = Convert.ToString(total);

                contador++;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea ingresar la venta?", "Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Clases.Venta ve = new Clases.Venta();
                    ve.codigo = Convert.ToInt32(txtCodigo.Text);
                    ve.precioUnidad = Convert.ToInt32(txtPrecioUnitario.Text);
                    ve.cantidad = Convert.ToInt32(txtCantidad.Text);
                    ve.fecha = Convert.ToDateTime(dateFecha.Text);
                    ve.ObtenerSubtotal();
                    ve.ObternerDescuento();
                    ve.ObtenerTotal();
                    ventas.Add(ve.codigo, ve);
                    cargarDatos();

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            if (ventas.ContainsKey(codigo) == true)
            {
                dateFecha.Text = Convert.ToString(ventas[codigo].fecha);
                txtCantidad.Text = Convert.ToString(ventas[codigo].cantidad);
                txtPrecioUnitario.Text = Convert.ToString(ventas[codigo].precioUnidad);
            }
            else {
                MessageBox.Show("No se ha encontrado la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                if (ventas.ContainsKey(codigo) == true)
                {
                    ventas.Remove(codigo);
                    cargarDatos();
                    if (ventas.Count == 0) {
                        txtTotalSubTotal.Text = "0";
                        txtTotalDescuento.Text = "0";
                        txtTotalTotal.Text = "0";
                    }
   
                }
                else
                {
                    MessageBox.Show("No existe la venta a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTotalTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
