using DataAPI.Models;

namespace APIRest_G9.Models.SalaContainer
{
    public class TipoSala : ITipoGenerico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

    }
}
