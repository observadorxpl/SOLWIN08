using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO.Colecciones
{
    public partial class frmListas : Form
    {
        //Crear una coleccion de tipo LIST
        List<Clases.Producto> productos = new List<Clases.Producto>();
       public frmListas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Util.Globales.Limpiar( this);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea grabar el producto?",
                                                   "Grabar Producto",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question) == DialogResult.Yes)
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
                productos.Add(producto);
                //Cargar datos en la grilla
                DGVProductos.DataSource = null;
                DGVProductos.DataSource = productos;
                txtTotal.Text = TotalizarColumnaGrid(4).ToString("C2");
                
                DGVProductos.Columns[4].DefaultCellStyle.Format = "C2";
                DGVProductos.Columns[4].DefaultCellStyle.BackColor =Color.Yellow;
                DGVProductos.Columns[4].DefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);


                MessageBox.Show("Registro almacenado con exito", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Util.Globales.PermiteNumeros(e.KeyChar);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            //Buscar el producto por su codigo en la coleccion  y especificar 
            //mediante una consulta  que devuelva una sola fila como maximo(single)
            var producto = productos.Where(p => p.Codigo == codigo).SingleOrDefault();
            //Si existe el producto
            if (producto!=null)
            {
                txtNombre.Text = producto.Nombre;
                txtPrecio.Text =Convert.ToString( producto.Precio);
                txtIGV.Text = Convert.ToString(producto.IGV);
                txtPrecioVenta.Text = Convert.ToString(producto.PrecioVenta);
            }
            else //Sino existe
            {
                MessageBox.Show("No existe el producto", "No encontrado",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            //Buscar el producto por su codigo en la coleccion  y especificar 
            //mediante una consulta  que devuelva una sola fila como maximo(single)
            var producto = productos.Where(p => p.Codigo == codigo).SingleOrDefault();
            //Si existe el producto
            if (producto != null)
            {
                if (MessageBox.Show("¿Esta seguro?", "Eliminar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    productos.Remove(producto);
                    Util.Globales.Limpiar(this);
                    DGVProductos.DataSource=null;
                    DGVProductos.DataSource = productos;
                }               
            }
            else //Sino existe
            {
                MessageBox.Show("No existe el producto", "No encontrado",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = DGVProductos.CurrentRow;

            txtCodigo.Text = fila.Cells[0].Value.ToString();
            txtNombre.Text = fila.Cells[1].Value.ToString();
            txtPrecio.Text = fila.Cells[2].Value.ToString();
            txtIGV.Text = fila.Cells[3].Value.ToString();
            txtPrecioVenta.Text = fila.Cells[4].Value.ToString();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
        }
        decimal TotalizarColumnaGrid(int numeroColumna)
        {
            decimal total = 0;
            foreach (DataGridViewRow fila in DGVProductos.Rows)
            {
                total += Convert.ToDecimal(fila.Cells[numeroColumna].Value);
            }
            return total;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            string bloc = "";
            foreach (DataGridViewRow fila in DGVProductos.Rows)
            {
                bloc = bloc +Convert.ToString(fila.Cells[0].Value) + "|"+
                       Convert.ToString(fila.Cells[1].Value) + "|" +
                       Convert.ToString(fila.Cells[2].Value) + "|" +
                       Convert.ToString(fila.Cells[3].Value) + "|" +
                       Convert.ToString(fila.Cells[4].Value) + "\r\n";

            }
            SaveFileDialog cd = new SaveFileDialog();
            cd.Filter = "Archivos de texto(*.txt)|*.txt";
            cd.ShowDialog();
            if (cd.FileName != "")
            {
                StreamWriter sw = new StreamWriter(cd.FileName);
                sw.Write(bloc);
                sw.Flush();
                sw.Close();
                MessageBox.Show("Archivo almacenado con exito",
                    "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

    }
    }

