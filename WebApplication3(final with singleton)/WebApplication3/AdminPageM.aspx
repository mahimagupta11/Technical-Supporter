<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.Master" AutoEventWireup="true" CodeBehind="AdminPageM.aspx.cs" Inherits="WebApplication3.WebForm5" %>
<%--@ OutputCache Duration="60000" VaryByParam="None" --%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Admin Page</title>
       <link href="css/ecPortalM.css" rel="stylesheet" />
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <%--<form id="form1" runat="server">--%>
    <div id="divbtn">
    
        <center><h3><asp:Label ID="Label1" CssClass="label" Text="Hello Admin !!" runat="server"  BackColor="Snow" ForeColor="SlateBlue" BorderStyle="Solid" BorderColor="Silver" ></asp:Label></center></h3>
        <br /><br /><br />
        <center><asp:Button ID="Button1" CssClass="button" runat="server" Text="View All Complaints" OnClick="Button1_Click" /></center>
        <br />
        <center><asp:Button ID="Button2" CssClass="button" runat="server" Text="View Active Complaints" OnClick="Button2_Click" /></center>
        <br />
          <center><asp:Button ID="Button5" CssClass="button" runat="server" Text="View Closed Complaints" OnClick="Button5_Click" /></center>
        <br />
        <center><asp:Button ID="Button3" CssClass="button" runat="server" Text="Assign Engineer" OnClick="Button3_Click" /></center>
        </br/>
        <center><asp:Button ID="Button4" CssClass="button" runat="server" Text="Generate Report" OnClick="Button4_Click" /></center>
         </br/>
      
         
    
    </div>
    <%--/form>--%>
</asp:Content>
