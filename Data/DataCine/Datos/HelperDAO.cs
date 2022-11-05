using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataCine.Datos
{
    public class HelperDAO
    {
        private static HelperDAO instancia;
        private SqlConnection cnn;
        private string connection = @"d29ya3N0YXRpb24gaWQ9REJUcExhYi5tc3NxbC5zb21lZS5jb207cGFja2V0IHNpemU9NDA5Njt1c2VyIGlkPUx1Y2FzMjQ4NjVfU1FMTG9naW5fMTtwd2Q9aHVldm9kdXJvMTM7ZGF0YSBzb3VyY2U9REJUcExhYi5tc3NxbC5zb21lZS5jb207cGVyc2lzdCBzZWN1cml0eSBpbmZvPUZhbHNlO2luaXRpYWwgY2F0YWxvZz1EQlRwTGFi";

        private HelperDAO()
        {
            cnn = new SqlConnection(System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(connection)));
        }

        public static HelperDAO getinstancia()
        {
            if(instancia == null)
                instancia = new HelperDAO();
            return instancia;
        }
        public DataTable traertablacomun(string consulta)
        {
            DataTable tabla = new DataTable();

            cnn.Open();
            SqlCommand cmd = new SqlCommand(consulta);
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }

        

    }
}
