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
        List<Pelicula> ObtenerPeliculas();
        bool CargarPelicula(Pelicula oPelicula);
        bool Acciones(int id, int baja);

    }
}
