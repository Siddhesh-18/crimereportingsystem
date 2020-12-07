using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.bal
{
   public abstract class abscomplaint
    {
    #region method
       public abstract DataSet GetDataSet();
       public abstract int InsertDatawithoutoutput();
    #endregion
       #region Registration
       public int ComplaintNo { get; set; }
       public int ID{ get; set; }
       public string ComplaintFor { get; set; }
       public string Reason { get; set; }
       public DateTime Date { get; set; }
      
       public int Mode { get; set; }
       #endregion
    }
}

    
