<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="Cart.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<asp:Content runat="server" ID="head" ContentPlaceHolderId="head">    
</asp:Content>
<asp:Content runat="server" ID="ContentPlaceHolder1" ContentPlaceHolderId="ContentPlaceHolder1">
    <div>
    <p> 
        <asp:Image ID="Image1" runat="server" style="width:250px;height:250px" />
        </p>
        <p> Enter No. of bouquets</p>
    <asp:Label ID="Label1" runat="server" Text="Quantity"></asp:Label> &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>   
    <br />
    <br />        
    &nbsp &nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;        
        <asp:Button ID="Button1" runat="server" Text="Add to Cart" OnClick="Button1_Click" /> 
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <br />
    </div>
</asp:Content>
