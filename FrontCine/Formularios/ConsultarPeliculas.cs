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

        public async Task<bool> DesabilitarPeliculaAsync(Pelicula oPelicula)
        {
            string url = "https://localhost:7259/pelicula";
            string peliculaJason = JsonConvert.SerializeObject(oPelicula);
            var data = await ClienteSingleton.getinstancia().PostAsync(url, peliculaJason);
            return data == "true";
        }

        private async void dgvPeliculasActivas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Pelicula pelicula = new Pelicula();
            pelicula.Id = idPelicula();
            pelicula.Baja = 0;

            if (dgvPeliculasActivas.CurrentCell.ColumnIndex == 9)
            {
                if (MessageBox.Show("¿Estas seguro que quieres desabilitar esta pelicula?", "Desabilitar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    pelicula.Baja = 1;  
                    if (await DesabilitarPeliculaAsync(pelicula) != null)
                    {
                        MessageBox.Show("Se desabilito correctamente");
                        dgvPeliculasActivas.Rows.Clear();
                        CargarDGVAsync();
                    }
                    else
                    {
                        MessageBox.Show("Ah ocurrido un error");
                    }                                  
                                  
                 
                }
            }

        }

        public int idPelicula()
        {
            int id = 0;
            id = Convert.ToInt32(dgvPeliculasActivas.CurrentRow.Cells[0].Value.ToString());
            return id;
        }

        
    }
}
