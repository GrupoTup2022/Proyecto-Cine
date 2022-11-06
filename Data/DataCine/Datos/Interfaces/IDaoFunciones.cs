
using LibreriaTp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Datos.Interfaces
{
    public interface IDaoFunciones
    {
        int AltaFuncion(Funcion funcion);
        int BajaLogicaFuncion(Funcion funcion);
        List<Pelicula> consultarPeliculas(Pelicula pelicula);
        List<Horario> consutlarHorarios(Horario horario);
        List<Audio> consultarAudios(Audio audio);
        List<Sala> consultarSalas(Sala sala);
        List<Funcion> consultarFunciones();
    }
}
