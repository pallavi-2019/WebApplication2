using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string ConnectionString;
            ConnectionString = @"Data Source=LAPTOP-PO6LMSNT\SQLEXPRESS; Initial Catalog=TestDatabase; User ID = sa;Password = pass123";
            SqlConnection conn;
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            string sql = "Select * from UserLogin where loginID = " + "'" + IdBox.Text + "'";
            SqlCommand command = new SqlCommand(sql, conn);

            SqlDataReader dataReader;
            dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                Label1.Visible = true;
                Label1.Text = "User Id already present, try another one";
                command.Dispose();
                conn.Close();
            }
            else
            {
                if (PassBox.Text == " ")
                {
                    Label1.Visible = true;
                    Label1.Text = "Please enter Password";
                }
                else
                {
                    SqlConnection conn1 = new SqlConnection(ConnectionString);
                    conn1.Open();

                    string sql1 = "Insert into UserLogin values('" + IdBox.Text + "','" + PassBox.Text + "')";
                    SqlCommand command1 = new SqlCommand(sql1, conn1);

                    SqlDataAdapter Adapter = new SqlDataAdapter();
                    Adapter.InsertCommand = command1;
                    Adapter.InsertCommand.ExecuteNonQuery();

                    command.Dispose();
                    conn1.Close();

                    Label1.Visible = true;
                    Label1.Text = "Registration complete, redirecting to Login";
                        
                    //Response.Redirect("~/Catalog.aspx");
                    Response.AddHeader("REFRESH", "1;URL=https://localhost:44372/Login.aspx");
                }
            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }
    }
}