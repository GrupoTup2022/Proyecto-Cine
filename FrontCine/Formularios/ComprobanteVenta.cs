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
    public partial class ComprobanteVenta : Form
    {
        List<Ticket> tickets = new List<Ticket>();
        List<Funcion> funciones = new List<Funcion>();
        List<Funcion> funciones2 = new List<Funcion>();
        List<Pelicula> pelis = new List<Pelicula>();
        List<Audio> audios = new List<Audio>();
        List<Horario> horarios = new List<Horario>();
        List<Sala> salas = new List<Sala>();
        List<Promo> promos = new List<Promo>();
        Funcion funcion = new Funcion();

        Funcion f = new Funcion();
        public List<Pagos> PagosList { get; set; }
        double monto;
        public ComprobanteVenta()
        {
            InitializeComponent();
            CargarComboPromosAsync();
            DeshabilitarTodo();
            PagosList = new List<Pagos>();
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
        public async Task recuperarFunciones(string date)
        {
            string url = "https://localhost:7259/api/Comprobantes/Funciones?Fecha=" + date;
            var data = await ClienteSingleton.getinstancia().GetAsync(url);
            List<Funcion> lst = JsonConvert.DeserializeObject<List<Funcion>>(data);
            funciones = lst;
        }
        public async Task recuperarPromos()
        {
            string url = "https://localhost:7259/api/Comprobantes/Promos";
            var data = await ClienteSingleton.getinstancia().GetAsync(url);
            List<Promo> lst = JsonConvert.DeserializeObject<List<Promo>>(data);
            promos = lst;
        }
        private async Task CargarComboPromosAsync()
        {
            await recuperarPromos();
            cbo_promos.DataSource = promos;
            cbo_promos.DisplayMember = "Descripcion";
            cbo_promos.ValueMember = "Id";
        }
        private async void dtp_fecha_ValueChangedAsync(object sender, EventArgs e)
        {
            await recuperarFunciones(dtp_fecha.Value.ToString("yyyy-MM-dd"));
            CargarComboPeli();
            DeshabilitarTodo();
            cbo_peli.SelectedIndex = -1;
            cbo_peli.Enabled = true;
            cbo_audio.SelectedIndex = -1;
            cbo_horario.SelectedIndex = -1;
            cbo_sala.SelectedIndex = -1;
        }
        private void DeshabilitarTodo()
        {
            cbo_peli.Enabled = false;
            cbo_audio.Enabled = false;
            cbo_horario.Enabled = false;
            cbo_sala.Enabled = false;
        }

        private void CargarComboPeli()
        {
            if (funciones.Count > 0)
            {
                bool flag;
                pelis.Clear();
                foreach (Funcion f in funciones)
                {
                    flag = true;
                    foreach (Pelicula pelicula in pelis)
                    {
                        if (pelicula.Id == f.Pelicula.Id)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                        pelis.Add(f.Pelicula);
                }
                cbo_peli.DataSource = null;
                cbo_peli.DataSource = pelis;
                cbo_peli.ValueMember = "Id";
                cbo_peli.DisplayMember = "Titulo_local";
            }
        }
        private void CargarComboIdioma()
        {
            bool flag;
            audios.Clear();
            funciones2.Clear();
            foreach (Funcion f in funciones)
            {
                if (f.Pelicula.Id == (int)cbo_peli.SelectedValue)
                {
                    funciones2.Add(f);
                    flag = true;
                    foreach (Audio audio in audios)
                    {
                        if (audio.Id == f.Audio.Id)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                        audios.Add(f.Audio);
                }
            }
            cbo_audio.DataSource = null;
            cbo_audio.DataSource = audios;
            cbo_audio.ValueMember = "Id";
            cbo_audio.DisplayMember = "Nombre";
        }
        private void CargarComboHorario()
        {
            bool flag;
            funciones.Clear();
            foreach (Funcion f in funciones2)
            {
                if (f.Audio.Id == (int)cbo_audio.SelectedValue)
                {
                    funciones.Add(f);
                    flag = true;
                    foreach (Horario horario in horarios)
                    {
                        if (horario.Id == f.Horario.Id)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                        horarios.Add(f.Horario);
                }
            }
            cbo_horario.DataSource = null;
            cbo_horario.DataSource = horarios;
            cbo_horario.ValueMember = "Id";
            cbo_horario.DisplayMember = "Nombre";
        }

        private void CargarComboSala()
        {
            bool flag;
            funciones2.Clear();
            foreach (Funcion f in funciones)
            {
                if (f.Horario.Id == (int)cbo_horario.SelectedValue)
                {
                    funciones2.Add(f);
                    flag = true;
                    foreach (Sala sala in salas)
                    {
                        if (sala.Id == f.Sala.Id)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                        salas.Add(f.Sala);
                }
            }
            cbo_sala.DataSource = null;
            cbo_sala.DataSource = salas;
            cbo_sala.ValueMember = "Id";
            cbo_sala.DisplayMember = "Nombre";
        }

        private void cbo_peli_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbo_peli.Enabled)
            {
                CargarComboIdioma();
                DeshabilitarTodo();
                cbo_peli.Enabled = true;
                cbo_audio.SelectedIndex = -1;
                cbo_audio.Enabled = true;
                cbo_horario.SelectedIndex = -1;
                cbo_sala.SelectedIndex = -1;
            }
        }

        private void cbo_audio_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbo_audio.Enabled)
            {
                CargarComboHorario();
                DeshabilitarTodo();
                cbo_peli.Enabled = true;
                cbo_audio.Enabled = true;
                cbo_horario.SelectedIndex = -1;
                cbo_horario.Enabled = true;
                cbo_sala.SelectedIndex = -1;
            }
        }

        private void cbo_horario_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbo_horario.Enabled)
            {
                CargarComboSala();
                cbo_sala.Enabled = true;
                cbo_sala.SelectedIndex = -1;
            }
        }

        private void cbo_sala_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cbo_promos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_butacas_Click(object sender, EventArgs e)
        {
            foreach (Funcion f in funciones2)
            {
                if (f.Sala.Id == (int)cbo_sala.SelectedValue)
                {
                    funcion = f;
                    break;
                }
            }

            ButacasForm pagos = new ButacasForm(tickets, funcion);
            pagos.Show();
        }
    }
}
