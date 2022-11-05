using DataCine.Dominio;

namespace DataCine.Datos.Interfaces
{
    public interface IDaoUsuario
    {
        bool getUsers(string username, string pass); 
    }
}
