using APIRest_G9.Models.PeliculaConteiner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Datos.Interfaces
{
    public interface IDaoPeliculas
    {
        bool CargarPelicula(Pelicula oPelicula); 

    }
}
