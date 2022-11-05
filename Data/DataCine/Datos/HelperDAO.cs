using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using APIRest_G9.Models.ComprobanteContainer;
using DataCine.Dominio;

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
            if (instancia == null)
                instancia = new HelperDAO();
            return instancia;
        }
        public SqlConnection ObtenerConexion()
        {
            return cnn;
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

        public bool altaTicket(Ticket ticket)
        {
            bool result = true;
            SqlTransaction t = null;

            try
            {
                //Transaccion M/D Tickets
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmmMaster = new SqlCommand("SP_INSERTAR_TICKETS", cnn, t);
                cmmMaster.CommandType = CommandType.StoredProcedure;

                //Agrego parametros
                cmmMaster.Parameters.AddWithValue("@id_funcion", ticket.Funcion.Id);
                cmmMaster.Parameters.AddWithValue("@id_butaca", ticket.Butaca.Id);
                cmmMaster.Parameters.AddWithValue("@id_comprobante", ticket.Comprobante.Id);
                cmmMaster.Parameters.AddWithValue("@id_promo", ticket.Promo.Id);

                //Parametro de salida con numero
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@nro_ticket";
                param.Direction = ParameterDirection.Output;

                cmmMaster.Parameters.Add(param);

                cmmMaster.ExecuteNonQuery();
                int num = (int)param.Value;

            }




         }

        public int UtilizarProcedimiento(string SP, List<Parametro> lParametros)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            int filasAfectadas = 0;
            try
            {
                cnn.ConnectionString = connection;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = SP;
                cmd.Parameters.Clear();
                foreach (Parametro p in lParametros)
                {
                    cmd.Parameters.AddWithValue(p.Name, p.Value);
                }
                filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas;
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                cnn.Close();
            }
        }

    }
}
