﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POO.Colecciones
{
    public partial class frmPila : Form
    {
        //Crear una coleccion de tipo Pila
        Stack<Clases.Producto> pila = new Stack<Clases.Producto>();
        public frmPila()
        {
            InitializeComponent();
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
                    //Guardar en la coleccion de tipo pila
                    pila.Push(producto);
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
            //Recorrer las objetos  almacenados en la pila
            foreach (Clases.Producto producto in pila)
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
            //Leer los elementos de la pila 
            if (pila.Count > 0)
            {
                Clases.Producto producto = pila.Pop();
                txtCodigo.Text = Convert.ToString(producto.Codigo);
                txtNombre.Text = Convert.ToString(producto.Nombre);
                txtPrecio.Text = Convert.ToString(producto.Precio);
                txtIGV.Text = Convert.ToString(producto.IGV);
                txtPrecioVenta.Text = Convert.ToString(producto.PrecioVenta);
                //Refrescar la grilla 
                cargarProductos();
            }
            else
            {
                MessageBox.Show("La pila no contiene elementos",
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
