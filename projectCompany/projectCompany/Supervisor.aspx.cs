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
    public partial class Supervisor : System.Web.UI.Page
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
            cmd.CommandText = "insert into employees (username,salary)  values ('" + TextBox6.Text + "' ," + TextBox7.Text + " )   ";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void Button10_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-7LKJL60;Initial Catalog=company;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into reports (msg)  values ('" + TextBox4.Text + "'  )   ";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-7LKJL60;Initial Catalog=company;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from employees where id = " + TextBox3.Text + "  ";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-7LKJL60;Initial Catalog=company;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update employees set salary = " + TextBox5.Text + " where  id  = " + TextBox3.Text + " ";
            cmd.ExecuteNonQuery();
            con.Close();
          
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-7LKJL60;Initial Catalog=company;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from customers where id = " + TextBox8.Text + "  ";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-7LKJL60;Initial Catalog=company;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into customers (username,address)  values ('" + TextBox9.Text + "' ,'" + TextBox10.Text + "'  )   ";
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}