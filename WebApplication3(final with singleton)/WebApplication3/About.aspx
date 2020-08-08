<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApplication3.WebForm2" %>
<%@ OutputCache Duration="60000" VaryByParam="None" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>About</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="1000" align="center" class="ctable">
        <tr>
            <td width="50%">
             <h3>About Technical Supporter</h3>
             <p>
                 Technical Supporter is a system used in our company to automate the process of
                 registering and solving technical difficulties.  
                 The system works in a way that the employees can add their complaints to the 
                    portal and an engineer will be assigned to it and he will resolve the 
                    problem and update the status to the employee. 
             </p>
            </td>
            <td>
                <h3>How to Use</h3>
                <p>
                  Any employee can login to the system using thier login credentials and then he
                    can register his or her complaint, if the problem is self solvable then an
                    alternative method will be provided otherwise an engineer will be assigned to
                    the particular employee's complaint and he will solve it in given time.
                </p>
            </td>
        </tr>

    </table>
</asp:Content>
