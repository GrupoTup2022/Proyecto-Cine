using LibreriaTp;
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
    public partial class ComprobanteVenta : Form
    {
        List<Ticket> tickets;
        public List<Pagos> PagosList { get; set; }
        double monto;
        public ComprobanteVenta()
        {
            InitializeComponent();
        }

        private void btn_pagos_Click(object sender, EventArgs e)
        {
            foreach (Ticket t in tickets)
            {
                monto = (t.Funcion.Precio * t.Promo.Porcentaje / 100) + monto;
            }
            PagosForm pagos = new PagosForm(monto, PagosList);
            pagos.Show();
        }
    }
}
