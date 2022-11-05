using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataCine.Dominio;
using LibreriaTp;

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

        public bool altaComprobante(Comprobante comprobante)
        {
            bool result = true;
            SqlTransaction t = null;

            try
            {
                //Transaccion M/D Tickets
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmmMaster = new SqlCommand("SP_INSERTAR_COMPROBANTE", cnn, t);
                cmmMaster.CommandType = CommandType.StoredProcedure;

                //Agrego parametros
                cmmMaster.Parameters.AddWithValue("@id_formaVenta",comprobante.FormaVenta);
                cmmMaster.Parameters.AddWithValue("@fecha", comprobante.Fecha);

                SqlParameter param = new SqlParameter("@nroComprobante", DbType.Int32);
                param.Direction = ParameterDirection.Output;
                cmmMaster.Parameters.Add(param);

                cmmMaster.ExecuteNonQuery();

                comprobante.Id = (int)param.Value;

                for (int i = 0; i < comprobante.ltickets.Count; i++)
                {
                    SqlCommand cmmTicket = new SqlCommand("SP_INSERTAR_TICKET", cnn, t);

                    cmmTicket.CommandType = CommandType.StoredProcedure;
                    cmmTicket.Parameters.AddWithValue("@id_funcion", comprobante.ltickets[i].Funcion.Id);
                    cmmTicket.Parameters.AddWithValue("@id_butaca", comprobante.ltickets[i].Butaca.Id);
                    cmmTicket.Parameters.AddWithValue("@id_comprobante", comprobante.Id);
                    cmmTicket.Parameters.AddWithValue("@id_promo", comprobante.ltickets[i].Promo.Id);

                    SqlParameter Tparam = new SqlParameter();
                    Tparam.ParameterName = "@nro_ticket";
                    Tparam.Direction = ParameterDirection.Output;
                    Tparam.DbType = DbType.Int32;
                    cmmTicket.Parameters.Add(Tparam);
                    cmmTicket.ExecuteNonQuery();

                    comprobante.ltickets[i].NroTicket = (int)Tparam.Value;

                }

                /*
                for (int i = 0; i < comprobante.FormaPagos.Count; i++)
                {
                    SqlCommand cmmFPagos = new SqlCommand("SP_INSERTAR_FPAGO", cnn, t);

                    cmmFPagos.CommandType = CommandType.StoredProcedure;
                    cmmFPagos.Parameters.AddWithValue("@id_formaPago", comprobante.FormaPagos[i].Id);
                    cmmFPagos.Parameters.AddWithValue("@formaPago", comprobante.FormaPagos[i].Nombre);

                    cmmFPagos.ExecuteNonQuery();

                }
                */



                t.Commit();
            }

            catch (Exception ex)
            {
                t.Rollback();
                result = false;
                //throw ex;
            }

            finally 
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            return result;

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
