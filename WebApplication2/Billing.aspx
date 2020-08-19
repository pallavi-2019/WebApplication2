<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Billing.aspx.cs" MasterPageFile="~/Site1.Master" Inherits="WebApplication2.Billing" %>

<asp:Content runat="server" ID="head" ContentPlaceHolderId="head">    
    <style type="text/css">
        .auto-style2 {
            margin-left: 40px;
        }
    </style>
</asp:Content>
<asp:Content runat="server" ID="ContentPlaceHolder1" ContentPlaceHolderId="ContentPlaceHolder1">
    <div class="home">

    </div>
    <div class="home1">
    <br />
    <br />

    <p>
        
        Enter Card Details for processing the Order

    </p>

    <p style="align-content:center">
        
       Total Amount&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="10.00"></asp:Label>
    </p>
    <p>
        
        Card Number&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        
        Billing Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        
        Date of Delivery&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>        
    </p>
    <p>
        <br />
        
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Process Order" />
    </p>
    <p class="auto-style2">
        
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </p>
    </div>
    <div class="home2">

    </div>
</asp:Content>
