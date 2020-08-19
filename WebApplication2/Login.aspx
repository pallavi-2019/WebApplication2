<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="Login.aspx.cs" Inherits="WebApplication2.Login" %>

<asp:Content runat="server" ID="head" ContentPlaceHolderId="head">    
    <style type="text/css">
        .auto-style1 {
            margin-bottom: 10px;
        }
    </style>
</asp:Content>
<asp:Content runat="server" ID="ContentPlaceHolder1" ContentPlaceHolderId="ContentPlaceHolder1">
    <div class="home">
    </div>
    <div class="home1">

        
        <br />

        <br />
<strong> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>Enter Login and Password<br />
        <br />
         Login ID&nbsp;<strong>&nbsp;&nbsp;</strong>
        <asp:TextBox ID="TextBox1" runat="server" Height="25px" Width="213px" ClientIDMode="Static"></asp:TextBox>
        <br />
        <br />
         <strong>&nbsp;</strong>Password&nbsp;&nbsp;<strong>
        </strong>
        <asp:TextBox ID="TextBox2" runat="server" Height="24px" Width="216px" TextMode="Password" ClientIDMode="Static"></asp:TextBox>
        <br />
&nbsp;&nbsp;<br />

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:Button ID="Button1" runat="server" Text="Login" Height="28px" OnClientClick="return validate();" OnClick="Button1_Click" Width="89px" CssClass="auto-style1" />  
        &nbsp;&nbsp;
        <br />

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:Button ID="Button2" runat="server" Text="New User Register Here" Height="28px" OnClick="Button2_Click" Width="230px" />
        <br />
        <br />

        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />


    </div>
    <div class="home2">
    </div>
    <script src="UserValidation.js"></script>

    </asp:Content>

