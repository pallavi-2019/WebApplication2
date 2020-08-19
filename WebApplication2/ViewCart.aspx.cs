using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class ViewCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=LAPTOP-PO6LMSNT\SQLEXPRESS;Initial Catalog=TestDatabase;User Id=sa;Password=pass123";
            SqlConnection conn;
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            string Username = "";

            if (Session["user"] != null)
            {
                Username = Session["user"].ToString();
            }
            
            if(Username == "")
            {
                Label1.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label8.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;

                Image1.Visible = false;
                Image2.Visible = false;
                Image3.Visible = false;
                Image4.Visible = false;
                Image5.Visible = false;
                Image6.Visible = false;
                Image7.Visible = false;
                Image8.Visible = false;
                Button1.Visible = false;
                Button2.Visible = false;


                Response.Write("<script> alert('Please login prior to adding to Cart,redirecting to Login') </script>");
                Label17.Visible = true;

                Response.AddHeader("REFRESH", "1;URL=https://localhost:44372/Login.aspx");                
            }
            else
            {
                Label17.Visible = false;

                string sql = "Select * from cart where username = " + "'" + Username + "'";

                SqlCommand command;
                command = new SqlCommand(sql,conn);
                SqlDataReader DataReader;
                DataReader = command.ExecuteReader();

                command.Dispose();

                if (DataReader.HasRows)
                {
                    DataReader.Read();
                    
                    string quantity = DataReader.GetValue(0).ToString();
                    Response.Write("quantity is " + quantity);

                    string imagename = "";

                    Label1.Text = "Quantity = " + quantity;
                    Label1.Visible = true;
                    imagename = "Images/val1.jpg";
                    Image1.ImageUrl = imagename;

                    quantity = DataReader.GetValue(1).ToString();
                    Response.Write("quantity is " + quantity);

                    Label3.Text = "Quantity = " + quantity;
                    Label3.Visible = true;
                    imagename = "Images/val2.jpg";
                    Image2.ImageUrl = imagename;

                    quantity = DataReader.GetValue(2).ToString();
                    Response.Write("quantity is " + quantity);

                    Label5.Text = "Quantity = " + quantity;
                    Label5.Visible = true;
                    imagename = "Images/val3.jpg";
                    Image3.ImageUrl = imagename;

                    quantity = DataReader.GetValue(3).ToString();
                    Response.Write("quantity is " + quantity);

                    Label7.Text = "Quantity = " + quantity;
                    Label7.Visible = true;
                    imagename = "Images/val4.jpg";
                    Image4.ImageUrl = imagename;

                    quantity = DataReader.GetValue(4).ToString();
                    Response.Write("quantity is " + quantity);

                    Label9.Text = "Quantity = " + quantity;
                    Label9.Visible = true;
                    imagename = "Images/bir1.jpg";
                    Image5.ImageUrl = imagename;

                    quantity = DataReader.GetValue(5).ToString();
                    Response.Write("quantity is " + quantity);

                    Label11.Text = "Quantity = " + quantity;
                    Label11.Visible = true;
                    imagename = "Images/bir2.jpg";
                    Image6.ImageUrl = imagename;

                    quantity = DataReader.GetValue(6).ToString();
                    Response.Write("quantity is " + quantity);

                    Label13.Text = "Quantity = " + quantity;
                    Label13.Visible = true;
                    imagename = "Images/bir3.jpg";
                    Image7.ImageUrl = imagename;

                    quantity = DataReader.GetValue(7).ToString();
                    Response.Write("quantity is " + quantity);

                    Label15.Text = "Quantity = " + quantity;
                    Label15.Visible = true;
                    imagename = "Images/bir4.jpg";
                    Image8.ImageUrl = imagename;
                }

                conn.Close();

            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Billing.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Catalog.aspx");
        }
    }
}