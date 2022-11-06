using DataCine.Datos.Interfaces;
using DataCine.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace DataCine.Datos.Implementaciones
{
    public class DaoUsuarios : IDaoUsuario
    {
        public bool getUsers(string username, string pass)
        {
            List<Parametro> lparam = new List<Parametro>();
            lparam.Add(new Parametro("@user",username));
            lparam.Add(new Parametro("@pass", pass));

            if (HelperDAO.getinstancia().UtilizarProcedimiento("SP_COMPARAR_USUARIO", lparam) > 0)
            {
                return true;
            } 
            return false;
        }
    }
}
