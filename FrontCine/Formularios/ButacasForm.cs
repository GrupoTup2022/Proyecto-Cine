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
    public partial class ButacasForm : Form
    {
        List<TipoGenerico> butacaslista;
        string a;
        public ButacasForm(List<Ticket> ticket, Funcion funcion)
        {
            InitializeComponent();
            cargarButacas(funcion);
        }

        private async void cargarButacas(Funcion funcion)
        {
            await recuperarButacas(funcion.Id.ToString());
            foreach (TipoGenerico t in butacaslista)
            {
                if (t.Nombre != "")
                    a = "aa";
            }
        }
        public async Task recuperarButacas(string id)
        {
            string url = "https://localhost:7259/api/Comprobantes/Butacas?ID=" + id;
            var data = await ClienteSingleton.getinstancia().GetAsync(url);
            List<TipoGenerico> lst = JsonConvert.DeserializeObject<List<TipoGenerico>>(data);
            butacaslista = lst;
        }


        private void pictureBox31_Click(object sender, EventArgs e)
        {

        }

        private void rojo6_Click(object sender, EventArgs e)
        {

        }
    }
}
