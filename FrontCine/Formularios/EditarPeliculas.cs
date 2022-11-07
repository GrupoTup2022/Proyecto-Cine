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
    public partial class EditarPeliculas : Form
    {
        private int id;

        public EditarPeliculas(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private async void EditarPeliculas_Load(object sender, EventArgs e)
        {       
            await CargarCampos();
            await CargarCombos(cboPaises,"paises");
        }

        

        public async Task CargarCampos()
        {
            string url = "https://localhost:7259/api/Peliculas/Peliculas";
            var data = await ClienteSingleton.getinstancia().GetAsync(url);
            List<Pelicula> lst = JsonConvert.DeserializeObject<List<Pelicula>>(data);

            foreach(Pelicula p in lst)
            {
                if(p.Id == id)
                {
                    txtTitulo.Text = p.Titulo_local.ToString();
                    cboDistribuidoras.SelectedValue = p.distribuidora.Id;
                }
            }

        }
        

        //Carga de combos
        public async Task CargarCombos(ComboBox cbo, string nombre)
        {
            string url = "https://localhost:7259/api/Peliculas/" + nombre;
            var data = await ClienteSingleton.getinstancia().GetAsync(url);
            List<object> lst = JsonConvert.DeserializeObject<List<object>>(data);

            cbo.DataSource = lst;
            cbo.ValueMember = "Id";
            cbo.DisplayMember = "Nombre";
        }
    }
}
