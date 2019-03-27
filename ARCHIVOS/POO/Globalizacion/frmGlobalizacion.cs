using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace POO.Globalizacion
{
    public partial class frmGlobalizacion : Form
    {
        public frmGlobalizacion()
        {
            InitializeComponent();
        }

        void ListarPaises()
        {
            List<string> lista = new List<string>();
            //Obtener la lista de culturas del mundo
            CultureInfo[] paises = CultureInfo.GetCultures(
                                                CultureTypes.SpecificCultures);
            //Recorrer las culturas del mundo para obtener los paises
            foreach(CultureInfo cultura in paises)
            {
                //obtener la region por el codigo de cultura
                RegionInfo region = new RegionInfo(cultura.LCID);
                //Validar que no existan  paises duplicado
                if (lista.Contains(region.DisplayName)==false)
                {
                    lista.Add(region.DisplayName);
                }
            }
            //Ordenar la lista de paises
            lista.Sort();
            cboPaises.DataSource = lista;
        }

        //Crear una cultura 
        CultureInfo culturaActual = null;
        private void frmGlobalizacion_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            ListarPaises();
            //Obtener la cultura actual del sistema operativo establecida
            //en el panel de control
         //   culturaActual = Application.CurrentCulture;
            //Cargar los meses del año
            lstMesesAño.DataSource = culturaActual.DateTimeFormat.MonthNames;
            lstDiasSemana.DataSource = culturaActual.DateTimeFormat.DayNames;
            //Formatos y propiedades
            txtFecha.Text = culturaActual.DateTimeFormat.ShortDatePattern;
            txtMoneda.Text = culturaActual.NumberFormat.CurrencySymbol;
            txtSeparadorDecimales.Text =
                      culturaActual.NumberFormat.CurrencyDecimalSeparator;
            txtSeparadorMiles.Text =
                     culturaActual.NumberFormat.CurrencyGroupSeparator;
        }

        private void rbtPeru_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPeru.Checked == true)
            {
                culturaActual = new CultureInfo("es-PE");
                btnCargar_Click(null, null);
            }            
        }
        private void rbtEstadosUnidos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtEstadosUnidos.Checked == true)
            {
                culturaActual = new CultureInfo("en-US");
                btnCargar_Click(null, null);
            }
        }
    }
}
