<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebApplication3.WebForm3" %>
<%@ OutputCache Duration="60000" VaryByParam="None" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Contact Us</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table width="1000" align="center" class="ctable">
        <tr>
            <td width="50%">
             <h3>Here we are</h3>
            <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d30711419.829385255!2d64.43134076828144!3d20.01050333078031!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x30635ff06b92b791%3A0xd78c4fa1854213a6!2sIndia!5e0!3m2!1sen!2sin!4v1586095775710!5m2!1sen!2sin" width="100%" height="450" frameborder="0" style="border:0;" allowfullscreen="" aria-hidden="false" tabindex="0"></iframe>
            </td>
            <td valign="top">
               <h3>Our Contact Details</h3>
               <hr />
               <strong>Name : </strong>Dipti Munjal<br />
               <strong>Mobile : </strong>9899778138<br />
               <strong>Email : </strong>diptimunjal03@gmail.com<br />
               <strong>Address : </strong>Noida<br />
                <br />

               <hr />
               <strong>Name : </strong>Mahima Gupta<br />
               <strong>Mobile : </strong>9873683036<br />
               <strong>Email : </strong>mahimagupta1110@gmail.com<br />
               <strong>Address : </strong>Shalimar Bagh<br />
                <br />

               <hr />
               <strong>Name : </strong>Sonia Rani<br />
               <strong>Mobile : </strong>9953731005<br />
               <strong>Email : </strong>11soniarani@gmail.com<br />
               <strong>Address : </strong>Rohini<br />

            </td>
        </tr>

    </table>
</asp:Content>
