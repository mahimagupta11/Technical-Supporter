<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.Master" AutoEventWireup="true" CodeBehind="Adminlogin.aspx.cs" Inherits="WebApplication3.Adminlogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>
       Admin Login Page
    </title>
       <link href="css/loginPage.css" rel="stylesheet" />
 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divHeader">
        
    </div>
    <div id="divLeft">
         
    </div>
    <div id="divCenter">
       <div>
           
                <center><h3><asp:Label ID="Label1" runat="server" Text="Admin Login" Font-Size="Larger"></asp:Label></h3></center>
                <br />
           
        </div>
  
      <%--  <form id="form" runat="server">--%>
            <div id="divRemember">
    <div id="divUsername" >
        <center><asp:Label ID="lable1" Text="Username" runat="server" Font-Size="Larger"></asp:Label></center>
        <center><asp:TextBox ID="TextUsername"  CssClass="form-control" runat="server" ToolTip="Enter username"></asp:TextBox></center>
    </div>
    <br />

    <div id="divPassword">
        <center><asp:Label ID="Label2" Text="Password" runat="server" Font-Size="Larger"></asp:Label></center>
        <center><asp:TextBox ID="TextPassword" CssClass="form-control" Textmode="Password"  runat="server" ToolTip="Enter password"></asp:TextBox></center>
    </div>
    <br />
    
    </div>
    <br />
    <div id="divButton">
       <center> <asp:Button ID="ButtonLogin" CssClass="button" runat="server" Text="Login" OnClick="ButtonLogin_Click" /></center>
    </div>
   <%-- </form>
 --%>
    </div>
    <div id="divRight">

    </div>
    <div id="divSubFooter">
        
    </div>
   

</asp:Content>
