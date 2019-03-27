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
    public partial class frmColas : Form
    {
        public frmColas()
        {
            InitializeComponent();
        }
        //Crear Coleccion de tipo cola

        Queue<Clases.Producto> cola = new Queue<Clases.Producto>();

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea grabar el producto?",
                                                 "Grabar Producto",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    Clases.Producto producto = new Clases.Producto();
                    //Cargar sus propiedades
                    producto.Codigo = Convert.ToInt32(txtCodigo.Text);
                    producto.Nombre = txtNombre.Text;
                    producto.Precio = Convert.ToDecimal(txtPrecio.Text);
                    producto.IGV = producto.ObtenerIGV();
                    producto.PrecioVenta = producto.ObtenerPrecioVenta();
                    //Mostrar IGV y PrecioVenta
                    txtIGV.Text = Convert.ToString(producto.IGV);
                    txtPrecioVenta.Text = Convert.ToString(producto.PrecioVenta);
                    //Guardar en la coleccion LIST
                    cola.Enqueue(producto);
                    cargarProductos();
                    MessageBox.Show("Registro almacenado con exito", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        void cargarProductos()
        {
            int contador = 0;
            DGVProductos.Rows.Clear();
            //Recorrer las claves principales almacenados en el diccionario
            foreach (Clases.Producto producto in cola)
            {
                //Agregar fila nueva a la grilla
                DGVProductos.Rows.Add();
                //Almacenar el codigo del producto
                DGVProductos.Rows[contador].Cells[0].Value = producto.Codigo;
                DGVProductos.Rows[contador].Cells[1].Value = producto.Nombre;
                DGVProductos.Rows[contador].Cells[2].Value = producto.Precio;
                DGVProductos.Rows[contador].Cells[3].Value = producto.IGV;
                DGVProductos.Rows[contador].Cells[4].Value = producto.PrecioVenta;
                contador++;
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.Producto pro = cola.Dequeue();
                txtCodigo.Text = Convert.ToString(pro.Codigo);
                txtNombre.Text = Convert.ToString(pro.Nombre);
                txtPrecio.Text = Convert.ToString(pro.Precio);
                txtIGV.Text = Convert.ToString(pro.IGV);
                txtPrecioVenta.Text = Convert.ToString(pro.PrecioVenta);
                cargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
