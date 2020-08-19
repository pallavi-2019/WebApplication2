<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Order.aspx.cs" MasterPageFile="~/Site1.Master" Inherits="WebApplication2.Order" %>

<asp:Content runat="server" ID="head" ContentPlaceHolderId="head">        
</asp:Content>
<asp:Content runat="server" ID="ContentPlaceHolder1" ContentPlaceHolderId="ContentPlaceHolder1">



 <div class="home">

            </div>

            <div class="home1">
    <!--p style="text-align:center;font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;font-size:large"-->
        <br />
        <br />
        <br />
        Order Processed successfully 
        <br />
        Flowers will be delivered on <%=Request.QueryString["date"]%> 
        <br />
        <br />
        <br />
        <br />


        <b> Thank you for shopping with us!! </b> 
    <!--/!--p-->

</div>
        <div class="home2">

        </div>
    </asp:Content>