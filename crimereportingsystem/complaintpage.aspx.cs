using ClassLibrary1.bal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crimereportingsystem
{
    public partial class complaintpage : System.Web.UI.Page
    {
        clscomplaint reg = new clscomplaint();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtfullname.Text = clsstatic.fullname;
            txtphoneno.Text = Convert.ToString(clsstatic.phoneno);
            txtaddress.Text = clsstatic.address;
            txtdate.Text = Calendar1.SelectedDate.ToString();
            

           
            
           
   }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
           reg.ComplaintNo = 0;
            reg.ID = clsstatic.ID;
            reg.ComplaintFor = txtcomplaintfor.Text;
            reg.Reason = txtcomplaintreason.Text;
            reg.Date = Convert.ToDateTime(txtdate.Text);
            reg.Mode = 1;
            int m = reg.InsertDatawithoutoutput();
            if(m == -1)
            {
                ScriptManager.RegisterStartupScript(this, GetType(),"showalert", "alert('Your complaint is registered successfully')",true);
            }
            }
            catch(Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(),"showalert", "alert('An error occured')",true);

            }



        
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        
        }



        }
    }
