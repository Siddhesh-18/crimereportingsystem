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
    public partial class registration : System.Web.UI.Page
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
            reg.Fullname = txtfullname.Text;
            reg.Phoneno = Convert.ToInt64(txtphoneno.Text);
            reg.Address = TextArea1.InnerText;
            reg.Emailid = txtemailid.Text;
            reg.Password = txtpassword.Text;
            if (rdomale.Checked == true)
            {
                reg.Gender = "Male";
            }
            else if (rdofemale.Checked == true)
            {
                reg.Gender = "Female";
            }
            reg.Mode = 1;
            int r = reg.InsertDatawithoutoutput();
            if (r == -1)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Save Successfully');", true);
                Clear();
            }




        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Clear();

        }
        private void Clear()
        {
            txtusername.Text = string.Empty;
            txtfullname.Text = string.Empty;
            txtphoneno.Text = string.Empty;
            TextArea1.InnerText = string.Empty;
            txtemailid.Text = string.Empty;
            txtpassword.Text = string.Empty;


        }
    }
}