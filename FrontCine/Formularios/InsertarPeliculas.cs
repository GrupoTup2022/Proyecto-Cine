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
        private Pelicula nueva;

        public InsertarPeliculas()
        {
            InitializeComponent();
            service = new PeliculaService();
            nueva = new Pelicula();
        }

        private void InsertarPeliculas_Load(object sender, EventArgs e)
        {
            CargarCBO(cboClasificaciones, "Clasificacion");
            CargarCBO(cboDirectores, "Directores");
            CargarCBO(cboGeneros, "Generos");
            CargarCBO(cboDistribuidoras, "Distribuidora");
            CargarCBO(cboPaises, "Paises");
            CargarDGVAsync();
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
              
        public async void ConfirmarPelicula()
        {
            nueva.Titulo_local = txtTitulo.Text;
            nueva.Titulo_original = string.Empty;
            nueva.Descripcion = string.Empty;
            nueva.pais.Id = Convert.ToInt32(cboPaises.SelectedValue);
            nueva.clasificacion.Id = Convert.ToInt32(cboClasificaciones.SelectedValue);
            nueva.Fecha_Estreno= dtpEstreno.Value;
            nueva.duracion = Convert.ToInt32(txtDuracion.Text);            
            nueva.distribuidora.Id = Convert.ToInt32(cboDistribuidoras.SelectedValue);
            nueva.genero.Id = Convert.ToInt32(cboGeneros.SelectedValue);
            nueva.director.Id = Convert.ToInt32(cboDirectores.SelectedValue);
            nueva.Baja = 0;
            

            if ( await CargarPeliculaAsync(nueva))
            {
                MessageBox.Show("Se registro correctamente la pelicula");
            }
            else
            {
                MessageBox.Show("Ah ocrrido un error");
            }

        }

        public async Task<bool> CargarPeliculaAsync(Pelicula pelicula)
        {
            string url = "https://localhost:7259/pelicula";
            string peliculaJason = JsonConvert.SerializeObject(pelicula);            
            var data = await ClienteSingleton.getinstancia().PostAsync(url, peliculaJason);
            return data == "true";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfirmarPelicula();
        }

        
    }
}
