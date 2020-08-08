<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.Master" AutoEventWireup="true" CodeBehind="viewRegisteredComplaintsM.aspx.cs" Inherits="WebApplication3.WebForm14" %>
<%--@ OutputCache Duration="30" VaryByParam="id"--%>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Registered Complaints</title>
        <link href="css/ComplaintsAndEngineer.css" rel="stylesheet" />

   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%--    <form id="form1" runat="server">--%>
    <div>

 
       <center>
           <%--<asp:Label id="l1" runat="server"></asp:Label>--%>

           <asp:GridView ID="gvC" runat="server" AutoGenerateColumns = "false"
                AllowPaging = "true" OnPageIndexChanging = "OnPaging" OnRowCommand="GridView1_RowCommand" CellPadding="8" ForeColor="#333333" DataKeyNames="ComplaintId" >
                  <Columns>
                     <asp:BoundField DataField = "ComplaintId" HeaderText = "Complaint ID" />
                     <asp:BoundField DataField = "Complaint_body" HeaderText = "Complaint body" />
                     <asp:BoundField DataField = "Date_of_submission" HeaderText = "Date of submission" />
                     <asp:BoundField DataField = "Sol_sugg" HeaderText = "Solution" />
                     <asp:BoundField DataField = "Status" HeaderText = "Complaint Status" />
                     <asp:TemplateField HeaderText ="Controls">  
                        <ItemTemplate>
                           <asp:Button Text="Close Complaint" CssClass="btn" runat="server" CommandName="Close" CommandArgument="<%# Container.DataItemIndex %>" />
                            
                        </ItemTemplate>
                 </asp:TemplateField>
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



      
      
           </center> 
        <div id="divbtn">
         <center><asp:Button ID="btnBack" CssClass="button" Text="Back" runat="server" OnClick="btnBack_Click" /></center>
        </div>
        
         </div>
<%--    </form>--%>
</asp:Content>
