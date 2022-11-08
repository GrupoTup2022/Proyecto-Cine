using DataCine.ClasesGenericas;
using DataCine.Datos.Interfaces;
using DataCine.Dominio;
using LibreriaTp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Datos.Implementaciones
{
    internal class DaoBill : IDaobill
    {
        public List<facturabill> consultarfacturas(List<Parametro> lparam)
        {
            List<facturabill> facturas = new List<facturabill>();
            

            DataTable consulta = new DataTable();
            consulta = HelperDAO.getinstancia().ConsultarDB("sp_consultarimportes", lparam);

            foreach (DataRow fila in consulta.Rows)
            {
                facturabill factura = new facturabill();
                factura.NRO = int.Parse(fila["NRO"].ToString());
                factura.Fecha = Convert.ToDateTime(fila["Fecha"].ToString());
                factura.Nombre = fila["Nombre"].ToString();
                factura.Precio = int.Parse(fila["Precio"].ToString());
                facturas.Add(factura);
            }


            return facturas;
        }

        public List<FormaPago> traerformaPagos()
        {
            
            
                List<FormaPago> lformapagos = new List<FormaPago>();
            DataTable dt = HelperDAO.getinstancia().traertablacomun("select * from Formas_pago");

                foreach (DataRow row in dt.Rows)
                {
                    FormaPago formapago = new FormaPago();
                    formapago.Id = Convert.ToInt32(row[0].ToString());
                    formapago.Nombre = row[1].ToString();
                    lformapagos.Add(formapago);
                }
                return lformapagos;
            
        }
    }
}
