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

namespace DataCine.Datos.Implementaciones
{
    public class DaoFunciones : IDaoFunciones
    {
        public int AltaFuncion(Funcion funcion)
        {
            List<Parametro> lista_parametros = new List<Parametro>();

            
        }

        public int BajaLogicaFuncion(Funcion funcion)
        {
           
        }
    }
}
