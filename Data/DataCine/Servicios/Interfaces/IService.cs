﻿using DataCine.ClasesGenericas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Servicios.Interfaces
{
    public interface IService
    {
        List<TIcketxSala> traerticketsxsala();
    }
}
