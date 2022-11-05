using DataCine.ClasesGenericas;
using DataCine.Datos;
using DataCine.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Servicios.Implementacion
{
    public class Servicio : IService
    {
        public List<TIcketxSala> traerticketsxsala()
        {
            DataTable dt = new DataTable();
            List<TIcketxSala> list = new List<TIcketxSala>();
            dt = HelperDAO.getinstancia().traertablacomun("select * from v_cantidadentradathisyear");
            foreach (DataRow t in dt.Rows)
            {
                TIcketxSala tktsala = new TIcketxSala(int.Parse(t["Tickets"].ToString()), t["Sala"].ToString());
                list.Add(tktsala);
            }
            return list;

        }
    }
}
