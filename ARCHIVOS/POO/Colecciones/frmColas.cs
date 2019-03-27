using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POO.Colecciones
{
    //Crear una coleccion tipo cola
   
    public partial class frmColas : Form
    {
        Queue<Clases.Producto> cola = new Queue<Clases.Producto>();

        public frmColas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea grabar el producto?", "Grabar Producto",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Clases.Producto producto = new Clases.Producto();
                    //Grabar un registro de producto
                    producto.Codigo = Convert.ToInt32(txtCodigo.Text);
                    producto.Nombre = txtNombre.Text;
                    producto.Precio = Convert.ToInt32(txtPrecio.Text);
                    producto.IGV = producto.ObtenerIGV();
                    producto.PrecioVenta = producto.ObtenerPrecioVenta();
                    //Mostrar IGV y PrecioVenta
                    txtIGV.Text = Convert.ToString(producto.IGV);
                    txtPrecioVenta.Text = Convert.ToString(producto.PrecioVenta);
                    //Guardar en la coleccion de tipo cola
                    cola.Enqueue(producto);
                    //Cargar datos en la grilla
                    cargarProductos();
                    MessageBox.Show("Registro almacenado con exito", "Exito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
        }
        void cargarProductos()
        {
            int contador = 0;
            //Eliminar las filas del datagridview
            DGVProductos.Rows.Clear();
            //Recorrer las objetos  almacenados en la cola
            foreach (Clases.Producto producto in cola)
            {
                //agregar una fila nueva a la grilla
                DGVProductos.Rows.Add();
                //almacenar el codigo del producto en la columna cero
                DGVProductos.Rows[contador].Cells[0].Value = producto.Codigo;
                DGVProductos.Rows[contador].Cells[1].Value = producto.Nombre;
                DGVProductos.Rows[contador].Cells[2].Value = producto.Precio;
                DGVProductos.Rows[contador].Cells[3].Value = producto.IGV;
                DGVProductos.Rows[contador].Cells[4].Value = producto.PrecioVenta;
                //Incrementar el contador en +1
                contador += 1;
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los elementos de la cola segun orden de llegada
            Clases.Producto producto = cola.Dequeue();

            txtCodigo.Text = Convert.ToString(producto.Codigo);
            txtNombre.Text = Convert.ToString(producto.Nombre);
            txtPrecio.Text = Convert.ToString(producto.Precio);
            txtIGV.Text = Convert.ToString(producto.IGV);
            txtPrecioVenta.Text = Convert.ToString(producto.PrecioVenta);
            //Refrescar la grilla 
            cargarProductos();
        }
    }
}





