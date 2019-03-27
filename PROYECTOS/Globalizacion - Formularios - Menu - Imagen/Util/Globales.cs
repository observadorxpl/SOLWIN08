using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Util
{
  public static class Globales
    {
        public static void Limpiar( Colecciones.frmArreglos frm)
        {
            frm.txtCodigo.Text = "";
            frm.txtNombre.Text = "";
            frm.txtPrecio.Text = "";
            frm.txtIGV.Text="";
            frm.txtPrecioVenta.Text = "";
        }
        public static void Limpiar(Colecciones.frmListas frm)
        {
            frm.txtCodigo.Text = "";
            frm.txtNombre.Text = "";
            frm.txtPrecio.Text = "";
            frm.txtIGV.Text = "";
            frm.txtPrecioVenta.Text = "";
        }
        public static void Limpiar(Colecciones.frmDiccionario frm)
        {
            frm.txtCodigo.Text = "";
            frm.txtNombre.Text = "";
            frm.txtPrecio.Text = "";
            frm.txtIGV.Text = "";
            frm.txtPrecioVenta.Text = "";
        }
        public static void Limpiar(Colecciones.frmPila frm)
        {
            frm.txtCodigo.Text = "";
            frm.txtNombre.Text = "";
            frm.txtPrecio.Text = "";
            frm.txtIGV.Text = "";
            frm.txtPrecioVenta.Text = "";
        }
        public static void Limpiar(Colecciones.frmVentas frm)
        {
            frm.txtCodigo.Text = "";
            frm.dateFecha.Text = "";
            frm.txtPrecioUnitario.Text = "";
            frm.txtCantidad.Text = "";
            
        }

        public static bool PermiteNumeros(int tecla)
        {
            if ((tecla>=48 && tecla<=57) || tecla==8)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
