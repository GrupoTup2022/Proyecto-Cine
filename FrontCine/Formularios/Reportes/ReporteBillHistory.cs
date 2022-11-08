﻿using DataCine.ClasesGenericas;
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
            string url = "https://localhost:7259/api/ReporteBill/bills";

            var resultado = await ClienteSingleton.getinstancia().PostAsync(url,filtrosfechajason);

            tablaBills = JsonConvert.DeserializeObject<List<facturabill>>(resultado);

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("NRO", typeof(Int32));
            dataTable.Columns.Add("Fecha", typeof(DateTime));
            dataTable.Columns.Add("Nombre", typeof(string));
            dataTable.Columns.Add("Precio", typeof(Int32));
            foreach(facturabill f in tablaBills)
            {
                dataTable.Rows.Add(f.NRO,f.Fecha,f.Nombre,f.Precio);
            }

            dataGridView1.DataSource = dataTable;




        }

        private async void ReporteBillHistory_Load(object sender, EventArgs e)
        {
            await CargarCBO(cboformaspago);
        }

        private async Task CargarCBO(ComboBox cbo)
        {
            string url = "https://localhost:7259/api/ReporteBill/formadepagos";
            var data = await ClienteSingleton.getinstancia().GetAsync(url);
            List<object> lst = JsonConvert.DeserializeObject<List<object>>(data);

            cbo.DataSource = lst;
            cbo.ValueMember = "Id";
            cbo.DisplayMember = "Nombre";
        }
    }
}
