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
    public partial class login : System.Web.UI.Page
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
            cmd.CommandText = "select * from manager where username ='" + TextBox1.Text + "' and password ='" + TextBox2.Text + "'";
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            if (dt.Rows.Count > 0)
            {
                Response.Redirect("Manager.aspx");
            }
            else
            {

                SqlConnection con2 = new SqlConnection();
                con2.ConnectionString = ("Data Source=DESKTOP-7LKJL60;Initial Catalog=company;Integrated Security=True");
                con2.Open();

                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = con2;
                cmd2.CommandText = "select * from supervisor where username ='" + TextBox1.Text + "' and password ='" + TextBox2.Text + "'";
                DataTable dt2 = new DataTable();
                dt2.Load(cmd2.ExecuteReader());
                if (dt2.Rows.Count > 0)
                {
                   
                    Response.Redirect("Supervisor.aspx?username='"+TextBox1.Text+"'&password="+TextBox2.Text+"       ");
                    
                }
                else
                {
                    Label3.Visible = true;
                }

            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}