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
    public class clscomplaint : abscomplaint
    {
        public override System.Data.DataSet GetDataSet()
        {
            try
            {
                SqlParameter[] q = new SqlParameter[6];
                q[0] = new SqlParameter("@ComplaintNo", ComplaintNo);
                q[1] = new SqlParameter("@ID", ID);
                q[2] = new SqlParameter("@ComplaintFor", ComplaintFor);

                q[3] = new SqlParameter("@Reason", Reason);
                q[4] = new SqlParameter("@Date", Date);

                q[5] = new SqlParameter("@Mode", Mode);
                return sqlhelper.ExecuteDataSet(clsconnection.connectionstring, CommandType.StoredProcedure, "tblcomplaint_sp", q);
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
                SqlParameter[] q = new SqlParameter[6];
                q[0] = new SqlParameter("@ComplaintNo", ComplaintNo);
                q[1] = new SqlParameter("@ID",ID);
                q[2] = new SqlParameter("@ComplaintFor", ComplaintFor);

                q[3] = new SqlParameter("@Reason",Reason);
                q[4] = new SqlParameter("@Date", Date);
                
                q[5] = new SqlParameter("@Mode", Mode);
                return sqlhelper.ExecuteNonQuery(clsconnection.connectionstring, CommandType.StoredProcedure, "tblcomplaint_sp", q);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
