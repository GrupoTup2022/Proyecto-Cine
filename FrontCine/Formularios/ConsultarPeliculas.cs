﻿using LibreriaTp;
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

        private async void ConsultarPeliculas_Load(object sender, EventArgs e)
        {
            await CargarDGVAsync();
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

        public async Task<bool> DesabilitarPeliculaAsync(int id)
        {
            string url = "https://localhost:7259/api/Peliculas/" + id.ToString();
            var data = await ClienteSingleton.getinstancia().DeleteAsync(url);
            return data == "true";
        }

        private async void dgvPeliculasActivas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvPeliculasActivas.CurrentCell.ColumnIndex == 10)
            {
                EditarPeliculas form = new EditarPeliculas(idPelicula());
                form.Show();
            }



            if (dgvPeliculasActivas.CurrentCell.ColumnIndex == 9)
            {
                if (MessageBox.Show("¿Estas seguro que quieres desabilitar esta pelicula?", "Desabilitar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {    

                    if (await DesabilitarPeliculaAsync(idPelicula()) != null)
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
