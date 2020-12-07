using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.bal
{
   public abstract class clsabstract
       
    
    {
    #region method
       public abstract DataSet GetDataSet();
       public abstract int InsertDatawithoutoutput();
    #endregion
       #region Registration
       public int Id { get; set; }
       public string Username { get; set; }
       public string Fullname { get; set; }
       public Int64 Phoneno { get; set; }
       public string Address { get; set; }
       public string Emailid { get; set; }
       public string Password { get; set; }
       public string Gender { get; set; }
      
       public int Mode { get; set; }
       #endregion
    }
}
