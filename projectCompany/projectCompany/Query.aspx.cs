using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projectCompany
{
    public partial class Query : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["username"] != null && Request.QueryString["password"] != null)
            {
                Label1.Text = Request.QueryString["username"];
                Label2.Text = Request.QueryString["password"];


            }
        }
    }
}