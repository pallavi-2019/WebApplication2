<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="Register.aspx.cs" Inherits="WebApplication2.Register" %>

<asp:Content runat="server" ID="head" ContentPlaceHolderId="head">    
    
</asp:Content>
<asp:Content runat="server" ID="ContentPlaceHolder1" ContentPlaceHolderId="ContentPlaceHolder1">
    


    <div class="home">
    </div>
    <div class="home1">

        <br />
        <br />
        <br />

    
        Enter the below details to Register
        <br />
        <br />
        <br />
        Login ID&nbsp;<strong>&nbsp;&nbsp;</strong>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="IdBox" runat="server" ClientIDMode="Static"></asp:TextBox>
   
        <strong>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;</strong>Password&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="PassBox" runat="server" TextMode="Password" ClientIDMode="Static"></asp:TextBox> &nbsp &nbsp<br />
        <br />
        <br />
&nbsp;<asp:Button ID="Button1" runat="server" OnClientClick="return validUserAndPass();" OnClick="Button1_Click" Text="Register" />

&nbsp;&nbsp;        
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Return to Login" />
    
        &nbsp;<br />
        <br />
&nbsp;<strong><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </strong>

  
</div>
<div class="home2">
</div>
<script src="UserValidation.js"></script> 
    </asp:Content>
