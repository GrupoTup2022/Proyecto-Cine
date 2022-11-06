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
    public partial class ConsultarPeliculas : Form
    {
        public ConsultarPeliculas()
        {
            InitializeComponent();
        }

        private void ConsultarPeliculas_Load(object sender, EventArgs e)
        {
            CargarDGVAsync();
        }

        public async Task CargarDGVAsync()
        {
            string url = "https://localhost:7259/api/Peliculas/Peliculas";
            var data = await ClienteSingleton.getinstancia().GetAsync(url);
            List<Pelicula> lst = JsonConvert.DeserializeObject<List<Pelicula>>(data);

            dgvPeliculasActivas.Rows.Clear();
            dgvPeliculasBajas.Rows.Clear();
            foreach (Pelicula p in lst)
            {
                if (p.Baja == 0)
                    dgvPeliculasActivas.Rows.Add(new object[] { p.Id, p.Titulo_local, p.duracion,p.Fecha_Estreno,p.pais.Nombre,p.director.Nombre,p.distribuidora.Nombre, p.clasificacion.Nombre, p.genero.Nombre });
                if (p.Baja == 1)
                    dgvPeliculasBajas.Rows.Add(new object[] { p.Id, p.Titulo_local, p.duracion, p.Fecha_Estreno, p.pais.Nombre, p.director.Nombre, p.distribuidora.Nombre, p.clasificacion.Nombre, p.genero.Nombre });


            }

        }
    }
}
