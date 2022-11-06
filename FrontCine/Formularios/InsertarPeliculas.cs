using DataCine.Servicios.Implementacion;
using DataCine.Servicios.Interfaces;
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
    public partial class InsertarPeliculas : Form
    {
        private IPeliculasService service;
        private Pelicula pelicula;

        public InsertarPeliculas()
        {
            InitializeComponent();
            service = new PeliculaService();
            pelicula = new Pelicula();
        }

        private void InsertarPeliculas_Load(object sender, EventArgs e)
        {
            CargarCBO(cboClasificaciones, "Clasificacion");
            CargarCBO(cboDirectores, "Directores");
            CargarCBO(cboGeneros, "Generos");
            CargarCBO(cboDistribuidoras, "Distribuidora");
            CargarCBO(cboPaises, "Paises");
        }

        private async void CargarCBO(ComboBox cbo, string nombre)
        {
            string url = "https://localhost:7259/api/Peliculas/" + nombre;
            var data = await ClienteSingleton.getinstancia().GetAsync(url);
            List<object> lst = JsonConvert.DeserializeObject<List<object>>(data);

            cbo.DataSource = lst;
            cbo.ValueMember = "Id";
            cbo.DisplayMember = "Nombre";
        }

        public async Task<bool> CargarPeliculaAsync(Pelicula pelicula)
        {
            string url = "https://localhost:7259/pelicula";
            string cuentaJason = JsonConvert.SerializeObject(pelicula);
            var data = await ClienteSingleton.getinstancia().PostAsync(url,cuentaJason);
            return data == "true";
        }

        public async void ConfirmarPelicula()
        {
            Pelicula p = new Pelicula();
            p.Titulo_local = txtTitulo.Text;
            p.Titulo_original = null;
            p.Descripcion = null;
            p.pais.Id = Convert.ToInt32(cboPaises.SelectedValue);
            p.clasificacion.Id = Convert.ToInt32(cboClasificaciones.SelectedValue);
            p.Fecha_Estreno= Convert.ToDateTime(dtpEstreno.Value);
            p.duracion = Convert.ToInt32(txtDuracion.Text);            
            p.distribuidora.Id = Convert.ToInt32(cboDistribuidoras.SelectedValue);
            p.genero.Id = Convert.ToInt32(cboGeneros.SelectedValue);
            p.director.Id = Convert.ToInt32(cboDirectores.SelectedValue);
            p.Baja = 0;


            if(await CargarPeliculaAsync(p))
            {
                MessageBox.Show("Se registro correctamente la pelicula");  
            }
          
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfirmarPelicula();
        }
    }
}
