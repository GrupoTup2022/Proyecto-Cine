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
    }
}
