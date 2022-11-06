﻿using LibreriaTp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Servicios.Interfaces
{
    public interface IComprobanteService
    {
        List<Funcion> ConsultarFunciones(DateTime fecha);
        bool CargarComprobante(Comprobante comprobante);
        List<TipoGenerico> ConsultarButacas(int funcionID);
    }
}