using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Data.SqlClient;

namespace WebApplication2
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            string Username = "";

            if (Session["user"] != null)
            {
                Username = Session["user"].ToString();
            }

            if (Username != null)
            {
                DeleteCart(Username);
            }
        }

        protected void Application_End(object sender, EventArgs e)
        {
            string Username = "";

            if (Session["user"] != null)
            {
                Username = Session["user"].ToString();
            }

            if (Username != null)
            {
                DeleteCart(Username);
            }

        }

        protected void DeleteCart(string Username)
        {
            string ConnectionString;
            ConnectionString = @"Data Source = LAPTOP-PO6LMSNT\SQLEXPRESS;Initial Catalog = TestDatabase; User ID=sa;Password = pass123";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string sql = "Delete from cart where username ='" + Username + "'";
            SqlCommand Command = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.DeleteCommand = Command;
            adapter.DeleteCommand.ExecuteNonQuery();

            Command.Dispose();
            conn.Close();
        }
    }
}