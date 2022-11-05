using APIRest_G9.Models.PeliculaContainer;
using APIRest_G9.Models.PeliculaConteiner;
using LibreriaTp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Datos.Interfaces
{
    public interface IDaoPeliculas
    {
        List<Pais> ObtenerPaises();
        List<Clasificacion> ObtenerClasificaciones();
        List<Distribuidora> CargarDistribuidora();
        List<Genero> ObtenerGeneros();
        List<Director> ObtenerDirectores();
        bool CargarPelicula(Pelicula oPelicula); 

    }
}
