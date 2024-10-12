using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supply.Orders.Manager.Helpers
{
    public class SQLHelper
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["SOMConnection"].ToString();
        public static int ExceuteNonQuery(string sqlstr, CommandType type, SqlParameter[] parameters)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(sqlstr, con) { CommandType = type };
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            int numrows = 0;
            try
            {
                con.Open();
                numrows = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                ExceptionHelpers.ErrorRegister(ex);
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return numrows;
        }
        public static object ExecuteScalar(string sqlstr, CommandType type, SqlParameter[] parameters)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(sqlstr, con);
            cmd.CommandType = type;
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);
            object result = null;
            try
            {
                con.Open();
                result = cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                ExceptionHelpers.ErrorRegister(ex);
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }

            return result;
        }
        public static SqlDataReader ExecuteReader(string sqlstr, CommandType type, SqlParameter[] parameters)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(sqlstr, con);
            SqlConnection.ClearPool(con);
            cmd.CommandType = type;
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);
            SqlDataReader reader;
            try
            {
                con.Open();
                cmd.CommandTimeout = 300;
                reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (SqlException ex)
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
                ExceptionHelpers.ErrorRegister(ex);
                throw ex;
            }
            return reader;
        }

    }
}

