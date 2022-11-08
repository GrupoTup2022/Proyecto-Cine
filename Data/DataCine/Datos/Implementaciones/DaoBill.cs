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
        public List<facturabill> consultarfacturas(ParametroConsultaBill parame)
        {
            List<facturabill> facturas = new List<facturabill>();
            List<Parametro> parametros = new List<Parametro>();

            Parametro inicio = new Parametro();
            inicio.Name = "@fechainicio";
            inicio.Value = parame.fechainicio;

            Parametro fin = new Parametro();
            fin.Name = "@fechafin";
            fin.Value = parame.fechafin;

            Parametro nombreforma = new Parametro();
            nombreforma.Name = "@nombreforma";
            nombreforma.Value = parame.tipo;

            parametros.Add(inicio);
            parametros.Add(fin);
            parametros.Add(nombreforma);

            DataTable consulta = new DataTable();
            consulta = HelperDAO.getinstancia().ConsultarDB("sp_consultarimportes", parametros);

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
