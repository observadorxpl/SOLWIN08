using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases
{
    class Venta
    {
        public int codigo { get; set; }
        public DateTime fecha { get; set; }
        public int cantidad { get; set; }
        public decimal precioUnidad { get; set; }
        public decimal subTotal { get; set; }
        public decimal descuento { get; set; }
        public decimal total { get; set; }
        public Venta() {
        }
        public Venta(int codigo, DateTime fecha, int cantidad, decimal precioUnidad)
        {
            this.codigo = codigo;
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.precioUnidad = precioUnidad;
        }
        public decimal ObtenerSubtotal() {
            this.subTotal = this.cantidad * precioUnidad;
            return this.subTotal;
        }
        public decimal ObternerDescuento()
        {
            if (this.subTotal > 100)
            {
                this.descuento = 0.05m*this.subTotal;
            }
            else {
                this.descuento = 0m*this.subTotal;
            }
            return this.descuento;
        }
        public decimal ObtenerTotal()
        {
            this.total = this.subTotal - this.descuento;
            return this.total;
        }
    }
}
