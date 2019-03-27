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
    public partial class frmDiccionario : Form
    {
        //Crear un diccionario
        Dictionary<int, Clases.Producto> diccionario = new Dictionary<int, Clases.Producto>();
        
        public frmDiccionario()
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
                    //Guardar en la coleccion diccionario
                    diccionario.Add(producto.Codigo, producto);
                    //Cargar datos en la grilla
                    cargarProductos();
                    MessageBox.Show("Registro almacenado con exito", "Exito", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch(Exception ex)
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
            //Recorrer las claves principales almacenados en el diccionario
            foreach(KeyValuePair<int,Clases.Producto> clave in diccionario)
            {
                //agregar una fila nueva a la grilla
                DGVProductos.Rows.Add();
                //almacenar el codigo del producto en la columna cero
                DGVProductos.Rows[contador].Cells[0].Value = clave.Value.Codigo;
                DGVProductos.Rows[contador].Cells[1].Value = clave.Value.Nombre;
                DGVProductos.Rows[contador].Cells[2].Value = clave.Value.Precio;
                DGVProductos.Rows[contador].Cells[3].Value = clave.Value.IGV;
                DGVProductos.Rows[contador].Cells[4].Value = clave.Value.PrecioVenta;
                //Incrementar el contador en +1
                contador += 1;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                //Preguntar si en el diccionario existe un producto con el codigo buscado
                if (diccionario.ContainsKey(codigo) == true)
                {
                    txtNombre.Text = diccionario[codigo].Nombre;
                    txtPrecio.Text = Convert.ToString(diccionario[codigo].Precio);
                    txtIGV.Text = Convert.ToString(diccionario[codigo].IGV);
                    txtPrecioVenta.Text = Convert.ToString(diccionario[codigo].PrecioVenta);
                }
                else //sino existe
                {
                    MessageBox.Show("No existe el producto buscado", "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                //Preguntar si en el diccionario existe un producto con el codigo buscado
                if (diccionario.ContainsKey(codigo) == true)
                {
                    //Eliminar el objeto
                    diccionario.Remove(codigo);
                    //Recargar grilla
                    cargarProductos();
                }
                else //sino existe
                {
                    MessageBox.Show("No existe el producto buscado", "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
    }
}




