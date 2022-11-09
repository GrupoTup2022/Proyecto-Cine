using LibreriaTp;
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

namespace FrontCine.Formularios
{

    public partial class PagosForm : Form
    {
        public List<Pagos> PagosList { get; set; }
        public double monto { get; set; }
        public double restante { get; set; }
        public ComprobanteVenta comprobanteVenta { get; set; }
        public PagosForm(double monto, List<Pagos> PagosList)
        {
            this.monto = monto;
            this.PagosList = PagosList;
            InitializeComponent();
            CargarFormasPago();
            cargarDGV();
            lbl_total.Text = monto.ToString();
            restante = Restante();
        }
        private void cargarDGV()
        {
            dgv_lista.Rows.Clear();
            foreach (Pagos pagos in PagosList)
            {
                dgv_lista.Rows.Add(pagos.FormaPago.Nombre, pagos.Monto);
            }
        }
        private double Restante()
        {
            double resta = monto;
            foreach (Pagos pagos in PagosList)
            {
                resta = resta - pagos.Monto;
            }
            lbl_restante.Text = resta.ToString();
            restante = resta;
            return resta;
        }

        private async void CargarFormasPago()
        {
            cb_fp.DataSource = await recuperarFormasPago();
            cb_fp.ValueMember = "Id";
            cb_fp.DisplayMember = "Nombre";
        }

        public async Task<List<FormaPago>> recuperarFormasPago()
        {
            string url = "https://localhost:7259/api/Comprobantes/FormasPago";
            var data = await ClienteSingleton.getinstancia().GetAsync(url);
            List<FormaPago> lst = JsonConvert.DeserializeObject<List<FormaPago>>(data);
            return lst;
        }



        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if(Restante()- Convert.ToDouble(tb_monto.Text)>=0)
            { 
            FormaPago fp = new FormaPago();
            fp.Id = Convert.ToInt32(cb_fp.SelectedValue);
            fp.Nombre = cb_fp.Text;
            Pagos pagos = new Pagos();
            pagos.FormaPago = fp;
            pagos.Monto = Convert.ToDouble(tb_monto.Text);
            dgv_lista.Rows.Add(fp.Nombre, pagos.Monto);
            PagosList.Add(pagos);
            Restante();
            }
            else
                MessageBox.Show("No se puede insertar ese monto");
        }

        private void btn_terminar_Click(object sender, EventArgs e)
        {
            Restante();
            if (restante == 0)
            {
                this.comprobanteVenta.habilitarTerminar();
                MessageBox.Show("Se completó correctamente el pago");
                this.Close();
            }
            else
                MessageBox.Show("No se completó el monto");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
