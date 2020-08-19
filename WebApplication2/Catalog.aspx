<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="Catalog.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<asp:Content runat="server" ID="head" ContentPlaceHolderId="head">    
</asp:Content>
<asp:Content runat="server" ID="ContentPlaceHolder1" ContentPlaceHolderId="ContentPlaceHolder1">
    <div>
        
        <div class="itemhead"><b> Valentine's Day </b> </div>
        <br />        
        <br />
        
        <div class="item">
            <a href="Cart.aspx?image=val1.jpg&item=Item1"><img src="Images/val1.jpg" style="width:268px;height:268px" /></a>
            
        <span class="caption">Valentine's Special</span>
            <span class="caption">$80</span>
        </div>

        <div class="item">
            <a href="Cart.aspx?image=val2.jpg&item=Item2"><img src="Images/val2.jpg" style="width:268px;height:268px" /></a>
        
        <span class="caption">Lovely Smile</span>
            <span class="caption">$100</span>
        </div>

        <div class="item">
        <a href="Cart.aspx?image=val3.jpg&item=Item3"><img src="Images/val3.jpg" style="width:268px;height:268px" /></a>
        <span class="caption">Pink Bloom</span>
            <span class="caption">$90</span>
        </div>

        <div class="item">
        <a href="Cart.aspx?image=val4.jpg&item=Item4"><img src="Images/val4.jpg" style="width:268px;height:268px" /></a>
        <span class="caption">Red Roses</span>
            <span class="caption">$120</span>
        </div>

        <br />
        <br />

        <div class="itemhead"><b> Birthday Flowers </b> </div>
        
        <br />
        <br />
        
        <div class="item">
            <a href="Cart.aspx?image=bir1.jpg&item=Item5"><img src="Images/bir1.jpg" style="width:268px;height:268px" /></a>
            
        <span class="caption">Pretty & Colorful</span>
            <span class="caption">$90</span>
        </div>
        
        <div class="item">
        <a href="Cart.aspx?image=bir2.jpg&item=Item6"><img src="Images/bir2.jpg" style="width:268px;height:268px" /></a>
        <span class="caption">Rosy Beauty</span>
            <span class="caption">$70</span>
        </div>
        
        <div class="item">
        <a href="Cart.aspx?image=bir3.jpg&item=Item7"><img src="Images/bir3.jpg" style="width:268px;height:268px" /></a>
        <span class="caption">Orange Magic</span>
            <span class="caption">$110</span>
        </div>
        
        <div class="item">
        <a href="Cart.aspx?image=bir4.jpg&item=Item8"><img src="Images/bir4.jpg" style="width:268px;height:268px" /></a>
        <span class="caption">Unique and Marvellous</span>
            <span class="caption">$200</span>
        </div>

        <br />
        <br />

    </div>
</asp:Content>