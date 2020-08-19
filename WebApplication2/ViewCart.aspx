<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="ViewCart.aspx.cs" Inherits="WebApplication2.ViewCart" %>


<asp:Content runat="server" ID="head" ContentPlaceHolderId="head">    
    <style type="text/css">
        .auto-style1 {
            margin-left: 0px;
        }
    </style>
</asp:Content>
<asp:Content runat="server" ID="ContentPlaceHolder1" ContentPlaceHolderId="ContentPlaceHolder1">
    
    <p>
        <asp:Image ID="Image1" runat="server" Height="150px" Width="150px" BorderStyle="Double" BorderWidth="5px"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label17" runat="server" Text="Oops.. Cart is Empty!! Browse Catalog and add to Cart!" Height="76px" Font-Bold="True" Font-Size="X-Large" Width="861px" CssClass="auto-style1"></asp:Label>
    </p>
    
    <asp:Label ID="Label2" runat="server" Text="Valentine's Special"></asp:Label>

     <p>
        <asp:Image ID="Image2" runat="server" Height="150px" Width="150px" BorderStyle="Double" BorderWidth="5px"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    </p>
    
    <asp:Label ID="Label4" runat="server" Text="Lovely Smile"></asp:Label>

     <p>
        <asp:Image ID="Image3" runat="server" Height="150px" Width="150px" BorderStyle="Double" BorderWidth="5px"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
    </p>
    
    <asp:Label ID="Label6" runat="server" Text="Pink Bloom"></asp:Label>

     <p>
        <asp:Image ID="Image4" runat="server" Height="150px" Width="150px" BorderStyle="Double" BorderWidth="5px"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
    </p>
    
    <asp:Label ID="Label8" runat="server" Text="Red Roses"></asp:Label>

     <p>
        <asp:Image ID="Image5" runat="server" Height="150px" Width="150px" BorderStyle="Double" BorderWidth="5px"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
    </p>
    
    <asp:Label ID="Label10" runat="server" Text="Pretty & Colorful"></asp:Label>

     <p>
        <asp:Image ID="Image6" runat="server" Height="150px" Width="150px" BorderStyle="Double" BorderWidth="5px"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
    </p>
    
    <asp:Label ID="Label12" runat="server" Text="Rosy Beauty"></asp:Label>

     <p>
        <asp:Image ID="Image7" runat="server" Height="150px" Width="150px" BorderStyle="Double" BorderWidth="5px"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
    </p>
    
    <asp:Label ID="Label14" runat="server" Text="Orange Magic"></asp:Label>

    <p>
        <asp:Image ID="Image8" runat="server" Height="150px" Width="150px" BorderStyle="Double" BorderWidth="5px"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
    </p>
    
    <asp:Label ID="Label16" runat="server" Text="Unique and Marvellous"></asp:Label>
    
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Proceed To Billing" Width="179px" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Continue Shopping" Width="186px" OnClick="Button2_Click" />
    
</asp:Content>
