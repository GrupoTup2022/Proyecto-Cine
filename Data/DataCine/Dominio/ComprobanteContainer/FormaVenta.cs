using DataAPI.Models;

namespace APIRest_G9.Models.ComprobanteContainer
{
    public class FormaVenta : ITipoGenerico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
