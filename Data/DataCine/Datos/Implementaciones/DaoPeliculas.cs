using APIRest_G9.Models.PeliculaConteiner;
using DataCine.Datos.Interfaces;
using DataCine.Dominio;
using LibreriaTp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Datos.Implementaciones
{
    public class DaoPeliculas : IDaoPeliculas
    {

        public bool CargarPelicula(Pelicula oPelicula)
        {
            List<Parametro> lParametros = new List<Parametro>();
            lParametros.Add(new Parametro("@titulo_local", oPelicula.Titulo_local));
            lParametros.Add(new Parametro("@titulo_original", oPelicula.Titulo_original));
            lParametros.Add(new Parametro("@descripcion", oPelicula.Descripcion));
            lParametros.Add(new Parametro("@id_pais", oPelicula.pais.Id));
            lParametros.Add(new Parametro("@id_clasificacion", oPelicula.clasificacion.Id));
            lParametros.Add(new Parametro("@fecha_estreno", oPelicula.Fecha_Estreno));
            lParametros.Add(new Parametro("@duracion_min", oPelicula.duracion));
            lParametros.Add(new Parametro("@id_distibuidora", oPelicula.distribuidora.Id));
            lParametros.Add(new Parametro("@id_genero", oPelicula.genero.Id));
            lParametros.Add(new Parametro("@id_directores", oPelicula.director.Id));

            if (HelperDAO.getinstancia().UtilizarProcedimiento("SP_CargarPeliculas", lParametros) > 0)
                return true;
            else
                return false;

        }
    }
}
