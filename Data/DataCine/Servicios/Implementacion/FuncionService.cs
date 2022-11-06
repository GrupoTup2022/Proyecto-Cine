using DataCine.Datos.Implementaciones;
using DataCine.Datos.Interfaces;
using DataCine.Servicios.Interfaces;
using LibreriaTp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Servicios.Implementacion
{
    public class FuncionService : IFuncionService
    {
        public IDaoFunciones dao;

        public FuncionService()
        {
            dao = new DaoFunciones();
        }

        public int AltaFuncion(Funcion funcion)
        {
            return dao.AltaFuncion(funcion);
        }

        public int BajaLogicaFuncion(Funcion funcion)
        {
            return dao.BajaLogicaFuncion(funcion);
        }

        public List<Audio> consultarAudios()
        {
            return dao.consultarAudios();
        }

        public List<Funcion> consultarFunciones()
        {
            return dao.consultarFunciones();
        }

        public List<Pelicula> consultarPeliculas()
        {
            return dao.consultarPeliculas();
        }

        public List<Sala> consultarSalas()
        {
            return dao.consultarSalas();
        }

        public List<Horario> consutlarHorarios()
        {
            return dao.consutlarHorarios();
        }
    }
}
