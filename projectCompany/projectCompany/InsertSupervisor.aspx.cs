using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace projectCompany
{
    public partial class InsertSupervisor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-7LKJL60;Initial Catalog=company;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into supervisor (username,password,salary)  values ('" + TextBox1.Text + "' ,'" + TextBox2.Text + "' ," + TextBox3.Text + "  )   ";
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Manager.aspx");
        }
    }
}