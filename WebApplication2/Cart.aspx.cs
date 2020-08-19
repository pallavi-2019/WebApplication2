using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write("Page Loaded");
            //<img src="Images/val1.jpg" style="width:250px;height:250px" />
            //Response.Write("<img src='Images/val1.jpg'>");
            string imagename = Request.QueryString["image"].ToString();
            imagename = "Images/" + imagename;
            Image1.ImageUrl = imagename;
            //Response.Write(imagename);
            //Response.Write("<img src=" + imagename + ">");
            Label2.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TextBox1.Text, out int result))
            {
                Label2.Visible = true;
                Label2.Text = "Invalid Quantity!! Enter value greater than zero";
                return;
            }

            if (result == 0)
            {
                    if (TextBox1.Text == "0")
                    {
                        Label2.Visible = true;
                        Label2.Text = "Enter quantity greater than zero";
                        return;
                    }
            }

            string Username = "";
            if (Session["user"] != null)
            {
                Username = Session["user"].ToString();
            }

            if (Username == "")
            {
                //AddToCart("Guest");
                /*string image = Request.QueryString["image"].ToString();
                 string item = Request.QueryString["item"].ToString();
                 Response.Redirect("~/login.aspx?" + "image="+image +"&item="+item);*/

                //First Need to Login for Add to Cart
                Response.Write("<script> alert('Please login before adding to cart, redirecting to Login') </script>");
                Response.AddHeader("REFRESH", ".1;URL=https://localhost:44372/Login.aspx");
            }
            else
            {
                AddToCart(Username);
                //Response.Redirect("~/billing.aspx");
                Response.Write("<script> alert('Item added to Card, redirecting to Catalog') </script>");

                //Response.Redirect("~/Catalog.aspx");
                Response.AddHeader("REFRESH", "1;URL=https://localhost:44372/Catalog.aspx");
            }


        }

        void AddToCart(string Username)
        {
            string ConnectionString = @"Data Source=LAPTOP-PO6LMSNT\SQLEXPRESS;Initial Catalog=TestDatabase;User Id=sa;Password=pass123";
            SqlConnection conn;
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            string sql = "Select distinct * from Cart where username = " + "'" + Username + "'";
            SqlCommand command;
            command = new SqlCommand(sql, conn);
            SqlDataReader DataReader;
            DataReader = command.ExecuteReader();

            command.Dispose();

            string item = Request.QueryString["item"].ToString();
            Response.Write("Item is " + item);
            string quantity = TextBox1.Text;

            if (DataReader.HasRows)
            {
                DataReader.Read();
                Response.Write("Row exists");
                int tblqty;
                int tempqty;
                switch (item)
                {
                    case "Item1":
                        tblqty = Int32.Parse(DataReader.GetValue(0).ToString());
                        tempqty = Int32.Parse(quantity) + tblqty;
                        quantity = tempqty.ToString();
                        Response.Write("Table Quantity is" + tblqty);
                        Response.Write("total Quantity is" + tempqty.ToString());
                        sql = "Update Cart set Item1_Quantity=" + quantity + "where username = " + "'" + Username + "'";
                        break;
                    case "Item2":
                        tblqty = Int32.Parse(DataReader.GetValue(1).ToString());
                        tempqty = Int32.Parse(quantity) + tblqty;
                        quantity = tempqty.ToString();
                        sql = "Update Cart set Item2_Quantity=" + quantity + "where username = " + "'" + Username + "'";
                        break;
                    case "Item3":
                        tblqty = Int32.Parse(DataReader.GetValue(2).ToString());
                        tempqty = Int32.Parse(quantity) + tblqty;
                        quantity = tempqty.ToString();
                        sql = "Update Cart set Item3_Quantity=" + quantity + "where username = " + "'" + Username + "'";
                        break;
                    case "Item4":
                        tblqty = Int32.Parse(DataReader.GetValue(3).ToString());
                        tempqty = Int32.Parse(quantity) + tblqty;
                        quantity = tempqty.ToString();
                        sql = "Update Cart set Item4_Quantity=" + quantity + "where username = " + "'" + Username + "'";
                        break;
                    case "Item5":
                        tblqty = Int32.Parse(DataReader.GetValue(4).ToString());
                        tempqty = Int32.Parse(quantity) + tblqty;
                        quantity = tempqty.ToString();
                        sql = "Update Cart set Item5_Quantity=" + quantity + "where username = " + "'" + Username + "'";
                        break;
                    case "Item6":
                        tblqty = Int32.Parse(DataReader.GetValue(5).ToString());
                        tempqty = Int32.Parse(quantity) + tblqty;
                        quantity = tempqty.ToString();
                        sql = "Update Cart set Item6_Quantity=" + quantity + "where username = " + "'" + Username + "'";
                        break;
                    case "Item7":
                        tblqty = Int32.Parse(DataReader.GetValue(6).ToString());
                        tempqty = Int32.Parse(quantity) + tblqty;
                        quantity = tempqty.ToString();
                        sql = "Update Cart set Item7_Quantity=" + quantity + "where username = " + "'" + Username + "'";
                        break;
                    case "Item8":
                        tblqty = Int32.Parse(DataReader.GetValue(7).ToString());
                        tempqty = Int32.Parse(quantity) + tblqty;
                        quantity = tempqty.ToString();
                        sql = "Update Cart set Item8_Quantity=" + quantity + "where username = " + "'" + Username + "'";
                        break;
                }
                SqlConnection conn1 = new SqlConnection(ConnectionString);
                SqlCommand command1 = new SqlCommand(sql, conn1);
                conn1.Open();

                SqlDataAdapter Adapter = new SqlDataAdapter();

                Adapter.UpdateCommand = command1;
                Adapter.UpdateCommand.ExecuteNonQuery();
                conn1.Close();
            }
            else
            {
                Response.Write("New row created");
                switch (item)
                {
                    case "Item1":
                        sql = "Insert into Cart values(" + quantity + ",0,0,0,0,0,0,0,'" + Username + "')";
                        break;
                    case "Item2":
                        sql = "Insert into Cart values(0," + quantity + ",0,0,0,0,0,0,'" + Username + "')";
                        break;
                    case "Item3":
                        sql = "Insert into Cart values(0,0," + quantity + ",0,0,0,0,0,'" + Username + "')";
                        break;
                    case "Item4":
                        sql = "Insert into Cart values(0,0,0," + quantity + ",0,0,0,0,'" + Username + "')";
                        break;
                    case "Item5":
                        sql = "Insert into Cart values(0,0,0,0," + quantity + ",0,0,0,'" + Username + "')";
                        break;
                    case "Item6":
                        sql = "Insert into Cart values(0,0,0,0,0" + quantity + ",0,0,'" + Username + "')";
                        break;
                    case "Item7":
                        sql = "Insert into Cart values(0,0,0,0,0,0" + quantity + ",0,'" + Username + "')";
                        break;
                    case "Item8":
                        sql = "Insert into Cart values(0,0,0,0,0,0,0," + quantity + ",'" + Username + "')";
                        break;
                }
                SqlConnection conn2 = new SqlConnection(ConnectionString);

                Response.Write("SQL is " + sql);

                SqlCommand command2 = new SqlCommand(sql, conn2);


                conn2.Open();

                SqlDataAdapter Adapter = new SqlDataAdapter();

                Adapter.InsertCommand = command2;
                Adapter.InsertCommand.ExecuteNonQuery();
                conn2.Close();
            }

            command.Dispose();

            conn.Close();

            
        }


        void UpdateCart(string Username)
        {
            string ConnectionString;
            ConnectionString = @"Data Source = LAPTOP-PO6LMSNT\SQLEXPRESS;Initial Catalog = TestDatabase; User ID=sa;Password = pass123";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string sql = "Update cart set username ='" + Username + "'";
            SqlCommand Command = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = Command;
            adapter.UpdateCommand.ExecuteNonQuery();

            Command.Dispose();
            conn.Close();

        }
    }
}