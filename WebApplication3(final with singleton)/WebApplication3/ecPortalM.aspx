<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.Master" AutoEventWireup="true" CodeBehind="ecPortalM.aspx.cs" Inherits="WebApplication3.WebForm6" %>
<%--@ OutputCache Duration="60000" VaryByParam="None" --%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>EC Portal</title>
        <link href="css/ecPortalM.css" rel="stylesheet" />

    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divbtn">
   
      <center>
           
        <h3><asp:Label ID="Label1" CssClass="label" runat="server" Text="Label" BackColor="Snow" ForeColor="SlateBlue" BorderStyle="Solid" BorderColor="Silver" ></asp:Label></center></h3>
               <br /><br /><br />
             
           <center> <asp:Button ID="Button1" CssClass="button" runat="server" Text="Register Complaint" OnClick="Button1_Click" /></center>
        <br />
        <center><asp:Button ID="Button2" CssClass="button" runat="server" Text="View Registered Complaints" OnClick="Button2_Click" /></center>
        <br />
        <center><asp:Button ID="Button3" CssClass="button" runat="server" Text="View Assigned Complaints " OnClick="Button3_Click" /></center>
        <br />
    </div>
    
</asp:Content>
