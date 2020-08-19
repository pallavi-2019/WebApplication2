using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace WebApplication2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
            string Username = "";

            if (Session["user"] != null)
            {
                Username = Session["user"].ToString();
            }

            if(Username == "")
            {
                Button2.Enabled = true;                
            }
            else
            {
                Button2.Enabled = false;                
            }

            /* First time load IsPostBack is false; Second and recurring reload IsPostback is true
            if (IsPostBack)
            {
                Response.Write("PostBack");
            }
            else
            {
                Response.Write("Not PostBack");
            }
            */
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Register.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=LAPTOP-PO6LMSNT\SQLEXPRESS; Initial Catalog = TestDatabase; User ID = sa; Password = pass123";
            SqlConnection conn;
            conn = new SqlConnection(ConnectionString);

            conn.Open();

            string sql = "Select * from UserLogin where loginID =" + "'" + TextBox1.Text + "'";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader DataReader;
            DataReader = command.ExecuteReader();

            if (DataReader.HasRows)
            {
                DataReader.Read();
                if (DataReader.GetValue(1).ToString() == TextBox2.Text)
                {
                    //delete Cart for old user if present
                    if (Session["user"] != null)
                    {
                            DeleteCartforUser(Session["user"].ToString());
                    }
                    Session["user"] = TextBox1.Text;
                    //AddToCart(Session["user"].ToString());
                    Response.Write("<script> alert('Successfull Login, redirecting to Catalog') </script>");
                    Response.AddHeader("REFRESH", "1,URL=https://localhost:44372/Catalog.aspx");
                    //Response.Redirect("~/billing.aspx");
                }
                else
                {
                    Label1.Text = "Invalid Login or Password Entered, please try again";
                    Label1.Visible = true;
                }
            }
            else
            {
                Label1.Text = "Invalid Login or Password Entered, please try again";
                Label1.Visible = true;
            }
            conn.Close();
            command.Dispose();
               
        }

        void DeleteCartforUser(string Username)
        {            
            string connectionString = @"Data Source=LAPTOP-PO6LMSNT\SQLEXPRESS; Initial Catalog = TestDatabase; User ID = sa; Password = pass123";
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "Delete from Cart where username = @username";

            SqlCommand command = new SqlCommand(sql, conn);

            command.Parameters.Add(@"username", SqlDbType.NVarChar, 10).Value = Username;

            SqlDataAdapter DataAdapter = new SqlDataAdapter();
            DataAdapter.DeleteCommand = command;             

            try
            {
                DataAdapter.DeleteCommand.ExecuteNonQuery();
            }
            catch
            {
                Response.Write("<script> alert('Error Deleting Cart for old user') </script>");
            }

            command.Dispose();
            conn.Close();
        }
        
    }

}
    