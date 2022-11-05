using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI.Models
{
    internal interface ITipoGenerico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
