using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crimereportingsystem
{
    public partial class adminlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "titiksham" && txtpassword.Text=="123456")
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Login successfull')", true);
                Response.Redirect("datagridview.aspx");
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Login Unsuccessfull')", true);
            }
        }

        protected void btncancel_Click(object sender, EventArgs e)
        {
           

        }
    }
}