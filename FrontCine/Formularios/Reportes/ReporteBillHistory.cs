using DataCine.ClasesGenericas;
using DataCine.Dominio;
using Newtonsoft.Json;
using ReportesCine.Cliente;
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
    public partial class ReporteBillHistory : Form
    {
        public ReporteBillHistory()
        {
            InitializeComponent();
        }

        private async void btnconsultar_Click(object sender, EventArgs e)
        {
            List<Parametro> parametros = new List<Parametro>();
            
            Parametro inicio = new Parametro();
            inicio.Name = "@fechainicio"; 
            inicio.Value = dtpinicio.Value.ToShortDateString();
            
            Parametro fin = new Parametro();
            fin.Name = "@fechafin";
            fin.Value = dtpfin.Value.ToShortDateString();

            Parametro nombreforma = new Parametro();
            nombreforma.Name = "@nombreforma";
            nombreforma.Value = cboformaspago.Text;

            parametros.Add(inicio);
            parametros.Add(fin);
            parametros.Add(nombreforma);

            List<facturabill> tablaBills = null;

            string filtrosfechajason = JsonConvert.SerializeObject(parametros);
            string url = "";

            var resultado = await ClienteSingleton.getinstancia().PostAsync(url,filtrosfechajason);

            tablaBills = JsonConvert.DeserializeObject<List<facturabill>>(resultado);






        }

        private void ReporteBillHistory_Load(object sender, EventArgs e)
        {
            cargarcomboformaspago();
        }

        private void cargarcomboformaspago()
        {

            cboformaspago.DataSource=;
        }
    }
}
