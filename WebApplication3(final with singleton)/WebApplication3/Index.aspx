<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication3.WebForm1" %>
<%--@ OutputCache Duration="30" VaryByParam="None" --%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Technical Supporter</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="1000" align="center" class="ctable">
        <tr>
            <td width="50%">
              <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/cs.jpg" />
            </td>
            <td>
                <h3>Welcome to Technical Supporter.</h3>
                <p>
                    This website helps all the members of the company to come and get help in 
                    all the technical problems they face on daily basis in the office on their systems.
                </p>
            </td>
        </tr>
    </table>
</asp:Content>
