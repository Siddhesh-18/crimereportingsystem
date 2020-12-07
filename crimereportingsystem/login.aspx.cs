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
    public partial class login : System.Web.UI.Page
    {
        clsregistration reg = new clsregistration();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            reg.Id = 0;
            reg.Username = txtusername.Text;
            reg.Fullname = string.Empty;
            reg.Address = string.Empty;
            reg.Emailid = string.Empty;
            reg.Password = txtpassword.Text;
            reg.Gender = string.Empty;
            reg.Mode = 2;
            ds = reg.GetDataSet();
            if (ds!=null && ds.Tables[0].Rows.Count>0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Login Done successfully')", true);
                Cancel();
                clsstatic.fullname = ds.Tables[0].Rows[0]["FullName"].ToString();
                clsstatic.phoneno = Convert.ToInt64(ds.Tables[0].Rows[0]["Phoneno"].ToString());
                clsstatic.address = ds.Tables[0].Rows[0]["Address"].ToString();
                clsstatic.ID = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"].ToString());
                Response.Redirect("complaintpage.aspx");

            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Login Unsuccessfull')", true);
            }










        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Cancel();
        }
        private void Cancel()
        {
            txtusername.Text = string.Empty;
            txtpassword.Text = string.Empty;

        }
    }
}