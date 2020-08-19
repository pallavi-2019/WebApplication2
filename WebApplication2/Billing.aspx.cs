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
    public partial class Billing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Visible = false;

            string ConnectionString = @"Data Source=LAPTOP-PO6LMSNT\SQLEXPRESS;Initial Catalog=TestDatabase;User Id=sa;Password=pass123";


            string Username = "";

            if (Session["user"] != null)
            {
                Username = Session["user"].ToString();
            }

            if (Username == null)
            {
                Response.Write("<script> alert('Not Logged in, redirecting to Login') </script>");
                Response.AddHeader("REFRESH", "1, URL = https://localhost:44372/Login.aspx");
            }
            else
            {
                SqlConnection conn;
                conn = new SqlConnection(ConnectionString);
                conn.Open();

                SqlConnection conn1;
                conn1 = new SqlConnection(ConnectionString);
                conn1.Open();
                int total = 0;

                string sql = "Select * from Cart where username = " + "'" + Username + "'";

                SqlCommand command;
                command = new SqlCommand(sql, conn);
                SqlDataReader DataReader;
                DataReader = command.ExecuteReader();

                if (DataReader.HasRows)
                {
                    DataReader.Read();
                    string quantity;

                    quantity = DataReader.GetValue(0).ToString();

                    string sql1 = "Select cost from Fcatalog where item = 'item1'";

                    SqlCommand command1;
                    command1 = new SqlCommand(sql1, conn1);
                    SqlDataReader DataReader1;
                    DataReader1 = command1.ExecuteReader();

                    if (DataReader1.HasRows)
                    {
                        DataReader1.Read();
                        string amount = DataReader1.GetValue(0).ToString();

                        total += Int32.Parse(quantity) * Int32.Parse(amount);
                        Label1.Text = total.ToString();
                        Label1.Visible = true;
                    }
                    command1.Dispose();
                    DataReader1.Close();

                    quantity = DataReader.GetValue(1).ToString();
                    sql1 = "Select cost from Fcatalog where item = 'item2'";

                    command1 = new SqlCommand(sql1, conn1);
                    DataReader1 = command1.ExecuteReader();

                    if (DataReader1.HasRows)
                    {
                        DataReader1.Read();
                        string amount = DataReader1.GetValue(0).ToString();

                        total += Int32.Parse(quantity) * Int32.Parse(amount);
                        Label1.Text = total.ToString();
                        Label1.Visible = true;
                    }
                    command1.Dispose();
                    DataReader1.Close();

                    quantity = DataReader.GetValue(2).ToString();
                    sql1 = "Select cost from Fcatalog where item = 'item3'";

                    command1 = new SqlCommand(sql1, conn1);
                    DataReader1 = command1.ExecuteReader();

                    if (DataReader1.HasRows)
                    {
                        DataReader1.Read();
                        string amount = DataReader1.GetValue(0).ToString();

                        total += Int32.Parse(quantity) * Int32.Parse(amount);
                        Label1.Text = total.ToString();
                        Label1.Visible = true;
                    }
                    command1.Dispose();
                    DataReader1.Close();

                    quantity = DataReader.GetValue(3).ToString();
                    sql1 = "Select cost from Fcatalog where item = 'item4'";

                    command1 = new SqlCommand(sql1, conn1);
                    DataReader1 = command1.ExecuteReader();

                    if (DataReader1.HasRows)
                    {
                        DataReader1.Read();
                        string amount = DataReader1.GetValue(0).ToString();

                        total += Int32.Parse(quantity) * Int32.Parse(amount);
                        Label1.Text = total.ToString();
                        Label1.Visible = true;
                    }
                    command1.Dispose();
                    DataReader1.Close();

                    quantity = DataReader.GetValue(4).ToString();
                    sql1 = "Select cost from Fcatalog where item = 'item5'";

                    command1 = new SqlCommand(sql1, conn1);
                    DataReader1 = command1.ExecuteReader();

                    if (DataReader1.HasRows)
                    {
                        DataReader1.Read();
                        string amount = DataReader1.GetValue(0).ToString();

                        total += Int32.Parse(quantity) * Int32.Parse(amount);
                        Label1.Text = total.ToString();
                        Label1.Visible = true;
                    }
                    command1.Dispose();
                    DataReader1.Close();

                    quantity = DataReader.GetValue(5).ToString();
                    sql1 = "Select cost from Fcatalog where item = 'item6'";

                    command1 = new SqlCommand(sql1, conn1);
                    DataReader1 = command1.ExecuteReader();


                    if (DataReader1.HasRows)
                    {
                        DataReader1.Read();
                        string amount = DataReader1.GetValue(0).ToString();

                        total += Int32.Parse(quantity) * Int32.Parse(amount);
                        Label1.Text = total.ToString();
                        Label1.Visible = true;
                    }
                    command1.Dispose();
                    DataReader1.Close();

                    quantity = DataReader.GetValue(6).ToString();
                    sql1 = "Select cost from Fcatalog where item = 'item7'";

                    command1 = new SqlCommand(sql1, conn1);
                    DataReader1 = command1.ExecuteReader();

                    if (DataReader1.HasRows)
                    {
                        DataReader1.Read();
                        string amount = DataReader1.GetValue(0).ToString();

                        total += Int32.Parse(quantity) * Int32.Parse(amount);
                        Label1.Text = total.ToString();
                        Label1.Visible = true;
                    }
                    command1.Dispose();
                    DataReader1.Close();
                    quantity = DataReader.GetValue(7).ToString();
                    sql1 = "Select cost from Fcatalog where item = 'item8'";

                    command1 = new SqlCommand(sql1, conn1);
                    DataReader1 = command1.ExecuteReader();

                    if (DataReader1.HasRows)
                    {
                        DataReader1.Read();
                        string amount = DataReader1.GetValue(0).ToString();

                        total += Int32.Parse(quantity) * Int32.Parse(amount);
                        Label1.Text = total.ToString();
                        Label1.Visible = true;
                    }
                    command1.Dispose();
                    DataReader1.Close();

                }

                command.Dispose();

                conn.Close();
                conn1.Close();

                if (total == 0)
                {
                    Response.Write("<script> alert('No items in cart, redirecting to Catalog') </script>");
                    Response.AddHeader("REFRESH", "1, URL = https://localhost:44372/Catalog.aspx");
                }
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length != 15)
            {
                Label2.Text = "Card Number should be 15 characters";
                Label2.Visible = true;
            }
            else
            {
                /*if (!int.TryParse(TextBox1.Text, out int result))
                {

                    Label2.Text = "Card number should be numeric";
                    Label2.Visible = true;
                }
                else */

                if (TextBox2.Text.Length < 0 || TextBox2.Text.Length > 30)
                {
                    Label2.Text = "Address should be less that 30 characters";
                    Label2.Visible = true;
                }
                else
                {
                    //DateTime result;
                    if (!DateTime.TryParse(TextBox3.Text, out DateTime res))
                    {
                        Label2.Text = "Enter a Valid Date";
                        Label2.Visible = true;
                    }
                    else
                    {
                        if (res < DateTime.Now)
                        {
                            Label2.Text = "Enter a date today or later";
                            Label2.Visible = true;
                        }
                        else
                        {

                            string connectionString = @"Data Source=LAPTOP-PO6LMSNT\SQLEXPRESS; Initial Catalog = TestDatabase; User ID = sa; Password = pass123";
                            SqlConnection conn;
                            conn = new SqlConnection(connectionString);
                            conn.Open();

                            

                            string Username = "";
                            if (Session["user"] != null)
                            {
                                Username = Session["user"].ToString();
                            }
                            
                            string sql = "Insert into bill (username,amount,cardno,daddress,delivery_date) Values(@username,@amount, @cardno, @daddress, @delivery_date)";
                            

                            SqlCommand command;
                            command = new SqlCommand(sql, conn);

                            command.Parameters.Add(@"username", SqlDbType.NVarChar, 10).Value = Username;
                            command.Parameters.Add(@"amount", SqlDbType.Int).Value = int.Parse(Label1.Text);
                            command.Parameters.Add(@"cardno", SqlDbType.NVarChar,15).Value = TextBox1.Text;
                            command.Parameters.Add(@"daddress", SqlDbType.NVarChar,30).Value = TextBox2.Text;
                            command.Parameters.Add(@"delivery_date",SqlDbType.Date).Value = TextBox3.Text;

                            SqlDataAdapter Adapter = new SqlDataAdapter();
                            Adapter.InsertCommand = command;

                            try
                            {
                                Adapter.InsertCommand.ExecuteNonQuery();
                            }
                            catch(Exception)
                            {
                                Response.Write("<script> alert('Insert to bill error') </script>");
                            }
                            finally
                            {
                                //Order processed successfully, remove from cart
                                SqlConnection conn1;
                                conn1 = new SqlConnection(connectionString);
                                conn1.Open();

                                SqlCommand command1;
                                string sql2 = "Delete from cart where username = @username";
                                command1 = new SqlCommand(sql2, conn1);
                                
                                command1.Parameters.Add(@"username",SqlDbType.NVarChar, 10).Value = Username;

                                SqlDataAdapter Adapter1 = new SqlDataAdapter();
                                Adapter1.DeleteCommand = command1;

                                try
                                {
                                    Adapter1.DeleteCommand.ExecuteNonQuery();
                                }
                                catch
                                {
                                    Response.Write("<script> alert('Delete from cart failed') </script>");
                                }

                                command1.Dispose();
                                conn1.Close();
                            }

                            command.Dispose();
                            conn.Close();

                            Response.Write("<script> alert('Order processed') </script>");
                            Response.AddHeader("REFRESH", "1 , URL=https://localhost:44372/Order.aspx?date=" + TextBox3.Text);
                        }
                    }
                }

                //Response.Redirect("~/Order.aspx");
            }
        }
    }
}