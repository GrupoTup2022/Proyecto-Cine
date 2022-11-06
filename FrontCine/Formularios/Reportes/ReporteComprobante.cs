using LibreriaTp;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontCine.Formularios.Reportes
{
    public partial class ReporteComprobante : Form
    {
        Comprobante comprobante = new Comprobante();
        public ReporteComprobante(Comprobante comprob)
        {
            InitializeComponent();
            this.comprobante = comprob;
        }
        DataTable pagostabla = new DataTable();
        DataTable comprobantetabla = new DataTable();


        private void ReporteComprobante_Load(object sender, EventArgs e)
        {
            pagostabla.Columns.Add("FormaPago", typeof(string));
            pagostabla.Columns.Add("Monto",typeof(double));
            foreach(Pagos c in comprobante.ListaPagos)
            {
                pagostabla.Rows.Add(c.FormaPago, c.Monto);
            }

            comprobantetabla.Columns.Add("Id", typeof(int));
            comprobantetabla.Columns.Add("FormaVenta", typeof(string));
            comprobantetabla.Columns.Add("Fecha",typeof(DateTime));


            reportViewercompro.LocalReport.DataSources.Clear();
            reportViewercompro.LocalReport.DataSources.Add(new ReportDataSource("DataSet1",pagostabla));
            reportViewercompro.LocalReport.DataSources.Add(new ReportDataSource("DataSet2",comprobantetabla));
            reportViewercompro.LocalReport.ReportEmbeddedResource = "FrontCine.Comprobante.rdlc";
            reportViewercompro.RefreshReport();
        }
    }
}
