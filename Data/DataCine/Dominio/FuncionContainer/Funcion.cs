using APIRest_G9.Models.PeliculaConteiner;

namespace APIRest_G9.Models.FuncionContainer
{
    public class Funcion
    {

        public int Id { get; set; }
        public Pelicula Pelicula { get; set; }
        public Horario Horario { get; set; }
        public Audio Audio { get; set; }
        public SalaContainer.Sala Sala {get; set;}
        public double Precio { get; set; }
    }
}
