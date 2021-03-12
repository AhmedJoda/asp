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
    public partial class Manager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertSupervisor.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-7LKJL60;Initial Catalog=company;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update supervisor set salary = " + TextBox3.Text + " where  id  = " + TextBox1.Text +  " ";
            cmd.ExecuteNonQuery();
            con.Close();
            
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-7LKJL60;Initial Catalog=company;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from supervisor where id = " + TextBox1.Text + "  ";
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Manager.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-7LKJL60;Initial Catalog=company;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from reports where id = " + TextBox2.Text + " ";
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Manager.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("Query.aspx");
        }
    }
}