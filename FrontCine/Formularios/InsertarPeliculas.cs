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
        Pelicula nueva;

        public InsertarPeliculas()
        {
            InitializeComponent();
            service = new PeliculaService();
            nueva = new Pelicula();
        }

        private async void InsertarPeliculas_Load(object sender, EventArgs e)
        {
            await CargarCBO(cboClasificaciones, "Clasificacion");
            await CargarCBO(cboDirectores, "Directores");
            await CargarCBO(cboGeneros, "Generos");
            await CargarCBO(cboDistribuidoras, "Distribuidora");
            await CargarCBO(cboPaises, "Paises");
            await CargarDGVAsync();
        }

        private async Task CargarCBO(ComboBox cbo, string nombre)
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

            Pais p = new Pais();
            p.Id = Convert.ToInt32(cboPaises.SelectedValue);
            p.Nombre = cboPaises.SelectedText;
            Clasificacion c = new Clasificacion();
            c.Id = Convert.ToInt32(cboClasificaciones.SelectedValue);
            c.Nombre = cboClasificaciones.SelectedText;
            Genero g = new Genero();
            g.Id = Convert.ToInt32(cboGeneros.SelectedValue);
            g.Nombre = cboGeneros.SelectedText;
            Distribuidora dis = new Distribuidora();
            dis.Id = Convert.ToInt32(cboDistribuidoras.SelectedValue);
            dis.Nombre = cboDistribuidoras.SelectedText;
            Director dir = new Director();
            dir.Id = Convert.ToInt32(cboDirectores.SelectedValue);
            dir.Nombre = cboDirectores.SelectedText;

            nueva.pais = p;
            nueva.clasificacion = c;
            nueva.genero = g;
            nueva.distribuidora = dis;
            nueva.director = dir;


            nueva.Titulo_local = txtTitulo.Text;
            nueva.Titulo_original = " ";
            nueva.Descripcion = " ";

            nueva.Fecha_Estreno= dtpEstreno.Value;
            nueva.duracion = Convert.ToInt32(txtDuracion.Text);         
                   

            if (await CargarPeliculaAsync(nueva))
            {
                MessageBox.Show("Se registro correctamente la pelicula");
                await CargarDGVAsync();
            }
            else
            {
                MessageBox.Show("Ha ocrrido un error");
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

        public async Task CargarDGVAsync()
        {
            string url = "https://localhost:7259/api/Peliculas/Peliculas";
            var data = await ClienteSingleton.getinstancia().GetAsync(url);
            List<Pelicula> lst = JsonConvert.DeserializeObject<List<Pelicula>>(data);

            dgvPeliculas.Rows.Clear();
            foreach (Pelicula p in lst)
            {
                if(p.Baja == 0)
                     dgvPeliculas.Rows.Add(new object[] { p.Id, p.Titulo_local, p.duracion, p.clasificacion.Nombre, p.genero.Nombre });
            }

        }

        private void barrasuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void seleccion_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
