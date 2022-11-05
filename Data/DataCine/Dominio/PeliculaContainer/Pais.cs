using DataAPI.Models;

namespace APIRest_G9.Models.PeliculaConteiner
{
    public class Pais : ITipoGenerico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
