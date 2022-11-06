using DataCine.Servicios.Implementacion;
using DataCine.Servicios.Interfaces;
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
        public InsertarPeliculas()
        {
            InitializeComponent();
            service = new PeliculaService();
        }

        private void InsertarPeliculas_Load(object sender, EventArgs e)
        {

        }

        private async void CargarCBO(ComboBox cbo, List<object> lobjetos)
        {
            
        }
    }
}
