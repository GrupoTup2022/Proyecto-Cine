using LibreriaTp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Servicios.Interfaces
{
    public interface IFuncionService
    {
        int AltaFuncion(Funcion funcion);
        int BajaLogicaFuncion(Funcion funcion);
        List<Pelicula> consultarPeliculas();
        List<Horario> consutlarHorarios();
        List<Audio> consultarAudios();
        List<Sala> consultarSalas();
        List<Funcion> consultarFunciones();
    }
}
