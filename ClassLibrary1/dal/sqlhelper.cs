
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.dal
{
    public class sqlhelper
    {

        public static DataSet ExecuteDataSet(string connectionstring, CommandType commandtype, string commandText, SqlParameter[] commandparameter)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand(commandText, con);
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter p in commandparameter)
            {
                cmd.Parameters.Add(p);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }
        public static int ExecuteNonQuery(string connectionstring, CommandType commandtype, string commandText, SqlParameter[] commandparameter)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(commandText, con);
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter p in commandparameter)
            {
                cmd.Parameters.Add(p);
            }
            int retval = cmd.ExecuteNonQuery();
            return retval;
            con.Close();
        }
    }
}
