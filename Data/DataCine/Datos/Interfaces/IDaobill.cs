using DataCine.ClasesGenericas;
using DataCine.Dominio;
using LibreriaTp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Datos.Interfaces
{
    internal interface IDaobill
    {
        List<facturabill> consultarfacturas(List<Parametro> lparametros);
        List<FormaPago> traerformaPagos();
    }
}
