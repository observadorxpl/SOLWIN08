using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO.Globalizacion
{
    public partial class frmGlobalizacion : Form
    {
        public frmGlobalizacion()
        {
            InitializeComponent();
        }
        List<string> lista = new List<string>();
        void ListarPaises()
        {
            CultureInfo[] paises = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (CultureInfo cultura in paises)
            {
                
                RegionInfo region = new RegionInfo(cultura.LCID);
                if (lista.Contains(region.DisplayName) == false)
                {
                    lista.Add(region.DisplayName);
                }
            }
            lista.Sort();
            cboPaises.DataSource = lista;
        }
        CultureInfo culturaActual = null;

        private void frmGlobalizacion_Load(object sender, EventArgs e)
        {
            //if(tbn)
            //{
            //    culturaActual = CultureInfo.
            //}
            ListarPaises();
            culturaActual = Application.CurrentCulture;
            lstMesesAño.DataSource = culturaActual.DateTimeFormat.MonthNames;
            lstDiasSemana.DataSource = culturaActual.DateTimeFormat.DayNames;
            txtMoneda.Text = culturaActual.NumberFormat.CurrencySymbol;
            txtFecha.Text = culturaActual.DateTimeFormat.ShortDatePattern;
            txtSeparadorDecimales.Text = culturaActual.NumberFormat.CurrencyDecimalSeparator;
            txtSeparadorMiles.Text = culturaActual.NumberFormat.CurrencyGroupSeparator;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarPaises();
            culturaActual = Application.CurrentCulture;
            lstMesesAño.DataSource = culturaActual.DateTimeFormat.MonthNames;
            lstDiasSemana.DataSource = culturaActual.DateTimeFormat.DayNames;
            txtMoneda.Text = culturaActual.NumberFormat.CurrencySymbol;
            txtFecha.Text = culturaActual.DateTimeFormat.ShortDatePattern;
            txtSeparadorDecimales.Text = culturaActual.NumberFormat.CurrencyDecimalSeparator;
            txtSeparadorMiles.Text = culturaActual.NumberFormat.CurrencyGroupSeparator;
        }

        private void btnPeru_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPeru.Checked == true)
            {
                culturaActual = new CultureInfo("es-PE");
                lstMesesAño.DataSource = culturaActual.DateTimeFormat.MonthNames;
                lstDiasSemana.DataSource = culturaActual.DateTimeFormat.DayNames;
                txtMoneda.Text = culturaActual.NumberFormat.CurrencySymbol;
                txtFecha.Text = culturaActual.DateTimeFormat.ShortDatePattern;
                txtSeparadorDecimales.Text = culturaActual.NumberFormat.CurrencyDecimalSeparator;
                txtSeparadorMiles.Text = culturaActual.NumberFormat.CurrencyGroupSeparator;
            }
        }

        private void btnEstadosUnidos_CheckedChanged(object sender, EventArgs e)
        {
            if (btnEstadosUnidos.Checked == true)
            {
                culturaActual = new CultureInfo("en-US");
                lstMesesAño.DataSource = culturaActual.DateTimeFormat.MonthNames;
                lstDiasSemana.DataSource = culturaActual.DateTimeFormat.DayNames;
                txtMoneda.Text = culturaActual.NumberFormat.CurrencySymbol;
                txtFecha.Text = culturaActual.DateTimeFormat.ShortDatePattern;
                txtSeparadorDecimales.Text = culturaActual.NumberFormat.CurrencyDecimalSeparator;
                txtSeparadorMiles.Text = culturaActual.NumberFormat.CurrencyGroupSeparator;

            }
        }

        private void txtMoneda_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMoneda_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
