using DataAPI.Models;

namespace APIRest_G9.Models.FuncionContainer
{
    public class Horario : ITipoGenerico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
