<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.Master" AutoEventWireup="true" CodeBehind="adminViewActiveComplaintsM.aspx.cs" Inherits="WebApplication3.WebForm15" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Active Complaints</title>
     <style>
           .button 
{
    background-color: dodgerblue;
    padding: 10px 26px;
    color: black;
    border-radius: 20px;
    text-align: center;
    font-size: 15px;
    font-family: Verdana;
}
.button:hover
{
    background-color:white;
    color:black;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%--     <form id="form1" runat="server">--%>
     <center>
        <div>
   
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="complaint_Id" CellPadding="4" ForeColor="#333333" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="complaint_Id" HeaderText="Complaint Id" InsertVisible="False" ReadOnly="True" SortExpression="complaint_Id" />
                <asp:BoundField DataField="complaint_body" HeaderText="Complaint Body" SortExpression="complaint_body" />
                <asp:BoundField DataField="date_of_submission" HeaderText="Submission Date" SortExpression="date_of_submission" />
                <asp:BoundField DataField="date_of_resolution" HeaderText="Resolution Date" SortExpression="date_of_resolution" />
                <asp:BoundField DataField="complaint_status" HeaderText="Complaint status" SortExpression="complaint_status" />
                <asp:BoundField DataField="Complaint_Type" HeaderText="Complaint Type" SortExpression="Complaint_Type" />
          
            </Columns>

             <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
       
            
        </asp:GridView>
          
         
    </div>
        <asp:Button ID="Button1" CssClass="button" runat="server" OnClick="Button1_Click" Text="Back" />
        </center>
<%--    </form>--%>
</asp:Content>
