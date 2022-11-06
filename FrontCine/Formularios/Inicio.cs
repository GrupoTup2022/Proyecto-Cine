using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FrontCine.Formularios.Reportes;
using LibreriaTp;

namespace ReportesCine.Formularios
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento mouse para poder mover la ventana que viene fijo por defecto al quitar border style
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 161;

        private const int HTCAPTION = 2;

        private void moverForm(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        protected override void WndProc(ref Message m)
        {
            const int codigo = 0x0083;
            if(m.Msg == codigo && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }
        /// <summary>
        /// Termina el codigo de ajuste de ventana para moverla
        /// </summary>

        ///CODIGO PARA ABRIR FORM HIJAS DE LOS BOTONES DE INICIO
        ///

        private void abrirformularios(object formu)
        {
            if(this.panelprincipal.Controls.Count>0)
                this.panelprincipal.Controls.RemoveAt(0);
            Form f = formu as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelprincipal.Controls.Add(f);
            this.panelprincipal.Tag= f;
            f.Show();
        }
        /// FINALIZA CODIGO PARA ABRIR FORM HIJAS DE LOS BOTONES DE INICIO
        ///
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnrestaurar.Visible = true;
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible=false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            moverForm(e);
        }

        private void btnestadisticas_Click(object sender, EventArgs e)
        {
            submenuestadisticas.Visible = true;
        }

        private void btnreporteventa_Click(object sender, EventArgs e)
        {
            submenuestadisticas.Visible=false;
            abrirformularios(new ReporteForm());

            
        }

        private void btnreportesala_Click(object sender, EventArgs e)
        {
            Pagos pago = new Pagos();
            pago.Monto = 50;
            FormaPago formaPago = new FormaPago();
            formaPago.Id = 1;
            formaPago.Nombre = "Efectivo";
            pago.FormaPago = formaPago;
            FormaVenta formaven = new FormaVenta();
            formaven.Id = 2;
            formaven.Nombre = "TARJETA DE CREDITO";
            Comprobante compro = new Comprobante();
            compro.Id = 1;
            compro.AgregarPago(pago);
            compro.FormaVenta = formaven;
            compro.Fecha = DateTime.Today;
            Ticket ticket = new Ticket();


            submenuestadisticas.Visible = false;
            //ReporteComprobante formcompro = new ReporteComprobante(new LibreriaTp.Comprobante());
            //formcompro.Show();

            abrirformularios(new ReporteComprobante(compro));
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text=DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToShortDateString();
        }

        private void lblfecha_Click(object sender, EventArgs e)
        {

        }
    }
}
