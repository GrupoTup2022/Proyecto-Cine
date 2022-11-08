using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.ClasesGenericas
{
    public class facturabill
    {
        public int NRO { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }

        public facturabill(int nRO, DateTime fecha, string nombre, int precio)
        {
            NRO = nRO;
            Fecha = fecha;
            Nombre = nombre;
            Precio = precio;
        }
        public facturabill()
        {
            NRO = 0;
            Fecha = DateTime.MinValue;
            Nombre = "";
            Precio = 0;
        }
    }
}
