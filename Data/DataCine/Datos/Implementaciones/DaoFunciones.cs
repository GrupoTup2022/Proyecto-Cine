using APIRest_G9.Models.FuncionContainer;
using DataCine.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataCine.Dominio;
using LibreriaTp;
using APIRest_G9.Models.SalaContainer;

namespace DataCine.Datos.Implementaciones
{
    public class DaoFunciones : IDaoFunciones
    {
        public int AltaFuncion(Funcion funcion)
        {
            List<Parametro> lista_parametros = new List<Parametro>();
            lista_parametros.Add(new Parametro("@id_pelicula", funcion.Pelicula.Id));
            lista_parametros.Add(new Parametro("@id_horario", funcion.Horario));
            lista_parametros.Add(new Parametro("@id_audio", funcion.Audio.Id));
            lista_parametros.Add(new Parametro("@id_sala", funcion.Sala.Id));
            lista_parametros.Add(new Parametro("@precio", funcion.Precio));
            lista_parametros.Add(new Parametro("@fecha", funcion.fecha));
            return HelperDAO.getinstancia().UtilizarProcedimiento("SP_AGREGAR_FUNCION", lista_parametros);
        }

        public int BajaLogicaFuncion(Funcion funcion)
        {

           
        }

        public List<Audio> consultarAudios(Audio audio)
        {
            throw new NotImplementedException();
        }

        public List<Pelicula> consultarPeliculas(Pelicula pelicula)
        {
            throw new NotImplementedException();
        }

        public List<Sala> consultarSalas(Sala sala)
        {
            throw new NotImplementedException();
        }

        public List<Horario> consutlarHorarios(Horario horario)
        {
            throw new NotImplementedException();
        }
    }
}
