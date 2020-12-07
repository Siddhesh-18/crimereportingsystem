using ClassLibrary1.connection;
using ClassLibrary1.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.bal
{
    public class clsregistration : clsabstract
    {
        public override DataSet GetDataSet()
        {
            try
            {
                SqlParameter[] q = new SqlParameter[9];
                q[0] = new SqlParameter("@Id", Id);
                q[1] = new SqlParameter("@Username", Username);
                q[2] = new SqlParameter("@Fullname", Fullname);
                q[3] = new SqlParameter("@Phoneno", Phoneno);
                q[4] = new SqlParameter("@Address", Address);
                q[5] = new SqlParameter("@Emailid", Emailid);
                q[6] = new SqlParameter("@Password", Password);
                q[7] = new SqlParameter("@Gender", Gender);
                q[8] = new SqlParameter("@Mode", Mode);
                return sqlhelper.ExecuteDataSet(clsconnection.connectionstring, CommandType.StoredProcedure, "tblcrime_sp", q);
            }
            catch (Exception ex)
            {
                DataSet ds = new DataSet();
                return ds;
            }
        }
        public override int InsertDatawithoutoutput()
        {
            try
            {
                SqlParameter[] q = new SqlParameter[9];
                q[0] = new SqlParameter("@Id", Id);
                q[1] = new SqlParameter("@Username", Username);
                q[2] = new SqlParameter("@Fullname", Fullname);
                q[3] = new SqlParameter("@Phoneno", Phoneno);
                q[4] = new SqlParameter("@Address", Address);
                q[5] = new SqlParameter("@Emailid", Emailid);
                q[6] = new SqlParameter("@Password", Password);
                q[7] = new SqlParameter("@Gender", Gender);
                q[8] = new SqlParameter("@Mode", Mode);
                return sqlhelper.ExecuteNonQuery(clsconnection.connectionstring, CommandType.StoredProcedure, "tblcrime_sp", q);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
